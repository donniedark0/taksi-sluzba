using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba
{
    #region ZaposleniPregled
    public class ZaposleniPregled
    {
        public virtual long JMBG { get; set; }
        public virtual String LicnoIme { get; set; }
        public virtual String SrednjeSlovo { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Adresa { get; set; }
        public virtual long BrojTelefona { get; set; }

        public ZaposleniPregled(long jmbg, String ime, String slovo, String prez, String adr, long brTel)
        {
            JMBG = jmbg;
            LicnoIme = ime;
            SrednjeSlovo = slovo;
            Prezime = prez;
            Adresa = adr;
            BrojTelefona = brTel;
        }

        public ZaposleniPregled(long jmbg)
        {
            JMBG = jmbg;
        }

        public ZaposleniPregled()
        {

        }

    }
    public class AOsobljePregled
    {
        public virtual ZaposleniPregled Zaposleni { get; set; }
        public virtual string StrucnaSprema { get; set; }

        public AOsobljePregled(ZaposleniPregled zap, String sSprema)
        {
            Zaposleni = zap;
            StrucnaSprema = sSprema;
        }

        public AOsobljePregled(long jmbg)
        {
            Zaposleni = new ZaposleniPregled(jmbg);
        }

        public AOsobljePregled()
        {
            Zaposleni = new ZaposleniPregled();
        }
    }
    public class VozacPregled
    {
        public virtual ZaposleniPregled Zaposleni { get; set; }
        public virtual string Kategorija { get; set; }
        public virtual long BrojVozacke { get; set; }
        public VozacPregled(ZaposleniPregled zap, String kat, long brvoz)
        {
            Zaposleni = zap;
            Kategorija = kat;
            BrojVozacke = brvoz;
        }
        public VozacPregled()
        {
            Zaposleni = new ZaposleniPregled();

        }
    }
    #endregion

    #region Musterija
    public class MusterijaPregled
    {
        public virtual int IDMusterije { get; set; }
        public virtual String Adresa { get; set; }
        public virtual IList<BrTelPregled> Brojevi { get; set; }

        public MusterijaPregled()
        {
            Brojevi = new List<BrTelPregled>();
        }

        public MusterijaPregled(int id, String adr)
        {
            IDMusterije = id;
            Adresa = adr;
        }
        public MusterijaPregled(int id)
        {
            IDMusterije = id;
        }
    }
    #endregion

    #region Brojevi telefona
    public class BrTelPregled
    {
        public long BrojTel { get; set; }

        public MusterijaPregled Musterija { get; set; }

        public BrTelPregled(MusterijaPregled musterija, long broj)
        {
            BrojTel = broj;
            Musterija = musterija;
        }
        public BrTelPregled()
        {
            Musterija = new MusterijaPregled();
        }
    }
    #endregion

    #region Poziv
    public class PozivPregled
    {
        public MusterijaPregled Musterija { get; set; }
        public AOsobljePregled AOsoblje { get; set; }
        public DateTime VremePoziva { get; set; }
        public long BrojTelefona { get; set; }

        public PozivPregled(MusterijaPregled m, AOsobljePregled ao, long br, DateTime vr)
        {
            Musterija = m;
            AOsoblje = ao;
            BrojTelefona = br;
            VremePoziva = vr;
        }

        public PozivPregled()
        {
        }
    }
    #endregion

    #region Vozilo
    public class VoziloPregled
    {
        public virtual int RegistarskaOznaka { get; set; }
        public VoziloPregled(int x)
        {
            RegistarskaOznaka = x;
        }
    }
    public class TipVozilaPregled
    {
        public virtual string Karoserija { get; set; }
        public virtual string Kapacitet { get; set; }
        public virtual string ModelVozila { get; set; }
        public virtual string Marka { get; set; }
        public virtual string RegistarskaOznakaVozila { get; set; }

        public TipVozilaPregled(string x, string y, string z, string q, string r)
        {
            Karoserija = x;
            Kapacitet = y;
            ModelVozila = z;
            Marka = q;
            RegistarskaOznakaVozila = r;
        }
    }
    public class LicnoVoziloPregled
    {
        public virtual VoziloPregled vozilopregled { get; set; }
        public virtual string Boja { get; set; }

        public LicnoVoziloPregled(VoziloPregled x, string y)
        {
            vozilopregled = x;
            Boja = y;
        }

    }
    #endregion

    #region Voznja
    public class VoznjaPregled
    {
        public int IDVoznje { get; set; }
        public String PocetnaAdresa { get; set; }
        public String KrajnjaAdresa { get; set; }
        public DateTime PocetakVoznje { get; set; }
        public DateTime KrajVoznje { get; set; }
        public AOsobljePregled PrimioPoziv { get; set; }
        public VozacPregled Vozio { get; set; }

        public VoznjaPregled(int id, String pAdr, String kAdr, DateTime pocVoz, DateTime krajVoz, long primioPoziv, long vozio)
        {
            IDVoznje = id;
            PocetnaAdresa = pAdr;
            KrajnjaAdresa = kAdr;
            PocetakVoznje = pocVoz;
            KrajVoznje = krajVoz;
            PrimioPoziv = new AOsobljePregled();
            PrimioPoziv.Zaposleni.JMBG = primioPoziv;
            Vozio = new VozacPregled();
            Vozio.Zaposleni.JMBG = vozio;
        }

    }
    #endregion
}
