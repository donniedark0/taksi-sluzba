using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class AdministrativnoOsoblje : Zaposleni
    {
        public virtual string StrucnaSprema { get; set; }
        public virtual IList<Voznja> PrimioPozivZaVoznju { get; set; }
        public virtual IList<Musterija> PrimioPoziv { get; set; }
       // public virtual IList<Zove> MusterijaZove { get; set; }
        public AdministrativnoOsoblje()
        {
            PrimioPoziv = new List<Musterija>();
            PrimioPozivZaVoznju = new List<Voznja>();
            //    MusterijaZove = new List<Zove>();
        }
    }
}