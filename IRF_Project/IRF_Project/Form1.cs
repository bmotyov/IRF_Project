using IRF_Project.Entities;
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

        
        private void főoldalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Fooldal_uc uc = new Fooldal_uc();
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

        private void excelExportálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel_uc uc = new Excel_uc();
            panel1.Controls.Clear();
            this.Text = "Excel Export";
            panel1.Controls.Add(uc);
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_uc uc = new Help_uc();
            panel1.Controls.Clear();
            this.Text = "HELP";
            panel1.Controls.Add(uc);
        }

        private void szerkesztőFelületToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torles_uc uc = new Torles_uc();
            panel1.Controls.Clear();
            this.Text = "Emelek Törlése";
            panel1.Controls.Add(uc);
        }
    }
}
