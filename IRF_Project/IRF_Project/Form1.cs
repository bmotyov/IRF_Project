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
    public partial class Form1 : Form
    {
        LeltarEntities context = new LeltarEntities();

        public Form1()
        {
            InitializeComponent();
            context.Eszkozoks.Load();
            eszkozokBindingSource.DataSource = context.Eszkozoks.Local;
        }
    }
}
