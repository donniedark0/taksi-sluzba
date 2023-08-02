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
    public partial class DodajVoznju : Form
    {
        List<AOsobljePregled> _listaOsoblja;
        List<VozacPregled> _listaVozaca;
        public DodajVoznju()
        {
            InitializeComponent();
            _listaOsoblja = new List<AOsobljePregled>();
            _listaVozaca = new List<VozacPregled>();
        }

        private void DodajVoznju_Load(object sender, EventArgs e)
        {
            _listaVozaca = DTOManager.UcitajInfoSvihVozaca();
            vozac_cmb.DataSource = DTOManager.FiltrirajJMBGVozaca(_listaVozaca);

            _listaOsoblja = DTOManager.UcitajInfoSvogOsoblja();
            osoblje_cmb.DataSource = DTOManager.FiltrirajJMBGOsoblja(_listaOsoblja);
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (DTOManager.DodajVoznju(int.Parse(id_txtBox.Text), pocStan_txtBox.Text, krajStan_txtBox.Text,
                pocetak_dateTimePicker.Value, kraj_dateTimePicker.Value, long.Parse(osoblje_cmb.SelectedItem.ToString()),
                long.Parse(vozac_cmb.SelectedItem.ToString())))
            {
                MessageBox.Show("Uspešno ste dodali administrativno osoblje!");
                id_txtBox.Text = String.Empty;
                pocStan_txtBox.Text = String.Empty;
                krajStan_txtBox.Text = String.Empty;
                pocetak_dateTimePicker.Value = DateTime.Now;
                kraj_dateTimePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }

        private void osoblje_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kraj_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pocetak_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void krajStan_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pocStan_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vozac_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
