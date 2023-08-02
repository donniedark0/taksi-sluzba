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
    public partial class UcitajPoziv : Form
    {
        public IList<PozivPregled> _listaPoziva;
        public int _brojStrane;
        public int _brojUcitanihRedova;
        public int _ukupanBrojStrana;
        public UcitajPoziv()
        {
            InitializeComponent();
            _listaPoziva = new List<PozivPregled>();
            _brojStrane = 0;
            _brojUcitanihRedova = 5;
            button1.Enabled = false;
        }

        private void izbrisiPoziv_btn_Click(object sender, EventArgs e)
        {
            if(poziv_listView.SelectedItems.Count == 1)
            {
                ObradaBrisanja();
            }

            else if (poziv_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati poziv pre nego što probate da ga obrišete.");

            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedan poziv.");

            }
        }

        private void ObradaBrisanja()
        {
            PozivPregled poziv = PribaviPoziv();
            if (DTOManager.ObrisiPoziv(poziv))
            {
                MessageBox.Show("Uspešno obrisan poziv");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa brisanjem.");
            }

        }

        private PozivPregled PribaviPoziv()
        {
            if (poziv_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo odabrati poziv.");
                return null;
            }
            int indeks = poziv_listView.SelectedItems[0].Index;
            return _listaPoziva.ElementAt(indeks);
        }

        private int UcitajPozive(int brojStrane, int brojUcitanihRedova)
        {
            this.poziv_listView.Items.Clear();
            _listaPoziva = DTOManager.UcitajInformacijePoziva(_brojStrane, _brojUcitanihRedova);

            foreach (PozivPregled pp in _listaPoziva)
            {
                ListViewItem item = new ListViewItem(new string[] { pp.Musterija.IDMusterije.ToString(), pp.AOsoblje.Zaposleni.JMBG.ToString(), pp.VremePoziva.ToString(), pp.BrojTelefona.ToString() });
                poziv_listView.Items.Add(item);
            }
            poziv_listView.Refresh();
            return _listaPoziva.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_brojStrane == 1)
                button1.Enabled = false;
            UcitajPozive(--_brojStrane, _brojUcitanihRedova);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (_brojStrane == _ukupanBrojStrana - 2)
                button2.Enabled = false;
            UcitajPozive(++_brojStrane, _brojUcitanihRedova);
        }

        private void izmeni_btn_Click(object sender, EventArgs e)
        {
            if (poziv_listView.SelectedItems.Count == 1)
            {
                ObradaIzmene();
            }

            else if (poziv_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati poziv pre nego što probate da izmenite podatke.");

            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedan poziv.");

            }
        }

        private void ObradaIzmene()
        {
            PozivPregled poziv = PribaviPoziv();
            IzmeniPoziv izmeniPoziv = new IzmeniPoziv(poziv);
            izmeniPoziv.ShowDialog();
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            DodajPoziv dodajPoziv = new DodajPoziv();
            dodajPoziv.ShowDialog();
        }

        private void poziv_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UcitajPoziv_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPozive(_brojStrane, _brojUcitanihRedova);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
