using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class LicnoVoziloMapiranja : SubclassMap<TaksiSluzba.Entiteti.LicnoVozilo>
    {
        public LicnoVoziloMapiranja()
        {
            Table("LICNO_VOZILO");

            KeyColumn("REGISTARSKA_OZNAKA");

            Map(x => x.Boja, "BOJA");
        }
    }
}
