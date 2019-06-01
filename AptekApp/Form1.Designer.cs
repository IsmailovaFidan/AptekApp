namespace AptekApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMed = new System.Windows.Forms.ComboBox();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(147, 41);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedicineToolStripMenuItem,
            this.addFirmToolStripMenuItem,
            this.addTagToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(82, 41);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.addMedicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addMedicineToolStripMenuItem.Text = "Add Medicine";
            this.addMedicineToolStripMenuItem.Click += new System.EventHandler(this.AddMedicineToolStripMenuItem_Click);
            // 
            // addFirmToolStripMenuItem
            // 
            this.addFirmToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.addFirmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFirmToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addFirmToolStripMenuItem.Name = "addFirmToolStripMenuItem";
            this.addFirmToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addFirmToolStripMenuItem.Text = "Add Firm";
            // 
            // addTagToolStripMenuItem
            // 
            this.addTagToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.addTagToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTagToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            this.addTagToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addTagToolStripMenuItem.Text = "Add Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(7, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "By Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(464, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "By Tag";
            // 
            // cmbMed
            // 
            this.cmbMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMed.FormattingEnabled = true;
            this.cmbMed.Location = new System.Drawing.Point(12, 265);
            this.cmbMed.Name = "cmbMed";
            this.cmbMed.Size = new System.Drawing.Size(180, 37);
            this.cmbMed.TabIndex = 3;
            // 
            // cmbTag
            // 
            this.cmbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(469, 265);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(180, 37);
            this.cmbTag.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1365, 365);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTag);
            this.Controls.Add(this.cmbMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zeferan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFirmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTagToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMed;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

