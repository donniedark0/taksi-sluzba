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
    public partial class UcitajZaposlene : Form
    {
        private IList<AOsobljePregled> _listaOsoblja;
        private IList<VozacPregled> _listaVozaca;
        private int _brojStrane;
        private int _brojUcitanihRedova;
        public UcitajZaposlene()
        {
            InitializeComponent();
            _brojStrane = 0;
            _brojUcitanihRedova = 5;
            LevoAO_btn.Enabled = false;
            DesnoAO_btn.Enabled = true;
        }

        private void izmeniOsoblje_btn_Click(object sender, EventArgs e)
        {
            if (AOsoblje_listView.SelectedItems.Count == 1)
            {
                ObradaIzmeneOsoblja();
            }
            else if (AOsoblje_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati osoblje pre nego što probate da ga izmenite.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedno osoblje.");
            }
        }

        private void ObradaIzmeneOsoblja()
        {
            AOsobljePregled osoblje = PribaviAOsoblje();

            IzmeniAOsoblje izmeniOsoblje = new IzmeniAOsoblje(osoblje);
            izmeniOsoblje.ShowDialog();
        }

        private void UcitajZaposlene_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajSvoOsoblje(_brojStrane, _brojUcitanihRedova);
                UcitajSveVozace(_brojStrane, _brojUcitanihRedova);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private int UcitajSvoOsoblje(int brojStrane, int brojRedova)
        {
            //_listazaposlenih = DTOManager.UcitajInfoSvihZaposlenih(_brojStrane, _brojUcitanihRedova);
            this.AOsoblje_listView.Items.Clear();
            _listaOsoblja = DTOManager.UcitajInfoSvogOsoblja(_brojStrane, _brojUcitanihRedova);

            foreach(AOsobljePregled ao in _listaOsoblja)
            {
                ListViewItem item = new ListViewItem(new string[] { ao.Zaposleni.LicnoIme,
                    ao.Zaposleni.Prezime, ao.Zaposleni.SrednjeSlovo, ao.Zaposleni.JMBG.ToString(),
                    ao.Zaposleni.Adresa, ao.Zaposleni.BrojTelefona.ToString(), ao.StrucnaSprema });

                AOsoblje_listView.Items.Add(item);
            }

            AOsoblje_listView.Refresh();
            return _listaOsoblja.Count;
        }

        private int UcitajSveVozace(int brojStrane, int brojRedova)
        {
            this.Vozaci_listView.Items.Clear();
            _listaVozaca = DTOManager.UcitajInfoSvihVozaca(_brojStrane, _brojUcitanihRedova);

            foreach (VozacPregled v in _listaVozaca)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Zaposleni.LicnoIme,
                    v.Zaposleni.Prezime, v.Zaposleni.SrednjeSlovo, v.Zaposleni.JMBG.ToString(), 
                    v.Zaposleni.Adresa, v.Zaposleni.BrojTelefona.ToString(), v.Kategorija, v.BrojVozacke.ToString() });

                Vozaci_listView.Items.Add(item);
            }

            Vozaci_listView.Refresh();
            return _listaVozaca.Count;
        }

        private void LevoAO_btn_Click(object sender, EventArgs e)
        {
            if (this._brojStrane > 0)
            {
                UcitajSvoOsoblje(--_brojStrane, _brojUcitanihRedova);
                DesnoAO_btn.Enabled = true;

                if (_brojStrane == 0)
                    LevoAO_btn.Enabled = false;
            }
        }

        private void DesnoAO_btn_Click(object sender, EventArgs e)
        {
            LevoAO_btn.Enabled = true;
            int brojUcitanih = UcitajSvoOsoblje(++_brojStrane, _brojUcitanihRedova);
            if (brojUcitanih < this._brojUcitanihRedova)
            {
                DesnoAO_btn.Enabled = false;
            }
        }

        private void vozacLevo_btn_Click(object sender, EventArgs e)
        {

            if (this._brojStrane > 0)
            {
                UcitajSveVozace(--_brojStrane, _brojUcitanihRedova);
                vozacDesno_btn.Enabled = true;

                if (_brojStrane == 0)
                    vozacLevo_btn.Enabled = false;
            }
        }

        private void vozacDesno_btn_Click(object sender, EventArgs e)
        {
            vozacLevo_btn.Enabled = true;
            int brojUcitanih = UcitajSveVozace(++_brojStrane, _brojUcitanihRedova);
            if (brojUcitanih < this._brojUcitanihRedova)
            {
                vozacDesno_btn.Enabled = false;
            }
        }

        private void izbrisiOsoblje_btn_Click(object sender, EventArgs e)
        {
            if (AOsoblje_listView.SelectedItems.Count == 1)
            {
                ObradaBrisanjaOsoblja();
            }
            else if (AOsoblje_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati osoblje pre nego što probate da ga obrišete.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedno osoblje.");
            }
        }

        private void ObradaBrisanjaOsoblja()
        {
            AOsobljePregled osoblje = PribaviAOsoblje();
            if(DTOManager.ObrisiAOsoblje(osoblje.Zaposleni.JMBG))
            {
                MessageBox.Show("Uspešno obrisano osoblje");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa brisanjem.");
            }
        }

        private AOsobljePregled PribaviAOsoblje()
        {
            int indeks = AOsoblje_listView.SelectedItems[0].Index;
            return _listaOsoblja.ElementAt(indeks);
        }

        private void ObradaBrisanjaVozaca()
        {
            VozacPregled vozac = PribaviVozaca();
            if (DTOManager.ObrisiVozaca(vozac.Zaposleni.JMBG))
            {
                MessageBox.Show("Uspešno obrisano osoblje");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa brisanjem.");
            }
        }

        private VozacPregled PribaviVozaca()
        {
            int indeks = Vozaci_listView.SelectedItems[0].Index;
            return _listaVozaca.ElementAt(indeks);
        }

        private void izbrisiVozaca_btn_Click(object sender, EventArgs e)
        {
            if (Vozaci_listView.SelectedItems.Count == 1)
            {
                ObradaBrisanjaVozaca();
            }
            else if (Vozaci_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati vozaca pre nego što probate da ga obrišete.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednog vozaca.");
            }
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            DodajZaposlenog dodajZaposlenog = new DodajZaposlenog();
            dodajZaposlenog.ShowDialog();
        }

        private void izmeniVozaca_btn_Click(object sender, EventArgs e)
        {
            if (Vozaci_listView.SelectedItems.Count == 1)
            {
                ObradaIzmeneVozaca();
            }
            else if (Vozaci_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati vozaca pre nego što probate da ga izmenite.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednog vozaca.");
            }
        }

        private void ObradaIzmeneVozaca()
        {
            VozacPregled vozac = PribaviVozaca();

            IzmeniVozaca izmeniVozaca = new IzmeniVozaca(vozac);
            izmeniVozaca.ShowDialog();
        }
    }
}
