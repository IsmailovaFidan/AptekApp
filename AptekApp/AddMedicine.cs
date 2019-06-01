using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AptekApp.Model;
namespace AptekApp
{
    public partial class AddMedicine : Form
    {
        MedicineEntities db = new MedicineEntities();
        int locX = 10;
        int LocY = 20;
        int marginX = 10;
        int marginY = 10;
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            FillFirms();
            FillDataGridMedicine();
            FillTags();
           
        }
        private void FillDataGridMedicine()
        {
            dtgAddMedicine.DataSource = db.Medicines.Where(m => m.Count > 0)
                .Select(m => new
                {
                    Name = m.Name,
                    QrCode = m.Qr_Code,
                    WithReceipt = m.WithRecept == 0 ? "Reseptsiz" : "Reseptli",
                    ProDate = m.Pro_date,
                    ValidDate = m.Valid_date,
                    Firms = m.Firm.Name,
                    Price = m.Price + " Azn",
                    Count = m.Count
                }).ToList();
           for(var i = 0; i < dtgAddMedicine.RowCount; i++)
            {
                DateTime valDate =(DateTime)dtgAddMedicine.Rows[i].Cells[4].Value;
                if (valDate < DateTime.Now)
                {
                    dtgAddMedicine.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgAddMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void FillFirms()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(a => a.Name).ToArray());
        }
        private void FillTags()
        {
            cmbTag.Items.AddRange(db.Tags.Select(a => a.Name).ToArray());
        }
        private void AddTag()
        {
            string tag = cmbTag.Text;
            if (tag != string.Empty)
            {
                if (checkButtons(tag))
                {
                    Button btn = new Button();
                    btn.Text = tag;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.LightBlue;
                    if (locX + btn.Width >= grpTags.Width)
                    {
                        locX = marginX;
                        LocY += marginY + btn.Height;
                    }
                    btn.Location = new Point(locX, LocY);
                    locX += btn.Width + marginX;
                    btn.Click += new System.EventHandler(TagButtonsClick);
                    btn.Parent = grpTags;
                }
            }
        }
        private void TagButtonsClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            grpTags.Controls.Remove(btn);
        }
        private int CheckFirm(string firmname)
        {
            Firm frm = db.Firms.FirstOrDefault(fr => fr.Name==firmname);
            if (frm != null)
            {
                return frm.Id;
            }
            Firm addedFirm = db.Firms.Add(new Firm { Name = firmname });
            db.SaveChanges();
            return addedFirm.Id;
        }
        private bool checkButtons(string tag)
        {
            foreach (Button btn in grpTags.Controls)
            {
                if(btn.Text == tag)
                {
                    return false;
                }
            }
            return true;
            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtMed.Text;
            string QrCode = numQrCode.Value.ToString();
            string Desc = richDescription.Text;
            bool WithReceipt = chkReceipt.Checked;
            decimal price = numPrice.Value;
            int Count = (int)numCount.Value;
            DateTime productionDate = dtProduct.Value;
            DateTime validDate = dtUntill.Value;
            string firms = cmbFirms.Text;
            if(Extentions.isnotEmpty(new string[] {
             Name,QrCode,firms},string.Empty))
            {
               
                if (QrCode.Length >= 5)
                {
                    if(price>0 && Count > 0)
                    {
                        int firmId = CheckFirm(firms);
                        Medicine md = new Medicine
                        {
                            Name = Name,
                            Qr_Code = QrCode,
                            Description = Desc,
                            WithRecept = Convert.ToByte(WithReceipt),
                            Price = price,
                            Count = Count,
                            Pro_date = productionDate,
                            Valid_date = validDate,
                            Firm_id = firmId

                        };
                        db.Medicines.Add(md);
                        db.SaveChanges();
                         AddAllTags(md.Id);
                        MessageBox.Show("Was successfully edit" + md.Name + "to derman list", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearALLControl();
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Qr Code must be 13 charachter";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please field all input";
            }

        }

        private void CmbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTag();
        }

        private void CmbTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddTag();
            }
        }

        private void ClearALLControl() {
            foreach(Control ct in this.Controls)
            {
                if(ct is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)ct;
                    nm.Value = 0;
                }
                else if(ct is DateTimePicker){
                    DateTimePicker dt = (DateTimePicker)ct;
                    dt.Value = DateTime.Now;
                    
                }else if(ct is CheckBox)
                {
                    CheckBox ck = (CheckBox)ct;
                    ck.Checked = false;
                }else if (ct is GroupBox)
                {
                    GroupBox grp = (GroupBox)ct;
                    foreach(Button btn in grp.Controls)
                    {
                        grp.Controls.Remove(btn);
                    }
                   
                }
                else if (ct is ComboBox || ct is TextBox || ct is RichTextBox)
                {
                    
                    ct.Text = " ";

                }
            }
        }
        private void AddAllTags(int MedicineId)
        {
            foreach(Button tagBtn in grpTags.Controls)
            {
                int tagId=0;
                Tag addedTag = null;
                Tag tag = db.Tags.FirstOrDefault(tg => tg.Name == tagBtn.Text);
                if (tag == null)
                {
                    Task tagTask = Task.Factory.StartNew(() =>
                    {
                        addedTag = db.Tags.Add(new Tag
                        {
                            Name = tagBtn.Text
                        });
                        db.SaveChanges();
                    });
                    tagTask.Wait();
                    if (tagTask.IsCompleted)
                    {
                        tagId = addedTag.Id;
                    }
                  
                }
                else
                {
                    tagId = tag.Id;
                }
                db.TagMeds.Add(new TagMed
                {
                    Tag_id = tagId,
                    Medicine_id = MedicineId
                });
                db.SaveChanges();
            }
            
        }
    }
}
