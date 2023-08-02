using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiSluzba.Entiteti;
using FluentNHibernate.Mapping;

namespace TaksiSluzba.Mapiranja
{
    class BrojeviTelefonaMapiranja : ClassMap<BrojTelefona>
    {
        public BrojeviTelefonaMapiranja()
        {
            Table("BROJEVI_TELEFONA");

            Id(x => x.Broj);
            CompositeId()
                 .KeyProperty(x => x.Broj, "BROJEVI_TELEFONA")
                 .KeyReference(x => x.Musterija, "MUSTERIJA_ID");

            //References(x => x.KlijentKomentara).Column("IDklijenta").ForeignKey("IDklijenta");          
        }
    }
}
