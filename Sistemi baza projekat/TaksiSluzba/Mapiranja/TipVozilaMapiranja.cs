using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;
namespace TaksiSluzba.Mapiranja
{
    class TipVozilaMapiranje : ClassMap<TaksiSluzba.Entiteti.TipVozila>
    {
        public TipVozilaMapiranje()
        {
            Table("TIP_VOZILA");


            Id(x => x.RegistarskaOznakaVozila, "REGISTARSKA_OZNAKA_VOZILA").GeneratedBy.Assigned();
            
            Map(x => x.ModelVozila, "MODEL_VOZILA");
            Map(x => x.Kapacitet, "KAPACITET");
            Map(x => x.Karoserija, "KAROSERIJA");
            Map(x => x.Marka, "MARKA");

        }
    }
}