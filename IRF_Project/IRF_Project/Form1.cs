using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class From1 : Form
    {
        
        public From1()
        {
            InitializeComponent();
            MinimizeBox = true;
            MaximizeBox = false;
        }

        private void leltárElemekHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            panel1.Controls.Clear();
            f2.Show();

        }

        private void főoldalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            fooldal_uc uc = new fooldal_uc();
            this.Text = "Főoldal";
            panel1.Controls.Add(uc);
        }

        private void keresőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            kereso_uc uc = new kereso_uc();
            this.Text = "Kereső felület";
            panel1.Controls.Add(uc);
        }
    }
}
