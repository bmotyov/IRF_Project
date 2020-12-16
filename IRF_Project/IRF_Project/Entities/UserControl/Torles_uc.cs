using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Entities
{
    public partial class Torles_uc : UserControl
    {
        LeltarEntities context = new LeltarEntities();
        List<Eszkozok> Eszkozok;
        List<IdeiglenesKuka> temp = new List<IdeiglenesKuka>();

        public Torles_uc()
        {
            InitializeComponent();
            Betolt();
            LBoxok_feltolt();
        }

        private void LBoxok_feltolt()
        {
            List<string> Gyartok = new List<string>();
            for (int i = 1; i < 5; i++)
            {
                Gyartok.Add(((GyartoEnum)i).ToString());
            }
            listBox1.DataSource = Gyartok.ToList();

            List<string> Tipsuok = new List<string>() { "PC", "IP telefon", "Switch", "Router", "Monitor"};
            listBox2.DataSource = Tipsuok.ToList();            
        }

        private void Betolt()
        {
            Eszkozok = context.Eszkozoks.ToList();
            eszkozokBindingSource.DataSource = Eszkozok.ToList();
            dataGridView1.DataSource = Eszkozok.ToList();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dynamic aktualis = eszkozokBindingSource.Current;
            string t_id = (aktualis.Leltari_szam).ToString();

            var trolendo = (from x in context.Eszkozoks
                            where x.Leltari_szam == t_id
                            select x).FirstOrDefault();

            context.Eszkozoks.Remove(trolendo);
            context.SaveChanges();
            Betolt();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(temp.Count().ToString());
            //Konkrét törlés
            if (temp.Count == 0)
            {
                MessageBox.Show("Nem lehetséges 0 elem törlése. (Nyomj a megjelnít gombra!)");
                return;
            }

            Form_kerdes f2 = new Form_kerdes();
            f2.label1.Text = "Biztosan végleg törölni szeretnél " + temp.Count().ToString() + " elemet a listából?";
            f2.StartPosition = FormStartPosition.CenterParent;

            if (f2.ShowDialog() == DialogResult.OK)
            {
                for (int j = 0; j < temp.Count; j++)
                {
                    int sszam = temp[j].Sorszam;
                    var torlendo = (from x in context.Eszkozoks
                                    where x.Sorszam == sszam
                                    select x).FirstOrDefault();

                    context.Eszkozoks.Remove(torlendo);
                }

                temp.Clear();
                context.SaveChanges();
                Betolt();
                dataGridView1.DataSource = Eszkozok.ToList();
            }
            else
            {
                MessageBox.Show("Nem történt módosítás.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool listabane = false;
            temp.Clear(); // minden gombnyomás előtt törlöm a temp teljes tartalmét

            //törlendők listájának feltöltése
            for (int i = 0; i < Eszkozok.Count; i++)
            {
                listabane = false;
                if (checkBox1.Checked == true)
                {
                    if (Eszkozok[i].Gyarto.Contains(listBox1.SelectedItem.ToString()))
                    {
                        IdeiglenesKuka aktualis = new IdeiglenesKuka();
                        aktualis.Leltari = Eszkozok[i].Leltari_szam;
                        aktualis.Gyarto = (GyartoEnum)Enum.Parse(typeof(GyartoEnum), Eszkozok[i].Gyarto);
                        aktualis.Sorszam = Eszkozok[i].Sorszam;
                        aktualis.Besz_eve = Eszkozok[i].Besz_eve;

                        temp.Add(aktualis);
                        listabane = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (listabane == true && !Eszkozok[i].Tipus.Contains(listBox2.SelectedItem.ToString()))
                    {
                        temp.Remove(temp[temp.Count() - 1]);
                        continue;
                    }
                    else if (listabane == false && Eszkozok[i].Tipus.Contains(listBox2.SelectedItem.ToString()))
                    {
                        IdeiglenesKuka aktualis = new IdeiglenesKuka();
                        aktualis.Leltari = Eszkozok[i].Leltari_szam;
                        aktualis.Gyarto = (GyartoEnum)Enum.Parse(typeof(GyartoEnum), Eszkozok[i].Gyarto);
                        aktualis.Sorszam = Eszkozok[i].Sorszam;
                        aktualis.Besz_eve = Eszkozok[i].Besz_eve;

                        temp.Add(aktualis);
                        listabane = true;
                    }
                    if (listabane == false && !Eszkozok[i].Tipus.Contains(listBox2.SelectedItem.ToString()))
                    {
                        continue;
                    }

                }
                if (checkBox3.Checked)
                {
                    if (listabane == true && numericUpDown1.Value != Eszkozok[i].Besz_eve)
                    {
                        temp.Remove(temp[temp.Count() - 1]);
                    }
                    else if (listabane == false && numericUpDown1.Value == Eszkozok[i].Besz_eve)
                    {
                        IdeiglenesKuka aktualis = new IdeiglenesKuka();
                        aktualis.Leltari = Eszkozok[i].Leltari_szam;
                        aktualis.Gyarto = (GyartoEnum)Enum.Parse(typeof(GyartoEnum), Eszkozok[i].Gyarto);
                        aktualis.Sorszam = Eszkozok[i].Sorszam;
                        aktualis.Besz_eve = Eszkozok[i].Besz_eve;

                        temp.Add(aktualis);
                        listabane = true;
                    }
                }
            }            
            dataGridView1.DataSource = temp.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eszkozok = context.Eszkozoks.ToList();
            dataGridView1.DataSource = Eszkozok.ToList();           
        }
    }
}
