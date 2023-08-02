using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using TaksiSluzba.Entiteti;
using TaksiSluzba.Forme;
using NHibernate.Criterion;
using NHibernate.Linq;



namespace TaksiSluzba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ucitaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SluzbenoVozilo o = s.Load<SluzbenoVozilo>(7841256);

                MessageBox.Show(o.DatumIstekaRegistracije.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Voznja o = s.Load<Voznja>(356845217);

                MessageBox.Show(o.IdVoznje.ToString());
                MessageBox.Show(o.PrimioPoziv.LicnoIme);
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo p2 = s.Load<Entiteti.Vozilo>(5487512);

                foreach (Entiteti.Vozac r2 in p2.Vozaci)
                {
                    MessageBox.Show(r2.LicnoIme + " " + r2.Prezime);
                }
                
                Vozac r1 = s.Load<Vozac>(1075235485121);

                foreach (Vozilo p1 in r1.Vozila)
                {
                    MessageBox.Show(p1.RegistarskaOznaka.ToString());
                }
                
                

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Voznja o = s.Load<Voznja>(356845217);

                MessageBox.Show(o.IdVoznje.ToString());
                MessageBox.Show(o.Vozio.LicnoIme);
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PrikaziZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                UcitajZaposlene ucitajZaposlene = new UcitajZaposlene();
                ucitajZaposlene.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PrikaziMusteriju_Click(object sender, EventArgs e)
        {
            UcitajMusterije ucitajMusterije = new UcitajMusterije();
            ucitajMusterije.ShowDialog();
        }

        private void PrikaziVoznju_Click(object sender, EventArgs e)
        {
            PrikaziVoznju prikaziVoznju = new PrikaziVoznju();
            prikaziVoznju.ShowDialog();
        }

        private void PrikaziVozilo_Click(object sender, EventArgs e)
        {
            Vozila opNadVozilima = new Vozila();
            opNadVozilima.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje r = s.Load<AdministrativnoOsoblje>(964786507324);
                Entiteti.Musterija p = s.Load<Entiteti.Musterija>(12548788);

                Zove ru = new Zove();
                ru.Id.PrimaPoziv = r;
                ru.Id.Pozvao = p;
                // ru.DatumPredaje = DateTime.Now;
                //ru.DatumPreuzimanja = DateTime.Now;

                s.Save(ru);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija p2 = s.Load<Musterija>(215448786);

                foreach (Entiteti.BrojTelefona r2 in p2.Brojevi)
                {
                    MessageBox.Show(r2.Broj.ToString());
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void DodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposlenog dz = new DodajZaposlenog();
            dz.ShowDialog();
        }

        private void ObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            IzbrisiZaposlenog izbrisi = new IzbrisiZaposlenog();
            izbrisi.ShowDialog();
        }

        private void IzmeniZaposlenog_Click(object sender, EventArgs e)
        {

            IzmeniZaposlenog izmeniZaposlenog = new IzmeniZaposlenog();
            izmeniZaposlenog.ShowDialog();
        }

        private void DodajMusteriju_Click(object sender, EventArgs e)
        {
            DodajMusteriju dodajMusteriju = new DodajMusteriju();
            dodajMusteriju.ShowDialog();
        }

        private void DodajBrojeveTelefona_Click(object sender, EventArgs e)
        {
        }

        private void IzmeniMusteriju_Click(object sender, EventArgs e)
        {
            
        }

        private void DodajPozivMusterije_Click(object sender, EventArgs e)
        {
            DodajPoziv dodajPoziv = new DodajPoziv();
            dodajPoziv.ShowDialog();
        }

        private void PrikaziPozivMusterije_Click(object sender, EventArgs e)
        {
            UcitajPoziv prikaziPoziv = new UcitajPoziv();
            prikaziPoziv.ShowDialog();
        }

        private void ObrisiPozivMusterije_Click(object sender, EventArgs e)
        {
            UcitajPoziv izbrisiPoziv = new UcitajPoziv();
            izbrisiPoziv.ShowDialog();
        }

        private void ObrisiUpravljanjeVozilom_Click(object sender, EventArgs e)
        {
            BrisanjeUpravljanja f = new BrisanjeUpravljanja();
            f.ShowDialog();
        }

        private void IzmeniUpravljanjeVozilom_Click(object sender, EventArgs e)
        {
            AzurirajUpravljanje f = new AzurirajUpravljanje();
            f.ShowDialog();
        }

        private void DodajUpravljanjeVozilom_Click(object sender, EventArgs e)
        {
            DodajUpravljanje f = new DodajUpravljanje();
            f.ShowDialog();
        }

        private void PrikaziVpravljanjeVozilom_Click(object sender, EventArgs e)
        {
            Upravljanja f = new Upravljanja();
            f.ShowDialog();
        }

        private void IzmeniVozilo_Click(object sender, EventArgs e)
        {
            AzurirajVozilo f = new AzurirajVozilo();
            f.ShowDialog();
        }

        private void ObrisiVozilo_Click(object sender, EventArgs e)
        {
            ObrisiVozilo f = new ObrisiVozilo();
            f.ShowDialog();
        }

        private void DodajVozilo_Click(object sender, EventArgs e)
        {
           
        }

        private void Voznja_Enter(object sender, EventArgs e)
        {

        }
    }
    /*private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac r = s.Load<Vozac>(712681681670);
                Entiteti.Vozilo p = s.Load<Entiteti.Vozilo>(7841417);

                Upravlja ru = new Upravlja();
                ru.Id.UpravljaVozac = r;
                ru.Id.UpravljaVozilo = p;
               // ru.DatumPredaje = DateTime.Now;
                //ru.DatumPreuzimanja = DateTime.Now;

                s.Save(ru);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }*/
}
