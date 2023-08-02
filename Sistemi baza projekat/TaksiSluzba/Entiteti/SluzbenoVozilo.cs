using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class SluzbenoVozilo:Vozilo
    {
        public virtual DateTime DatumIstekaRegistracije { get; set; }
        public virtual int GodinaProizvodnje { get; set; }
        public SluzbenoVozilo():base()
        {

        }
    }
}