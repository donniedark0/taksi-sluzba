using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Voznja
    {
        public virtual int IdVoznje { get; set; }
        public virtual string PocetnaStanica { get; set; }
        public virtual string KrajnjaStanica { get; set; }
        public virtual DateTime VremePocetkaVoznje { get; set; }
        public virtual DateTime VremeKrajaVoznje { get; set; }
        //public virtual long JMBG_AO { get; protected set; }
        //public virtual long JMBG_V { get; protected set; }
        public virtual AdministrativnoOsoblje PrimioPoziv { get; set; }
        public virtual Vozac Vozio { get; set; }
        public Voznja()
        {
            PrimioPoziv = new AdministrativnoOsoblje();
            Vozio = new Vozac();
        }


    }
}