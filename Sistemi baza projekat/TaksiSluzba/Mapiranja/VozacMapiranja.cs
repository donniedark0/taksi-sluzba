using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class VozacMapiranja : SubclassMap<TaksiSluzba.Entiteti.Vozac>
    {
        VozacMapiranja()
        {
            Table("VOZAC");

            KeyColumn("JMBG");

           //Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.Kategorija, "KATEGORIJA");

            HasManyToMany(x => x.Vozila)
                .Table("UPRAVLJA")
                .ParentKeyColumn("JMBG_VOZACA")
                .ChildKeyColumn("REGISTARSKA_OZNAKA_VOZILO").Cascade.All();

            HasMany(x => x.UpravljaVozila)
                .KeyColumn("JMBG_VOZACA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.VoziVoznju)
                .KeyColumn("JMBG_V").LazyLoad().Cascade.All().Inverse();
        }
    }
}