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
    public partial class UcitajMusterije : Form
    {
        private List<MusterijaPregled> _listaMusterija;
        private IList<long> _listaBrojeva;
        private int _selektovanID;

        public UcitajMusterije()
        {
            InitializeComponent();
            _listaMusterija = new List<MusterijaPregled>();
            _listaBrojeva = new List<long>();

            /*_listaMusterija = DTOManager.UcitajInfoSvihMusterija();

            MusterijaPregled musterija = _listaMusterija.First();
            int indeksM = _listaMusterija.IndexOf(musterija);
            musterija_cmb.DataSource = DTOManager.FiltrirajIDMusterija(_listaMusterija);
            if (indeksM != 0)
            {
                musterija_cmb.SelectedIndex = indeksM;
            }

            brojevi_cmb.DataSource = DTOManager.FiltrirajBrojeveTelefona(musterija);
            Adresa_txtBox.Text = musterija.Adresa;*/
        }

        private void UcitajMusterije_Load(object sender, EventArgs e)
        {
            _listaMusterija = DTOManager.UcitajInfoSvihMusterija();
            musterija_cmb.DataSource = DTOManager.FiltrirajIDMusterija(_listaMusterija);
        }

        private void musterija_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MusterijaPregled izabranaMusterija = new MusterijaPregled();
            izabranaMusterija = DTOManager.UcitajInfoJedneMusterije(int.Parse(musterija_cmb.SelectedItem.ToString()));
            _listaBrojeva = DTOManager.FiltrirajBrojeveTelefona(izabranaMusterija);
            brojevi_cmb.DataSource = _listaBrojeva;
            Adresa_txtBox.Text = izabranaMusterija.Adresa;
            _selektovanID = int.Parse(musterija_cmb.SelectedItem.ToString());
            if (DTOManager.ImaLiPopust(izabranaMusterija))
            {
                popust_checkBox.Checked = true;
            }
            else
            {
                popust_checkBox.Checked = false;
            }
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            DodajMusteriju dodajMusteriju = new DodajMusteriju();
            dodajMusteriju.ShowDialog();
        }

        private void izbrisi_btn_Click(object sender, EventArgs e)
        {
            if (DTOManager.ObrisiMusteriju(_selektovanID))
            {
                MessageBox.Show("Uspešno ste izbrisali musteriju!");

            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }

        private void izmeni_btn_Click(object sender, EventArgs e)
        {

            IzmeniMusteriju izmeniMusteriju = new IzmeniMusteriju(_selektovanID);
            izmeniMusteriju.ShowDialog();
        }
    }
}
