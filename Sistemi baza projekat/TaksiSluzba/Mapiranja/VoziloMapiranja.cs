using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class VoziloMapiranja:ClassMap<TaksiSluzba.Entiteti.Vozilo>
    {
        VoziloMapiranja()
        {
            Table("VOZILO");

            
               

            Id(x => x.RegistarskaOznaka, "REGISTARSKA_OZNAKA").GeneratedBy.Assigned();

            //HasOne(x => x.LičnoVozilo).Cascade.All();
            //HasOne(x => x.SluzbenoVozilo).Cascade.All();

            HasManyToMany(x => x.Vozaci)
             .Table("UPRAVLJA")
             .ParentKeyColumn("REGISTARSKA_OZNAKA_VOZILO")
             .ChildKeyColumn("JMBG_VOZACA").Cascade.All().Inverse();


            HasMany(x => x.UpravljaVozaci)
                .KeyColumn("REGISTARSKA_OZNAKA_VOZILO").LazyLoad().Cascade.All().Inverse();
        }
    }
}
