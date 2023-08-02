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
    public partial class PrikaziVoznju : Form
    {
        private IList<VoznjaPregled> _listaVoznji;
        private int _brojStrane;
        private int _brojUcitanihRedova;
        public PrikaziVoznju()
        {
            InitializeComponent();
            _brojStrane = 0;
            _brojUcitanihRedova = 5;
            levo_btn.Enabled = false;
            desno_btn.Enabled = true;
        }
        private void PrikaziVoznju_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajSveVoznje(_brojStrane, _brojUcitanihRedova);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private int UcitajSveVoznje(int brojStrane, int brojRedova)
        {
            //_listazaposlenih = DTOManager.UcitajInfoSvihZaposlenih(_brojStrane, _brojUcitanihRedova);
            this.voznja_listView.Items.Clear();
            _listaVoznji = DTOManager.UcitajSveVoznje(_brojStrane, _brojUcitanihRedova);

            foreach (VoznjaPregled v in _listaVoznji)
            {
                ListViewItem item = new ListViewItem(new string[] { v.IDVoznje.ToString(), v.PocetnaAdresa,
                    v.KrajnjaAdresa, v.PocetakVoznje.ToString(), v.KrajVoznje.ToString(), 
                    v.PrimioPoziv.Zaposleni.JMBG.ToString(), v.Vozio.Zaposleni.JMBG.ToString() });

                voznja_listView.Items.Add(item);
            }

            voznja_listView.Refresh();
            return _listaVoznji.Count;
        }
        private void levo_btn_Click(object sender, EventArgs e)
        {
            if (this._brojStrane > 0)
            {
                UcitajSveVoznje(--_brojStrane, _brojUcitanihRedova);
                desno_btn.Enabled = true;

                if (_brojStrane == 0)
                    levo_btn.Enabled = false;
            }
        }

        private void desno_btn_Click(object sender, EventArgs e)
        {
            levo_btn.Enabled = true;
            int brojUcitanih = UcitajSveVoznje(++_brojStrane, _brojUcitanihRedova);
            if (brojUcitanih < this._brojUcitanihRedova)
            {
                desno_btn.Enabled = false;
            }
        }

        private void izbrisi_btn_Click(object sender, EventArgs e)
        {
            if (voznja_listView.SelectedItems.Count == 1)
            {
                ObradaBrisanja();
            }
            else if (voznja_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati osoblje pre nego što probate da ga obrišete.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedno osoblje.");
            }
        }

        private void ObradaBrisanja()
        {
            VoznjaPregled voznja = PribaviVoznju();
            if (DTOManager.ObrisiVoznju(voznja.IDVoznje))
            {
                MessageBox.Show("Uspešno obrisana voznja");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa brisanjem.");
            }
        }

        private VoznjaPregled PribaviVoznju()
        {
            int indeks = voznja_listView.SelectedItems[0].Index;
            return _listaVoznji.ElementAt(indeks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajVoznju dodajVoznju = new DodajVoznju();
            dodajVoznju.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (voznja_listView.SelectedItems.Count == 1)
            {
                ObradaIzmeneVoznje();
            }
            else if (voznja_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati voznju pre nego što probate da je izmenite.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednu voznju.");
            }
        }

        private void ObradaIzmeneVoznje()
        {
            VoznjaPregled voznja = PribaviVoznju();
            IzmeniVoznju izmeniVoznju = new IzmeniVoznju(voznja);
            izmeniVoznju.ShowDialog();
        }
    }
}
