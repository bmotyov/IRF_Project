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

            listBox2.DisplayMember = "Tipus";
            var tipusok = from x in context.Eszkozoks
                          group x by x.Tipus into g
                          select new
                          {
                              Tipus = g.Key
                          };
            listBox2.DataSource = tipusok.ToList();
            
        }

        private void Betolt()
        {
            Eszkozok = context.Eszkozoks.ToList();
            eszkozokBindingSource.DataSource = Eszkozok.ToList();

            Eszkozok = context.Eszkozoks.ToList();
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
    }
}
