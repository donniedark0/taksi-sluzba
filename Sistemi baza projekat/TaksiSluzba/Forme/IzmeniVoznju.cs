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
    public partial class IzmeniVoznju : Form
    {
        private List<AOsobljePregled> _listaOsoblja;
        private List<VozacPregled> _listaVozaca;
        public IzmeniVoznju(VoznjaPregled voznja)
        {
            InitializeComponent();
            id_txtBox.Enabled = false;
            _listaOsoblja = DTOManager.UcitajInfoSvogOsoblja();
            AOsobljePregled aosoblje = _listaOsoblja.Where(ao => ao.Zaposleni.JMBG == voznja.PrimioPoziv.Zaposleni.JMBG).First();
            int indeksAO = _listaOsoblja.IndexOf(aosoblje);
            osoblje_cmb.DataSource = DTOManager.FiltrirajJMBGOsoblja(_listaOsoblja);
            if (indeksAO != 0)
            {
                osoblje_cmb.SelectedIndex = indeksAO;
            }


            _listaVozaca =  DTOManager.UcitajInfoSvihVozaca();
            VozacPregled vozac = _listaVozaca.Where(v => v.Zaposleni.JMBG == voznja.Vozio.Zaposleni.JMBG).First();
            int indeksV = _listaVozaca.IndexOf(vozac);
            vozac_cmb.DataSource = DTOManager.FiltrirajJMBGVozaca(_listaVozaca);
            if (indeksAO != 0)
            {
                vozac_cmb.SelectedIndex = indeksAO;
            }

            id_txtBox.Text = voznja.IDVoznje.ToString();
            id_txtBox.Enabled = false;
            pocStan_txtBox.Text = voznja.PocetnaAdresa;
            krajStan_txtBox.Text = voznja.KrajnjaAdresa;
            pocetak_dateTimePicker.Value = voznja.PocetakVoznje;
            kraj_dateTimePicker.Value = voznja.KrajVoznje;
        }

        private void izmeni_btn_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                VoznjaPregled voznja = new VoznjaPregled(int.Parse(id_txtBox.Text), pocStan_txtBox.Text, krajStan_txtBox.Text,
                    pocetak_dateTimePicker.Value, kraj_dateTimePicker.Value, long.Parse(osoblje_cmb.SelectedItem.ToString()),
                    long.Parse(vozac_cmb.SelectedItem.ToString()));

                try
                {
                    if (DTOManager.IzmeniVoznju(voznja))
                    {
                        DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o voznji!");
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
