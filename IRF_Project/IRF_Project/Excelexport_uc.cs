using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class Excel_uc : UserControl
    {
        LeltarEntities context = new LeltarEntities();
        List<Eszkozok> Eszkozok;        

        public Excel_uc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Eszkozok = context.Eszkozoks.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            List<string> elemek = Nemtudomhogyankellszebben(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);

            List<Eszkozok> Valogatott = new List<Eszkozok>();
            foreach (var esz in Eszkozok)
            {
                for (int i = 0; i < elemek.Count; i++)
                {
                    if (esz.Tipus == elemek[i] && numericUpDown1.Value <= esz.Besz_eve && esz.Besz_eve <= numericUpDown2.Value )
                    {
                        Eszkozok uj = new Eszkozok();
                        uj.Sorszam = esz.Sorszam;
                        uj.Leltari_szam = esz.Leltari_szam;
                        uj.Tipus = esz.Tipus;
                        uj.MAC = esz.MAC;
                        uj.Besz_eve = esz.Besz_eve;
                        uj.Gyarto = esz.Gyarto;

                        Valogatott.Add(uj);
                    }
                }
            }

            dataGridView1.DataSource = Valogatott.ToList();
            
        }

        static List<string> Nemtudomhogyankellszebben(bool check_1,bool check_2, bool check_3, bool check_4, bool check_5)
        {
            List<string> lista = new List<string>();
            if (check_1 == true)
            {
                lista.Add("PC");
            }
            if (check_2 == true)
            {
                lista.Add("IP telefon");
            }
            if (check_3 == true)
            {
                lista.Add("Switch");
            }
            if (check_4 == true)
            {
                lista.Add("Router");
            }
            if (check_5 == true)
            {
                lista.Add("Monitor");
            }

            return lista;
        }
    }
}
