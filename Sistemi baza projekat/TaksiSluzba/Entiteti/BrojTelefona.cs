using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class BrojTelefona
    {
        public virtual long Broj { get; set; }

        public virtual Musterija Musterija { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            BrojTelefona that = (BrojTelefona)obj;

            return this.Broj == that.Broj &&
                this.Musterija.IdMusterije == that.Musterija.IdMusterije;
        }

        public override int GetHashCode()
        {
            return this.Musterija.GetHashCode() ^ this.Broj.GetHashCode();
        }

        public BrojTelefona()
        {
            Musterija m = new Musterija();
        }
    }
}
