using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class Musterija
    {
        public virtual int IdMusterije { get; set; }
        public virtual string Adresa { get; set; }
        public virtual IList<BrojTelefona> Brojevi { get; set; }
        public virtual IList<AdministrativnoOsoblje> Zvao { get; set; }
       // public virtual IList<Zove> ZoveTaksi { get; set; }
        public Musterija()
        {
            Zvao = new List<AdministrativnoOsoblje>();
            Brojevi = new List<BrojTelefona>();
            // ZoveTaksi = new List<Zove>();
        }
    }
}