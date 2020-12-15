using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using IRF_Project.Entities;

namespace IRF_Project
{
    public partial class kereso_uc : UserControl
    {
        LeltarEntities context = new LeltarEntities();

        public kereso_uc()
        {
            InitializeComponent();
            context.Eszkozoks.Load();
            eszkozokBindingSource.DataSource = context.Eszkozoks.Local;
            
            Listbox_feltoltes();
           
        }

        private void Listbox_feltoltes()
        {
            //enumeráció első használata
            List<string> gyarto = new List<string>();
            for (int i = 1; i < 5; i++)
            {
                gyarto.Add(((GyartoEnum)i).ToString());
            }
            listBox_gyarto.DataSource = gyarto.ToList();           
        }

        private void txtbox_szuresek()
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    var elemek = from x in context.Eszkozoks
                                 where x.Leltari_szam.Contains(txtbox_leltar.Text) &&
                                       x.MAC.Contains(txtbox_MAC.Text) &&
                                       x.Besz_eve == (int)numericUpDown1.Value &&
                                       x.Tipus.Contains(txtbox_eszkoz.Text) &&
                                       x.Gyarto == (string)listBox_gyarto.SelectedItem
                                 select x;
                    eszkozokBindingSource.DataSource = elemek.ToList();
                }
                else
                {
                    var elemek = from x in context.Eszkozoks
                                 where x.Leltari_szam.Contains(txtbox_leltar.Text) &&
                                       x.MAC.Contains(txtbox_MAC.Text) &&
                                       x.Tipus.Contains(txtbox_eszkoz.Text) &&
                                       x.Besz_eve == (int)numericUpDown1.Value                                        
                                 select x;
                    eszkozokBindingSource.DataSource = elemek.ToList();
                }                
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    var elemek = from x in context.Eszkozoks
                                 where x.Leltari_szam.Contains(txtbox_leltar.Text) &&
                                       x.MAC.Contains(txtbox_MAC.Text) &&
                                       x.Tipus.Contains(txtbox_eszkoz.Text) &&
                                       x.Gyarto == (string)listBox_gyarto.SelectedItem
                                 select x;
                    eszkozokBindingSource.DataSource = elemek.ToList();
                }
                else
                {
                    var elemek = from x in context.Eszkozoks
                                 where x.Leltari_szam.Contains(txtbox_leltar.Text) &&
                                       x.Tipus.Contains(txtbox_eszkoz.Text) &&
                                       x.MAC.Contains(txtbox_MAC.Text)                                        
                                 select x;
                    eszkozokBindingSource.DataSource = elemek.ToList();
                }               

            }

        }      

        private void txtbox_leltar_TextChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }

        private void txtbox_MAC_TextChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }       

        private void listBox_gyarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }

        private void txtbox_eszkoz_TextChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_szuresek();
        }
    }
}
