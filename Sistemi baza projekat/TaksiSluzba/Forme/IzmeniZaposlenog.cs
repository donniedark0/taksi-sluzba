using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiSluzba.Entiteti;

namespace TaksiSluzba.Forme
{
    public partial class IzmeniZaposlenog : Form
    {
        private long _JMBG;
        

        public IzmeniZaposlenog()
        {
            InitializeComponent();
            
        }

        public IzmeniZaposlenog(ZaposleniPregled zaposleni)
        {
            InitializeComponent();
            Ime_txtBox.Text = zaposleni.LicnoIme;
            Prezime_txtBox.Text = zaposleni.Prezime;
            SSlovo_txtBox.Text = zaposleni.SrednjeSlovo;
            Adresa_txtBox.Text = zaposleni.Adresa;
            BrTelefona_txtBox.Text = zaposleni.BrojTelefona.ToString();
          
            _JMBG = zaposleni.JMBG;
            AOsobljePregled AOsoblje = new AOsobljePregled(zaposleni, SSprema_txtBox.Text);
        }

        private void IzmeniZaposlenog_Load(object sender, EventArgs e)
        {

        }

        private void Izmeni_btn_Click(object sender, EventArgs e)
        {
            ZaposleniPregled zap = new ZaposleniPregled();
            zap.LicnoIme = Ime_txtBox.Text;
            zap.Prezime = Prezime_txtBox.Text;
            zap.SrednjeSlovo = SSlovo_txtBox.Text;
            zap.Adresa = Adresa_txtBox.Text;
            zap.BrojTelefona = long.Parse(BrTelefona_txtBox.Text);
            zap.JMBG = long.Parse(JMBG_txtBox.Text);

            if (AO_chckBox.Checked && !Vozac_chckBox.Checked)
            {
                AOsobljePregled aop = new AOsobljePregled();
                aop.Zaposleni = zap;
                aop.StrucnaSprema = SSprema_txtBox.Text;

                if (DTOManager.IzmeniAOsoblje(aop))
                {
                    MessageBox.Show("Uspešno ste izmenili administrativno osoblje!");
                    Ime_txtBox.Text = String.Empty;
                    Prezime_txtBox.Text = String.Empty;
                    SSlovo_txtBox.Text = String.Empty;
                    Adresa_txtBox.Text = String.Empty;
                    BrTelefona_txtBox.Text = String.Empty;
                    JMBG_txtBox.Text = String.Empty;
                    SSprema_txtBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }
            }
            else if (!AO_chckBox.Checked && Vozac_chckBox.Checked)
            {
                VozacPregled vp = new VozacPregled();
                vp.Zaposleni = zap;
                vp.BrojVozacke = long.Parse(brojVozacke_txtBox.Text);
                vp.Kategorija = Kategorija_txtBox.Text;

                if (DTOManager.IzmeniVozaca(vp))
                {
                    MessageBox.Show("Uspešno ste izmenili vozaca!");
                    Ime_txtBox.Text = String.Empty;
                    Prezime_txtBox.Text = String.Empty;
                    SSlovo_txtBox.Text = String.Empty;
                    Adresa_txtBox.Text = String.Empty;
                    BrTelefona_txtBox.Text = String.Empty;
                    JMBG_txtBox.Text = String.Empty;
                    Kategorija_txtBox.Text = String.Empty;
                    brojVozacke_txtBox.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }
            }
        }

       private void potvrdi_Click(object sender, EventArgs e)
        {
            /*try
            {
                _JMBG = long.Parse(JMBG_txtBox.Text);
                ZaposleniPregled zapInfo = DTOManager.UcitajInfoZaposlenog(_JMBG);

                Ime_txtBox.Text = zapInfo.LicnoIme;
                Prezime_txtBox.Text = zapInfo.Prezime;
                SSlovo_txtBox.Text = zapInfo.SrednjeSlovo;
                Adresa_txtBox.Text = zapInfo.Adresa;
                BrTelefona_txtBox.Text = zapInfo.BrojTelefona.ToString();

                if (AO_chckBox.Checked && !Vozac_chckBox.Checked)
                {
                    AOsobljePregled AOPregled = DTOManager.UcitajInfoAOsoblja(zapInfo);
                    //SSprema_txtBox.Enabled = true;
                    SSprema_txtBox.Text = AOPregled.StrucnaSprema;
                }

                if (!AO_chckBox.Checked && Vozac_chckBox.Checked)
                {
                    VozacPregled VPregled = DTOManager.UcitajVozacaInfo(zapInfo);
                    //brojVozacke_txtBox.Enabled = true;
                    brojVozacke_txtBox.Text = VPregled.BrojVozacke.ToString();
                    Kategorija_txtBox.Text = VPregled.Kategorija;

                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void Vozac_chckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AO_chckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JMBG_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
