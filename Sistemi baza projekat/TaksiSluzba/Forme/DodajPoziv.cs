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
    public partial class DodajPoziv : Form
    {
        private List<MusterijaPregled> listaMusterija;
        private List<AOsobljePregled> listaOsoblja;
        private IList<long> listaBrojeva;
        public DodajPoziv()
        {
            InitializeComponent();
            listaMusterija = new List<MusterijaPregled>();
            listaOsoblja = new List<AOsobljePregled>();
            listaBrojeva = new List<long>();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (DTOManager.DodajPoziv(int.Parse(musterija_cmb.SelectedItem.ToString()), long.Parse(aosoblje_cmb.SelectedItem.ToString()), 
                long.Parse(brojevi_cmb.SelectedItem.ToString())))
            {
                MessageBox.Show("Uspešno ste dodali poziv!");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }

        private void DodajPoziv_Load(object sender, EventArgs e)
        {
            listaMusterija = DTOManager.UcitajInfoSvihMusterija();
            musterija_cmb.DataSource = DTOManager.FiltrirajIDMusterija(listaMusterija);

            listaOsoblja = DTOManager.UcitajInfoSvogOsoblja();
            aosoblje_cmb.DataSource = DTOManager.FiltrirajJMBGOsoblja(listaOsoblja);



        }

        private void musterija_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusterijaPregled izabranaMusterija = new MusterijaPregled();
            izabranaMusterija.IDMusterije = int.Parse(musterija_cmb.SelectedItem.ToString());
            listaBrojeva = DTOManager.FiltrirajBrojeveTelefona(izabranaMusterija);
            brojevi_cmb.DataSource = listaBrojeva;
        }
    }
}
