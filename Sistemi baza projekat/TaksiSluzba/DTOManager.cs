using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiSluzba.Entiteti;
using NHibernate;
using NHibernate.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using TaksiSluzba.Forme;
using System.Windows.Forms;

namespace TaksiSluzba
{
    public class DTOManager
    {
        #region Zaposleni
        public static ZaposleniPregled UcitajInfoZaposlenog(long jmbg)
        {
            ZaposleniPregled zapInfo = new ZaposleniPregled();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from Zaposleni as zap where zap.JMBG = :p0")
                    .SetParameter("p0", jmbg);
                IList<Zaposleni> ao = q.List<Zaposleni>();

                zapInfo = new ZaposleniPregled(jmbg, ao[0].LicnoIme, ao[0].SrednjeSlovo, ao[0].Prezime,
                    ao[0].Adresa, ao[0].BrojTelefona);

                sesija.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return zapInfo;
        }
        public static AOsobljePregled UcitajInfoAOsoblja(ZaposleniPregled z)
        {

            AOsobljePregled aosobljeInfo = new AOsobljePregled();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from AdministrativnoOsoblje as ao where ao.JMBG = :p0")
                    .SetParameter("p0", z.JMBG)
                    .SetMaxResults(1);

                IList<AdministrativnoOsoblje> ao = q.List<AdministrativnoOsoblje>();

                aosobljeInfo = new AOsobljePregled(z, ao[0].StrucnaSprema);
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return aosobljeInfo;
        }
        public static List<AOsobljePregled> UcitajInfoSvogOsoblja(int brStr, int brRed)
        {
            List<AOsobljePregled> listaOsoblja = new List<AOsobljePregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from AdministrativnoOsoblje order by JMBG asc")
                    .SetFirstResult(brStr * brRed)
                    .SetMaxResults(brRed);

                IList<AdministrativnoOsoblje> osoblje = q.List<AdministrativnoOsoblje>();

                foreach (AdministrativnoOsoblje ao in osoblje)
                {
                    ZaposleniPregled zp = new ZaposleniPregled(ao.JMBG, ao.LicnoIme, ao.SrednjeSlovo, ao.Prezime, ao.Adresa, ao.BrojTelefona);
                    listaOsoblja.Add(new AOsobljePregled(zp, ao.StrucnaSprema));
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return listaOsoblja;
        }
        public static List<VozacPregled> UcitajInfoSvihVozaca(int brStr, int brRed)
        {
            List<VozacPregled> listaVozaca = new List<VozacPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Vozac order by JMBG asc")
                    .SetFirstResult(brStr * brRed)
                    .SetMaxResults(brRed);

                IList<Vozac> vozaci = q.List<Vozac>();

                foreach (Vozac v in vozaci)
                {
                    ZaposleniPregled zp = new ZaposleniPregled(v.JMBG, v.LicnoIme, v.SrednjeSlovo,
                        v.Prezime, v.Adresa, v.BrojTelefona);
                    listaVozaca.Add(new VozacPregled(zp, v.Kategorija, v.BrojVozackeDozvole));
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return listaVozaca;
        }
        public static List<AOsobljePregled> UcitajInfoSvogOsoblja()
        {

            List<AOsobljePregled> listaOsoblja = new List<AOsobljePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from AdministrativnoOsoblje order by JMBG asc");
                IList<AdministrativnoOsoblje> osoblje = q.List<AdministrativnoOsoblje>();

                foreach (AdministrativnoOsoblje ao in osoblje)
                {
                    AOsobljePregled a = new AOsobljePregled();
                    //a.Zaposleni.JMBG = ao.JMBG;
                    a.StrucnaSprema = ao.StrucnaSprema;
                    a.Zaposleni = UcitajInfoZaposlenog(ao.JMBG);
                    listaOsoblja.Add(a);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return listaOsoblja;
        }
        public static List<VozacPregled> UcitajInfoSvihVozaca()
        {
            List<VozacPregled> listaVozaca = new List<VozacPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Vozac order by JMBG asc");

                IList<Vozac> vozaci = q.List<Vozac>();

                foreach (Vozac v in vozaci)
                {
                    ZaposleniPregled zp = new ZaposleniPregled(v.JMBG, v.LicnoIme, v.SrednjeSlovo,
                        v.Prezime, v.Adresa, v.BrojTelefona);
                    listaVozaca.Add(new VozacPregled(zp, v.Kategorija, v.BrojVozackeDozvole));
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return listaVozaca;
        }
        public static List<long> FiltrirajJMBGOsoblja(List<AOsobljePregled> aosoblje)
        {
            List<long> JMBGs = new List<long>();
            foreach (AOsobljePregled ao in aosoblje)
            {
                JMBGs.Add(ao.Zaposleni.JMBG);
            }
            return JMBGs;
        }
        public static List<long> FiltrirajJMBGVozaca(List<VozacPregled> vozaci)
        {
            List<long> JMBGs = new List<long>();
            foreach (VozacPregled v in vozaci)
            {
                JMBGs.Add(v.Zaposleni.JMBG);
            }
            return JMBGs;
        }
        public static VozacPregled UcitajVozacaInfo(ZaposleniPregled z)
        {

            VozacPregled vozacInfo = new VozacPregled();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from Vozac as v where v.JMBG = :p0")
                     .SetParameter("p0", z.JMBG)
                     .SetMaxResults(1);

                IList<Vozac> v = q.List<Vozac>();

                vozacInfo = new VozacPregled(z, v[0].Kategorija, v[0].BrojVozackeDozvole);
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return vozacInfo;

        }
        public static bool DodajAOsoblje(String ime, String prezime, String sSlovo, String adresa,
            long jmbg, long brTel, String sSprema)
        {
            AdministrativnoOsoblje ao = new AdministrativnoOsoblje();
            NapraviAOsoblje(ao, ime, sSlovo, prezime, adresa, jmbg, brTel, sSprema);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(ao);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        private static void NapraviAOsoblje(AdministrativnoOsoblje ao, String ime, String sSlovo,
            String prezime, String adresa, long jmbg, long brTel, String sSprema)
        {
            ao.LicnoIme = ime;
            ao.Prezime = prezime;
            ao.SrednjeSlovo = sSlovo;
            ao.Adresa = adresa;
            ao.BrojTelefona = brTel;
            ao.JMBG = jmbg;
            ao.StrucnaSprema = sSprema;
        }
        public static bool DodajVozaca(String ime, String sSlovo, String prezime, String adresa,
            long jmbg, long brTel, long brojVozacke, String kateg)
        {
            Vozac v = new Vozac();
            NapraviVozaca(v, ime, sSlovo, prezime, adresa, jmbg, brTel, brojVozacke, kateg);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        private static void NapraviVozaca(Vozac v, String ime, String sSlovo, String prezime,
            String adresa, long jmbg, long brTel, long brojVozacke, String kateg)
        {
            v.LicnoIme = ime;
            v.Prezime = prezime;
            v.SrednjeSlovo = sSlovo;
            v.Adresa = adresa;
            v.BrojTelefona = brTel;
            v.JMBG = jmbg;
            v.BrojVozackeDozvole = brojVozacke;
            v.Kategorija = kateg;
        }
        public static bool IzmeniAOsoblje(AOsobljePregled osoblje)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                AdministrativnoOsoblje ucitanoOsoblje = sesija.Load<AdministrativnoOsoblje>(osoblje.Zaposleni.JMBG);
                // sesija.Close();


                NapraviAOsoblje(ucitanoOsoblje, osoblje.Zaposleni.LicnoIme, osoblje.Zaposleni.SrednjeSlovo,
                    osoblje.Zaposleni.Prezime, osoblje.Zaposleni.Adresa, osoblje.Zaposleni.JMBG,
                    osoblje.Zaposleni.BrojTelefona, osoblje.StrucnaSprema);

                // sesija = DataLayer.GetSession();
                sesija.Update(ucitanoOsoblje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static bool IzmeniVozaca(VozacPregled vozac)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozac ucitanVozac = sesija.Load<Vozac>(vozac.Zaposleni.JMBG);
                // sesija.Close();


                NapraviVozaca(ucitanVozac, vozac.Zaposleni.LicnoIme, vozac.Zaposleni.SrednjeSlovo,
                    vozac.Zaposleni.Prezime, vozac.Zaposleni.Adresa, vozac.Zaposleni.JMBG,
                    vozac.Zaposleni.BrojTelefona, vozac.BrojVozacke, vozac.Kategorija);

                // sesija = DataLayer.GetSession();
                sesija.Update(ucitanVozac);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static bool ObrisiAOsoblje(long jmbg)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                AdministrativnoOsoblje ao = sesija.Load<AdministrativnoOsoblje>(jmbg);
                sesija.Delete(ao);
                sesija.Flush();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        public static bool ObrisiVozaca(long jmbg)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozac v = sesija.Load<Vozac>(jmbg);
                sesija.Delete(v);
                sesija.Flush();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion

        #region Musterija
        public static List<MusterijaPregled> UcitajInfoSvihMusterija()
        {
            List<MusterijaPregled> listaMusterija = new List<MusterijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Musterija order by IdMusterije asc");
                IList<Musterija> musterije = q.List<Musterija>();

                foreach (Musterija m in musterije)
                {
                    listaMusterija.Add(new MusterijaPregled(m.IdMusterije, m.Adresa));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return listaMusterija;
        }
        public static MusterijaPregled UcitajInfoJedneMusterije(int id)
        {

            MusterijaPregled musterijaInfo = new MusterijaPregled();

            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from Musterija as m where m.IdMusterije = :p0")
                    .SetParameter("p0", id);

                IList<Musterija> musterija = q.List<Musterija>();

                musterijaInfo = new MusterijaPregled(id, musterija[0].Adresa);
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return musterijaInfo;
        }
        public static List<int> FiltrirajIDMusterija(List<MusterijaPregled> musterije)
        {
            List<int> IDs = new List<int>();
            foreach (MusterijaPregled m in musterije)
            {
                IDs.Add(m.IDMusterije);
            }
            return IDs;
        }
        public static bool DodajMusteriju(int id, String adresa)
        {
            Musterija m = new Musterija();
            NapraviMusteriju(m, id, adresa);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(m);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        public static bool IzmeniMusteriju(MusterijaPregled musterija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Musterija ucitanaMusterija = sesija.Load<Musterija>(musterija.IDMusterije);
                NapraviMusteriju(ucitanaMusterija, musterija.IDMusterije, musterija.Adresa);
                sesija.Update(ucitanaMusterija);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        private static void NapraviMusteriju(Musterija m, int id, String adresa)
        {
            m.Adresa = adresa;
            m.IdMusterije = id;
        }
        public static bool ObrisiMusteriju(int idMusterije)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Musterija v = sesija.Load<Musterija>(idMusterije);
                sesija.Delete(v);
                sesija.Flush();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion

        #region Brojevi telefona
        public static IList<long> FiltrirajBrojeveTelefona(MusterijaPregled musterija)
        {
            IList<long> filtriraniBrojevi = new List<long>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from BrojTelefona as bt where bt.Musterija.IdMusterije = :p0")
                    .SetParameter("p0", musterija.IDMusterije);

                IList<BrojTelefona> brojevi = q.List<BrojTelefona>();

                foreach (BrojTelefona b in brojevi)
                {
                    filtriraniBrojevi.Add(b.Broj);
                }
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return filtriraniBrojevi;
        }
        public static IList<BrojTelefona> FiltrirajCELEBrojeveTelefona(MusterijaPregled musterija)
        {
            IList<BrojTelefona> brojevi = new List<BrojTelefona>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from BrojTelefona as bt where bt.Musterija.IdMusterije = :p0")
                    .SetParameter("p0", musterija.IDMusterije);

                brojevi = q.List<BrojTelefona>();
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return brojevi;
        }
        public static bool DodajBrojTelefona(BrTelPregled brTel)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Musterija m = s.Load<Musterija>(brTel.Musterija.IDMusterije);
                BrojTelefona btPodatak = new BrojTelefona();
                btPodatak.Musterija = m;
                btPodatak.Broj = brTel.BrojTel;
                s.SaveOrUpdate(btPodatak);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        public static bool ObrisiBrojTelefona(BrTelPregled broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from BrojTelefona bt where bt.Broj = :p0 and bt.Musterija.IdMusterije = :p1")
                    .SetParameter("p0", broj.BrojTel)
                    .SetParameter("p1", broj.Musterija.IDMusterije);
                IList<BrojTelefona> pom = q.List<BrojTelefona>();
                BrojTelefona brojZaBrisanje = pom[0];
                s.Delete(brojZaBrisanje);
                s.Flush();
                s.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
        public static bool IzmeniBrojTelefona(BrTelPregled noviBroj, BrTelPregled stariBroj)
        {
            try
            {
                ObrisiBrojTelefona(stariBroj);
                //System.Diagnostics.Trace.WriteLine(noviBroj.Musterija.IDMusterije);
                DodajBrojTelefona(noviBroj);
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        #endregion

        #region Poziv
        public static int j = 0;
        public static List<PozivPregled> UcitajInformacijePoziva(int brojStr, int brojUcitanihRedova)
        {
            List<PozivPregled> listaPozivaInfo = new List<PozivPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Zove order by ID_MUSTERIJA asc")
                    .SetFirstResult(brojStr * brojUcitanihRedova)
                    .SetMaxResults(brojUcitanihRedova);
                IList<Zove> pozivi = q.List<Zove>();

                foreach (Zove z in pozivi)
                {
                    Musterija musterija = new Musterija();
                    musterija = s.Load<Musterija>(z.Id.Pozvao.IdMusterije);
                    MusterijaPregled musterijaPregled = new MusterijaPregled(musterija.IdMusterije);


                    AdministrativnoOsoblje aosoblje = new AdministrativnoOsoblje();
                    aosoblje = s.Load<AdministrativnoOsoblje>(z.Id.PrimaPoziv.JMBG);
                    AOsobljePregled aOsobljePregled = new AOsobljePregled(aosoblje.JMBG);

                    listaPozivaInfo.Add(new PozivPregled(musterijaPregled, aOsobljePregled, z.BrojTelefona, z.VremePoziva));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return listaPozivaInfo;
        }
        public static bool DodajPoziv(int IdMusterije, long JMBGOsoblja, long brojtelefona)
        {
            Zove poziv = new Zove();
            poziv.Id.Pozvao.IdMusterije = IdMusterije;
            poziv.Id.PrimaPoziv.JMBG = JMBGOsoblja;
            poziv.BrojTelefona = brojtelefona;
            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(poziv);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        public static bool ObrisiPoziv(PozivPregled p)
        {
            try
            {
                Zove pozivZaBrisanje = new Zove();
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from Zove z where z.Id.Pozvao.IdMusterije = :p0 and z.Id.PrimaPoziv.JMBG = :p1 and z.VremePoziva = :p2")
                    .SetParameter("p0", p.Musterija.IDMusterije)
                    .SetParameter("p1", p.AOsoblje.Zaposleni.JMBG)
                    .SetParameter("p2", p.VremePoziva);
                IList<Zove> poziv = q.List<Zove>();

                pozivZaBrisanje = poziv[0];

                sesija.Delete(pozivZaBrisanje);
                sesija.Flush();
                sesija.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IzmeniPoziv(PozivPregled pozivNovi, PozivPregled pozivZaMenjanje)
        {
            try
            {
                Zove pozivZaIzmenu = new Zove();
                ISession sesija = DataLayer.GetSession();

                IQuery q = sesija.CreateQuery("from Zove z where z.Id.Pozvao.IdMusterije = :p0 and z.Id.PrimaPoziv.JMBG = :p1 and z.VremePoziva = :p2")
                    .SetParameter("p0", pozivZaMenjanje.Musterija.IDMusterije)
                    .SetParameter("p1", pozivZaMenjanje.AOsoblje.Zaposleni.JMBG)
                    .SetParameter("p2", pozivZaMenjanje.VremePoziva);
                IList<Zove> poziv = q.List<Zove>();

                sesija.Delete(poziv[0]);
                sesija.SaveOrUpdate(pozivNovi);
                sesija.Flush();
                sesija.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        public static bool ImaLiPopust(MusterijaPregled musterija)
        {
            ISession s = DataLayer.GetSession();

            IQuery q = s.CreateQuery("from Zove z where z.Id.Pozvao.IdMusterije =:p0")
                .SetParameter("p0", musterija.IDMusterije);
            IList<Zove> pozivi = q.List<Zove>();
            foreach (Zove z in pozivi)
                System.Diagnostics.Trace.WriteLine(z.Id.Pozvao.IdMusterije);

            if (pozivi.Count > 2)
                return true;
            else
                return false;
        }
        #endregion

        #region Vozilo
        public void PrikaziVozilo(string x)
        {
            ISession s = DataLayer.GetSession();

            TipVozila p = s.Load<TipVozila>(x);
            LicnoVozilo lv = s.Load<LicnoVozilo>(Convert.ToInt32(x));

            MessageBox.Show("Model vozila: " + p.ModelVozila);
            MessageBox.Show("Registarska oznaka: " + p.RegistarskaOznakaVozila);
            MessageBox.Show("Boja: " + lv.Boja);
            MessageBox.Show("Marka: " + p.Marka);
            MessageBox.Show("Kapacitet: " + p.Kapacitet);
            MessageBox.Show("Karoserija: " + p.Karoserija);

            s.Close();
        }
        private static void DodajLVoizilo(string x, string y)
        {
            ISession s = DataLayer.GetSession();
            LicnoVozilo lv = new LicnoVozilo();
            lv.RegistarskaOznaka = Convert.ToInt32(y);
            lv.Boja = x;
            s.Save(lv);
            s.Flush();
            s.Close();
        }
        private static void DodajSVozilo(DateTime x, string y, string z)
        {
            ISession s = DataLayer.GetSession();

            SluzbenoVozilo sv = new SluzbenoVozilo();
            sv.RegistarskaOznaka = Convert.ToInt32(z);
            sv.DatumIstekaRegistracije = x;
            sv.GodinaProizvodnje = Convert.ToInt32(y);
            s.Save(sv);
            s.Flush();
            s.Close();
        }
        public void DodajVozilo(string x, string y, string z, string q, string r, int t, string o, string p, DateTime d)
        {
            ISession s = DataLayer.GetSession();

            if (t == 1)
            {
                DodajLVoizilo(o, x);
            }
            if (t == 2)
            {
                DodajSVozilo(d, p, x);
            }
            TipVozila tv = new TipVozila();
            tv.RegistarskaOznakaVozila = x;
            tv.ModelVozila = y;
            tv.Marka = z;
            tv.Karoserija = q;
            tv.Kapacitet = r;
            s.Save(tv);
            s.Flush();
            s.Close();
        }
        public void AzurirajVozilo(string x, string y, string z, DateTime q, string a, string b, string c, string d)
        {
            ISession s = DataLayer.GetSession();

            LicnoVozilo lv = s.Load<LicnoVozilo>(Convert.ToInt32(x));
            try
            {
                lv.Boja = y;
                s.Update(lv);
                s.Flush();
            }
            catch (Exception)
            {

            }
            SluzbenoVozilo sv = s.Load<SluzbenoVozilo>(Convert.ToInt32(x));
            try
            {

                sv.GodinaProizvodnje = Convert.ToInt32(z);
                sv.DatumIstekaRegistracije = q;
                s.Update(sv);
                s.Flush();
            }
            catch (Exception)
            {

            }

            TipVozila tv = s.Load<TipVozila>(x);
            tv.ModelVozila = a;
            tv.Marka = b;
            tv.Karoserija = c;
            tv.Kapacitet = d;
            s.Update(tv);
            s.Flush();


            s.Close();
        }
        public void ObrisiVozilo(string x)
        {
            ISession s = DataLayer.GetSession();

            TipVozila tv = s.Load<TipVozila>(x);
            Vozilo v = s.Load<Vozilo>(Convert.ToInt32(x));

            s.Delete(tv);
            s.Flush();
            s.Delete(v);
            s.Flush();


            s.Close();
        }
        #endregion

        #region Upravljanje
        public void DodajUpravljanje(string x, string y, DateTime a, DateTime b)
        {
            ISession s = DataLayer.GetSession();

            int provera = 0;

            Vozilo vozilo = s.Get<Vozilo>(Convert.ToInt32(x));
            if (vozilo != null)
            {
                provera++;
            }
            else
            {
                MessageBox.Show("Vozilo s ovom registracijom nije u bazi");
            }

            Vozac vozac = s.Get<Vozac>(Convert.ToInt64(y));
            if (vozac != null)
            {
                provera++;
            }
            else
            {
                MessageBox.Show("Vozac s ovim JMBG-om nije u bazi");
            }

            if (provera == 2)
            {
                Upravlja upravlja = new Upravlja();
                upravlja.Id.UpravljaVozilo = vozilo;
                upravlja.Id.UpravljaVozac = vozac;
                upravlja.DatumPreuzimanja = a;
                upravlja.DatumPredaje = b;
                s.Save(upravlja);
                s.Flush();
            }
            s.Close();
        }
        public void PrikazUpravljanjaVozilomZaVozilo(string x)
        {
            ISession s = DataLayer.GetSession();

            var lu = s.CreateQuery("select c from Upravlja c");

            IList<Upravlja> u = lu.List<Upravlja>();

            foreach (Upravlja upravlja in u)
            {
                if (upravlja.Id.UpravljaVozilo.RegistarskaOznaka == Convert.ToInt32(x))
                {
                    MessageBox.Show(upravlja.Id.UpravljaVozac.LicnoIme.ToString());
                    MessageBox.Show(upravlja.DatumPreuzimanja.ToString());
                    MessageBox.Show(upravlja.DatumPredaje.ToString());

                }

            }
            s.Close();
        }
        public void PrikazUpravljanjaVozilomZaVozaca(string x)
        {
            ISession s = DataLayer.GetSession();

            var lu = s.CreateQuery("select c from Upravlja c");

            IList<Upravlja> u = lu.List<Upravlja>();

            foreach (Upravlja upravlja in u)
            {
                if (upravlja.Id.UpravljaVozac.JMBG == Convert.ToInt64(x))
                {
                    MessageBox.Show(upravlja.Id.UpravljaVozilo.RegistarskaOznaka.ToString());
                    MessageBox.Show(upravlja.DatumPreuzimanja.ToString());
                    MessageBox.Show(upravlja.DatumPredaje.ToString());
                }

            }
            s.Close();
        }
        public void AzurirajUpravljanje(string x, string y, DateTime a, DateTime b)
        {
            ISession s = DataLayer.GetSession();

            var lu = s.CreateQuery("select c from Upravlja c");

            IList<Upravlja> u = lu.List<Upravlja>();

            foreach (Upravlja upravlja in u)
            {
                if (upravlja.Id.UpravljaVozilo.RegistarskaOznaka == Convert.ToInt32(x) && upravlja.Id.UpravljaVozac.JMBG == Convert.ToInt64(y))
                {
                    upravlja.DatumPredaje = a;
                    upravlja.DatumPreuzimanja = b;
                    s.Update(upravlja);
                    s.Flush();
                }
            }


            s.Close();
        }
        public void ObrisiUpravljanje(string x, string y)
        {
            ISession s = DataLayer.GetSession();

            var lu = s.CreateQuery("select c from Upravlja c");

            IList<Upravlja> u = lu.List<Upravlja>();

            foreach (Upravlja upravlja in u)
            {
                if (upravlja.Id.UpravljaVozilo.RegistarskaOznaka == Convert.ToInt32(x) && upravlja.Id.UpravljaVozac.JMBG == Convert.ToInt64(y))
                {

                    s.Delete(upravlja);
                    s.Flush();
                }


            }
        }
        #endregion

        #region Voznja
        public static bool DodajVoznju(int id, String pocStanica, String krajStanica, DateTime pocetak
            , DateTime kraj, long osobljeJMBG, long vozacJMBG)
        {
            Voznja voznja = new Voznja();
            NapraviVoznju(voznja, id, pocStanica, krajStanica, pocetak, kraj, osobljeJMBG, vozacJMBG);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(voznja);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }
        public static void NapraviVoznju(Voznja v, int id, String pocStanica, String krajnjaStanica, DateTime pocetak,
            DateTime kraj, long osobljeJMBG, long vozacJMBG)
        {
            v.IdVoznje = id;
            v.PocetnaStanica = pocStanica;
            v.KrajnjaStanica = krajnjaStanica;
            v.VremePocetkaVoznje = pocetak;
            v.VremeKrajaVoznje = kraj;
            v.PrimioPoziv.JMBG = osobljeJMBG;
            v.Vozio.JMBG = vozacJMBG;
        }
        public static void NapraviVoznju(Voznja v, int id, String pocStanica, String krajnjaStanica, DateTime pocetak,
            DateTime kraj, AdministrativnoOsoblje osoblje, Vozac vozac)
        {
            v.IdVoznje = id;
            v.PocetnaStanica = pocStanica;
            v.KrajnjaStanica = krajnjaStanica;
            v.VremePocetkaVoznje = pocetak;
            v.VremeKrajaVoznje = kraj;
            v.PrimioPoziv = osoblje;
            v.Vozio = vozac;
        }
        public static bool ObrisiVoznju(int idVoznje)
        {
            try
            {

                ISession sesija = DataLayer.GetSession();
                Voznja v = sesija.Load<Voznja>(idVoznje);
                sesija.Delete(v);
                sesija.Flush();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        public static List<VoznjaPregled> UcitajSveVoznje(int brStr, int brRed)
        {
            List<VoznjaPregled> listaVoznji = new List<VoznjaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Voznja order by IdVoznje asc")
                    .SetFirstResult(brStr * brRed)
                    .SetMaxResults(brRed);

                IList<Voznja> voznje = q.List<Voznja>();

                foreach (Voznja v in voznje)
                {
                    listaVoznji.Add(new VoznjaPregled(v.IdVoznje, v.PocetnaStanica, v.KrajnjaStanica, v.VremePocetkaVoznje,
                        v.VremeKrajaVoznje, v.PrimioPoziv.JMBG, v.Vozio.JMBG));
                }
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return listaVoznji;
        }
        public static bool IzmeniVoznju(VoznjaPregled voznja)
        {
            AdministrativnoOsoblje osoblje = new AdministrativnoOsoblje();
            NapraviAOsoblje(osoblje, voznja.PrimioPoziv.Zaposleni.LicnoIme, voznja.PrimioPoziv.Zaposleni.SrednjeSlovo,
                voznja.PrimioPoziv.Zaposleni.Prezime, voznja.PrimioPoziv.Zaposleni.Adresa, voznja.PrimioPoziv.Zaposleni.JMBG,
                voznja.PrimioPoziv.Zaposleni.BrojTelefona, voznja.PrimioPoziv.StrucnaSprema);

            Vozac vozac = new Vozac();
            NapraviVozaca(vozac, voznja.Vozio.Zaposleni.LicnoIme, voznja.Vozio.Zaposleni.SrednjeSlovo,
                voznja.Vozio.Zaposleni.Prezime, voznja.Vozio.Zaposleni.Adresa, voznja.Vozio.Zaposleni.JMBG,
                voznja.Vozio.Zaposleni.BrojTelefona, voznja.Vozio.BrojVozacke, voznja.Vozio.Kategorija);
            try
            {
                ISession sesija = DataLayer.GetSession();
                Voznja ucitanaVoznja = sesija.Load<Voznja>(voznja.IDVoznje);
                NapraviVoznju(ucitanaVoznja, voznja.IDVoznje, voznja.PocetnaAdresa, voznja.KrajnjaAdresa,
                voznja.PocetakVoznje, voznja.KrajVoznje, osoblje, vozac);

                sesija.Update(ucitanaVoznja);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        #endregion
    }
}