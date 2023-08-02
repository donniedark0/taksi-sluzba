using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class MusterijaMapiranja : ClassMap<TaksiSluzba.Entiteti.Musterija>
    {
        MusterijaMapiranja()
        {
            Table("MUSTERIJA");

            Id(x => x.IdMusterije, "ID_MUSTERIJE").GeneratedBy.Assigned();

            Map(x => x.Adresa, "ADRESA");

            HasManyToMany(x => x.Zvao)
            .Table("ZOVE")
            .ParentKeyColumn("ID_MUSTERIJA")
            .ChildKeyColumn("JMBG_AO").Cascade.All().Inverse();

            HasMany(x => x.Brojevi)
                .KeyColumn("MUSTERIJA_ID").Cascade.All().Inverse();


        }
    }
}