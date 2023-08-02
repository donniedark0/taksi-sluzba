using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiSluzba.Entiteti;
using FluentNHibernate.Mapping;

namespace TaksiSluzba.Mapiranja
{
    public class ZoveMapiranja:ClassMap<Zove>
    {
        public ZoveMapiranja()
        {
            Table("ZOVE");

            CompositeId(x => x.Id)
                .KeyReference(x => x.PrimaPoziv, "JMBG_AO")
                .KeyReference(x => x.Pozvao, "ID_MUSTERIJA");

            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.VremePoziva, "VREME_POZIVA");
        }
    }
}
