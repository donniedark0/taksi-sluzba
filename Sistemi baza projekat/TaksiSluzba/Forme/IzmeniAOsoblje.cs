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
    public partial class IzmeniAOsoblje : Form
    {
        public long _JMBG;
        public IzmeniAOsoblje(AOsobljePregled osoblje)
        {
            InitializeComponent();
            Ime_txtBox.Text = osoblje.Zaposleni.LicnoIme;
            Prezime_txtBox.Text = osoblje.Zaposleni.Prezime;
            SSlovo_txtBox.Text = osoblje.Zaposleni.SrednjeSlovo;
            Adresa_txtBox.Text = osoblje.Zaposleni.Adresa;
            BrTelefona_txtBox.Text = osoblje.Zaposleni.BrojTelefona.ToString();
            SSprema_txtBox.Text = osoblje.StrucnaSprema;
            _JMBG = osoblje.Zaposleni.JMBG;
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

            AOsobljePregled ao = new AOsobljePregled();
            ao.StrucnaSprema = SSprema_txtBox.Text;
            ao.Zaposleni = zap;

            if (DTOManager.IzmeniAOsoblje(ao))
            {
                MessageBox.Show("Uspešno ste izmenili administrativno osoblje!");
                Ime_txtBox.Text = String.Empty;
                Prezime_txtBox.Text = String.Empty;
                SSlovo_txtBox.Text = String.Empty;
                Adresa_txtBox.Text = String.Empty;
                BrTelefona_txtBox.Text = String.Empty;
                SSprema_txtBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }
    }
}
