using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Zove
    {
        public virtual ZoveId Id { get; set; }
        public virtual DateTime VremePoziva { get; set; }
        public virtual long BrojTelefona { get; set; }
        //public virtual Vozilo UpravljaVozilom { get; set; }
        // public virtual Vozac UpravljaVozac { get; set; }
        public Zove()
        {
            Id = new ZoveId();
        }
    }
}
