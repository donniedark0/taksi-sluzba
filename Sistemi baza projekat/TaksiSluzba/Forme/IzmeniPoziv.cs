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
    public partial class IzmeniPoziv : Form
    {
        private List<MusterijaPregled> _listaMusterija;
        private List<AOsobljePregled> _listaOsoblja;
        private PozivPregled _pozivZaMenjanje;
        public IzmeniPoziv(PozivPregled poziv)
        {
            InitializeComponent();
            _pozivZaMenjanje = poziv;
            _listaMusterija = new List<MusterijaPregled>();
            _listaOsoblja = new List<AOsobljePregled>();

            _listaMusterija = DTOManager.UcitajInfoSvihMusterija();
            _listaOsoblja = DTOManager.UcitajInfoSvogOsoblja();

            MusterijaPregled musterija = _listaMusterija.Where(m => m.IDMusterije == poziv.Musterija.IDMusterije).First();
            int indeksM = _listaMusterija.IndexOf(musterija);
            musterija_cmb.DataSource = DTOManager.FiltrirajIDMusterija(_listaMusterija);
            if(indeksM != 0)
            {
                musterija_cmb.SelectedIndex = indeksM;
            }

            brojevi_cmb.DataSource = DTOManager.FiltrirajBrojeveTelefona(musterija);

            AOsobljePregled aosoblje = _listaOsoblja.Where(ao => ao.Zaposleni.JMBG == poziv.AOsoblje.Zaposleni.JMBG).First();
            int indeksAO = _listaOsoblja.IndexOf(aosoblje);
            aosoblje_cmb.DataSource = DTOManager.FiltrirajJMBGOsoblja(_listaOsoblja);
            if (indeksAO != 0)
            {
                aosoblje_cmb.SelectedIndex = indeksAO;
            }
        }
        private void izmeni_btn_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                PozivPregled poziv = new PozivPregled();

                int indeksMusterije = musterija_cmb.SelectedIndex;
                MusterijaPregled mp = _listaMusterija.ElementAt(indeksMusterije);
                poziv.Musterija = mp;

                int indeksOsoblja = aosoblje_cmb.SelectedIndex;
                AOsobljePregled aop = _listaOsoblja.ElementAt(indeksOsoblja);
                poziv.AOsoblje = aop;

                poziv.VremePoziva = dateTimePicker.Value;
                MessageBox.Show(poziv.VremePoziva.ToString());

                poziv.BrojTelefona = long.Parse(brojevi_cmb.SelectedItem.ToString());

                try
                {
                    if (DTOManager.IzmeniPoziv(poziv, _pozivZaMenjanje))
                    {
                        DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o pozivu!");
                        if (dialog == DialogResult.OK)
                            this.Close();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Došlo je do problema sa ažuriranjem podataka. ");
                        if (dialog == DialogResult.OK)
                            this.Close();
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                MessageBox.Show("Proverite unos polja.");
            };
        }
        private bool Validacija()
        {
            return true;
        }
    }
}
