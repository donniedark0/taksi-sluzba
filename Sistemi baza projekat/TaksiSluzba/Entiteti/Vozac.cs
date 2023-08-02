using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Vozac : Zaposleni
    {
        public virtual string Kategorija { get; set; }
        public virtual long BrojVozackeDozvole { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Upravlja> UpravljaVozila { get; set; }

        public virtual IList<Voznja> VoziVoznju { get; set; }
        public Vozac()
        {
            Vozila = new List<Vozilo>();
            UpravljaVozila = new List<Upravlja>();
            VoziVoznju = new List<Voznja>();

        }
    }
}
    
