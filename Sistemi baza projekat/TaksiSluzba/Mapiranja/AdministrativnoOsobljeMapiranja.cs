using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class AdministrativnoOsobljeMapiranja : SubclassMap<TaksiSluzba.Entiteti.AdministrativnoOsoblje>
    {
        public AdministrativnoOsobljeMapiranja()
        {
            Table("ADMINISTRATIVNO_OSOBLJE");

            KeyColumn("JMBG");

            Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");

            HasManyToMany(x => x.PrimioPoziv)
             .Table("ZOVE")
             .ParentKeyColumn("JMBG_AO")
             .ChildKeyColumn("ID_MUSTERIJA").Cascade.All();
            //References(x => x.PrimioPozivZaVoznju).Column("JMBG_AO").LazyLoad();

            // HasMany(x => x.MusterijaZove)
            //   .KeyColumn("ID_MUSTERIJA").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.PrimioPozivZaVoznju)
               .KeyColumn("JMBG_AO").LazyLoad().Cascade.All().Inverse();
        }
    }
}