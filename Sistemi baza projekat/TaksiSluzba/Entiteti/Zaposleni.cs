using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Zaposleni
    {
        public virtual long JMBG { get;  set; }
        public virtual string LicnoIme { get; set; }
        public virtual string SrednjeSlovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual long BrojTelefona { get; set; }

        public Zaposleni()
        {

        }
    }
}