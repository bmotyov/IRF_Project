using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IRF_Project.Entities
{
    public partial class Help_uc : UserControl
    {
        public Help_uc()
        {
            InitializeComponent();
        }

        private void keresőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\lib\Help_kereso.PNG")));
        }

        private void szerkesztőiFelületToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\lib\Help_szerkesztoi.PNG")));
        }

        private void excelExportálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\lib\Help_excel.PNG")));
        }
    }
}
