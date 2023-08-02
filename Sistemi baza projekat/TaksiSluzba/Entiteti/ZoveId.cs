using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class ZoveId
    {
        public virtual AdministrativnoOsoblje PrimaPoziv { get; set; }
        public virtual Musterija Pozvao { get; set; }

        public ZoveId()
        {
            Pozvao = new Musterija();
            PrimaPoziv = new AdministrativnoOsoblje();
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ZoveId))
                return false;

            ZoveId recievedObject = (ZoveId)obj;

            if ((PrimaPoziv.JMBG == recievedObject.PrimaPoziv.JMBG) &&
                (Pozvao.IdMusterije == recievedObject.Pozvao.IdMusterije))
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
