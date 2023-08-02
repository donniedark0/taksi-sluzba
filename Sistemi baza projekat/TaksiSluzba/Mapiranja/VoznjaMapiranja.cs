using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class VoznjaMapiranja : ClassMap<TaksiSluzba.Entiteti.Voznja>
    {
        VoznjaMapiranja()
        {
            Table("VOZNJA");

            Id(x => x.IdVoznje, "ID_VOZNJE").GeneratedBy.Assigned();


           // Map(x => x.JMBG_AO, "JMBG_AO");
           // Map(x => x.JMBG_V, "JMBG_V");
            Map(x => x.KrajnjaStanica, "KRAJNJA_STANICA");
            Map(x => x.PocetnaStanica, "POCETNA_STANICA");
            Map(x => x.VremeKrajaVoznje, "VREME_KRAJA_VOZNJE");
            Map(x => x.VremePocetkaVoznje, "VREME_POCETKA_VOZNJE");

            References(x => x.PrimioPoziv).Column("JMBG_AO").LazyLoad();
            References(x => x.Vozio).Column("JMBG_V").LazyLoad();
        }
    }
}