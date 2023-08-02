using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class UpravljaMapiranja:ClassMap<Upravlja>
    {
        public UpravljaMapiranja()
        {
            Table("UPRAVLJA");

            CompositeId(x => x.Id)
                .KeyReference(x => x.UpravljaVozac, "JMBG_VOZACA")
                .KeyReference(x => x.UpravljaVozilo, "REGISTARSKA_OZNAKA_VOZILO"); 

            Map(x => x.DatumPreuzimanja, "DATUM_PREUZIMANJA");
            Map(x => x.DatumPredaje, "DATUM_PREDAJE");

            //References(x => x.UpravljaVozilom).Column("REGISTARSKA_OZNAKA_VOZILO");
            //References(x => x.UpravljaVozac).Column("JMBG_VOZACA");
        }
    }
}
