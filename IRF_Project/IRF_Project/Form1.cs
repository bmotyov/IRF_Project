using IRF_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
            FormBorderStyle = FormBorderStyle.FixedDialog;

            kezdolap();
        }
           

        private void főoldalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kezdolap();
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

        private void kezdolap()
        {
            panel1.Controls.Clear();
            PictureBox fooldal = new PictureBox();
            panel1.Controls.Add(fooldal);
            fooldal.Height = 300;
            fooldal.Width = 750;
            fooldal.Top = 20;

            fooldal.Load(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\lib\Kezdolap.PNG")));
        }

    }
}
