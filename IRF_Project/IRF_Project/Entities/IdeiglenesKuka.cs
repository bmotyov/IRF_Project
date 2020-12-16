using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project.Entities
{
    class IdeiglenesKuka
    {
        public int Sorszam { get; set; }
        public string Leltari { get; set; }
        public GyartoEnum Gyarto { get; set; }
        public int Besz_eve { get; set; }
    }
}
