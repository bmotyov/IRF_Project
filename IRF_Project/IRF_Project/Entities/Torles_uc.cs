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
        List<Eszkozok> lista;

        public Torles_uc()
        {
            InitializeComponent();
            Betolt();
        }

        private void Betolt()
        {
            lista = context.Eszkozoks.ToList();
            eszkozokBindingSource.DataSource = lista.ToList();
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
