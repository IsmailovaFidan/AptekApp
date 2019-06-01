using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptekApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine adm = new AddMedicine();
            adm.ShowDialog();
        }
        
    }
}
