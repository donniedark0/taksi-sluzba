using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class UpravljaId
    {
        public virtual Vozac UpravljaVozac { get; set; }
        public virtual Vozilo UpravljaVozilo { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(UpravljaId))
                return false;

            UpravljaId recievedObject = (UpravljaId)obj;

            if ((UpravljaVozac.JMBG == recievedObject.UpravljaVozac.JMBG) &&
                (UpravljaVozilo.RegistarskaOznaka == recievedObject.UpravljaVozilo.RegistarskaOznaka))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
