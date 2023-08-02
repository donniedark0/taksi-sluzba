using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    public class SluzbenoVoziloMapiranja : SubclassMap<TaksiSluzba.Entiteti.SluzbenoVozilo>
    {
        public SluzbenoVoziloMapiranja()
        {
            Table("SLUZBENO_VOZILO");

            KeyColumn("REGISTARSKA_OZNAKA");

            Map(x => x.DatumIstekaRegistracije, "DATUM_ISTEKA_REGISTRACIJE");
            Map(x => x.GodinaProizvodnje, "GODINA_PROIZVODNJE");
        }
    }
}