using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class LicnoVozilo:Vozilo
    {
        public virtual string Boja { get; set; }

        public LicnoVozilo():base()
        {

        }
    }
}
