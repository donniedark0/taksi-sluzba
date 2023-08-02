using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksiSluzba.Forme
{
    public partial class IzmeniVozaca : Form
    {
        public long _JMBG;
        public IzmeniVozaca(VozacPregled vozac)
        {
            InitializeComponent();
            Ime_txtBox.Text = vozac.Zaposleni.LicnoIme;
            Prezime_txtBox.Text = vozac.Zaposleni.Prezime;
            SSlovo_txtBox.Text = vozac.Zaposleni.SrednjeSlovo;
            Adresa_txtBox.Text = vozac.Zaposleni.Adresa;
            BrTelefona_txtBox.Text = vozac.Zaposleni.BrojTelefona.ToString();
            Kategorija_txtBox.Text = vozac.Kategorija;
            brojVozacke_txtBox.Text = vozac.BrojVozacke.ToString();
            _JMBG = vozac.Zaposleni.JMBG;
        }

        private void Izmeni_btn_Click(object sender, EventArgs e)
        {
            ZaposleniPregled zap = new ZaposleniPregled();
            zap.LicnoIme = Ime_txtBox.Text;
            zap.Prezime = Prezime_txtBox.Text;
            zap.SrednjeSlovo = SSlovo_txtBox.Text;
            zap.Adresa = Adresa_txtBox.Text;
            zap.BrojTelefona = long.Parse(BrTelefona_txtBox.Text);
            zap.JMBG = _JMBG;

            VozacPregled v = new VozacPregled();
            v.Kategorija = Kategorija_txtBox.Text;
           // v.BrojVozacke =long.Parse(brojVozacke_txtBox.Text);
            v.Zaposleni = zap;

            if (DTOManager.IzmeniVozaca(v))
            {
                MessageBox.Show("Uspešno ste izmenili vozaca!");
                Ime_txtBox.Text = String.Empty;
                Prezime_txtBox.Text = String.Empty;
                SSlovo_txtBox.Text = String.Empty;
                Adresa_txtBox.Text = String.Empty;
                BrTelefona_txtBox.Text = String.Empty;
                Kategorija_txtBox.Text = String.Empty;
                brojVozacke_txtBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }
    }
}
