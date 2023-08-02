using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Upravlja
    {
        public virtual UpravljaId Id { get; set; }
        public virtual DateTime? DatumPreuzimanja { get; set; }
        public virtual DateTime? DatumPredaje { get; set; }

        //public virtual Vozilo UpravljaVozilom { get; set; }
        // public virtual Vozac UpravljaVozac { get; set; }
        public Upravlja()
        {
            Id = new UpravljaId();
        }
    }
}