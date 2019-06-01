namespace AptekApp
{
    partial class AddMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQrCode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkReceipt = new System.Windows.Forms.CheckBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtProduct = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtUntill = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgAddMedicine = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpTags = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine";
            // 
            // txtMed
            // 
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed.Location = new System.Drawing.Point(39, 58);
            this.txtMed.Multiline = true;
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(166, 28);
            this.txtMed.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(35, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qr  Code";
            // 
            // numQrCode
            // 
            this.numQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQrCode.Location = new System.Drawing.Point(40, 521);
            this.numQrCode.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numQrCode.Name = "numQrCode";
            this.numQrCode.Size = new System.Drawing.Size(166, 29);
            this.numQrCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(32, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(37, 277);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(228, 104);
            this.richDescription.TabIndex = 5;
            this.richDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(34, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "With Receipt";
            // 
            // chkReceipt
            // 
            this.chkReceipt.AutoSize = true;
            this.chkReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReceipt.Location = new System.Drawing.Point(174, 411);
            this.chkReceipt.Name = "chkReceipt";
            this.chkReceipt.Size = new System.Drawing.Size(15, 14);
            this.chkReceipt.TabIndex = 7;
            this.chkReceipt.UseVisualStyleBackColor = true;
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(305, 520);
            this.numPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(166, 29);
            this.numPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(300, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(531, 521);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(166, 29);
            this.numCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(526, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Count";
            // 
            // dtProduct
            // 
            this.dtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtProduct.Location = new System.Drawing.Point(767, 521);
            this.dtProduct.Name = "dtProduct";
            this.dtProduct.Size = new System.Drawing.Size(301, 29);
            this.dtProduct.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(762, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Production Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(1135, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valid Untill";
            // 
            // dtUntill
            // 
            this.dtUntill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUntill.Location = new System.Drawing.Point(1140, 521);
            this.dtUntill.Name = "dtUntill";
            this.dtUntill.Size = new System.Drawing.Size(308, 29);
            this.dtUntill.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1405, 570);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 57);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Medicine";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dtgAddMedicine
            // 
            this.dtgAddMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAddMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAddMedicine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgAddMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgAddMedicine.Location = new System.Drawing.Point(0, 608);
            this.dtgAddMedicine.Name = "dtgAddMedicine";
            this.dtgAddMedicine.Size = new System.Drawing.Size(1595, 298);
            this.dtgAddMedicine.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(34, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Firms";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(39, 141);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(173, 32);
            this.cmbFirms.TabIndex = 19;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(898, 338);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 25);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Medicine";
            this.lblError.Visible = false;
            // 
            // cmbTag
            // 
            this.cmbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(305, 141);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(173, 32);
            this.cmbTag.TabIndex = 22;
            this.cmbTag.SelectedIndexChanged += new System.EventHandler(this.CmbTag_SelectedIndexChanged);
            this.cmbTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbTag_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CadetBlue;
            this.label10.Location = new System.Drawing.Point(300, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tags";
            // 
            // grpTags
            // 
            this.grpTags.Location = new System.Drawing.Point(305, 209);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(355, 191);
            this.grpTags.TabIndex = 23;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "groupBox1";
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 906);
            this.Controls.Add(this.grpTags);
            this.Controls.Add(this.cmbTag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgAddMedicine);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtUntill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtProduct);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkReceipt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numQrCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQrCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkReceipt;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtUntill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgAddMedicine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpTags;
    }
}