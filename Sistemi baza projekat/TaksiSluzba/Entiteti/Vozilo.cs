using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Vozilo
    {
        public virtual int RegistarskaOznaka { get; set; }
        public virtual IList<Vozac> Vozaci { get; set; }
        public virtual IList<Upravlja> UpravljaVozaci { get; set; }
        public Vozilo()
        {
            Vozaci = new List<Vozac>();
            UpravljaVozaci = new List<Upravlja>();
        }
    }
}