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
    public partial class DodajZaposlenog : Form
    {
        public DodajZaposlenog()
        {
            InitializeComponent();
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            if (AO_chckBox.Checked)
            {

                if (DTOManager.DodajAOsoblje(Ime_txtBox.Text, Prezime_txtBox.Text, SSlovo_txtBox.Text,
                    Adresa_txtBox.Text, long.Parse(JMBG_txtBox.Text), long.Parse(BrTelefona_txtBox.Text), SSprema_txtBox.Text))
                {
                    MessageBox.Show("Uspešno ste dodali administrativno osoblje!");
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
                if (DTOManager.DodajVozaca(Ime_txtBox.Text, Prezime_txtBox.Text, SSlovo_txtBox.Text,
                    Adresa_txtBox.Text, long.Parse(JMBG_txtBox.Text), long.Parse(BrTelefona_txtBox.Text), 
                    long.Parse(brojVozacke_txtBox.Text), Kategorija_txtBox.Text))
                {
                    MessageBox.Show("Uspešno ste dodali vozaca!");
                    Ime_txtBox.Text = String.Empty;
                    Prezime_txtBox.Text = String.Empty;
                    SSlovo_txtBox.Text = String.Empty;
                    Adresa_txtBox.Text = String.Empty;
                    BrTelefona_txtBox.Text = String.Empty;
                    JMBG_txtBox.Text = String.Empty;
                    brojVozacke_txtBox.Text = String.Empty;
                    Kategorija_txtBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }
            }

        }

        private void DodajZaposlenog_Load(object sender, EventArgs e)
        {

        }
    }
}
