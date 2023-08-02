using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<TaksiSluzba.Entiteti.Zaposleni>
    {
        ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();

            Map(x => x.LicnoIme, "LICNO_IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.SrednjeSlovo, "SREDNJE_SLOVO");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
        }
    }
}