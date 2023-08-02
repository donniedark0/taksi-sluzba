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
    public partial class DodajBrojTelefona : Form
    {
        private int _idM;
        public DodajBrojTelefona(int idMusterije)
        {
            InitializeComponent();
            _idM = idMusterije;
        }

        private void dodajBr_btn_Click(object sender, EventArgs e)
        {
            if (true) {

                
                MusterijaPregled musterija = new MusterijaPregled(_idM);
                long brojTel = long.Parse(brTel_textBox.Text);

                BrTelPregled brojTelefona = new BrTelPregled(musterija, brojTel);

                if (DTOManager.DodajBrojTelefona(brojTelefona))
                {
                    MessageBox.Show("Uspešno ste dodali broj telefona!");
                    brTel_textBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom dodavanja!");
                }
            }
            else
            {
                MessageBox.Show("Proverite unos polja.");
            }
        }

        private void DodajBrojTelefona_Load(object sender, EventArgs e)
        {
            idMusterije_txtBox.Text = _idM.ToString();
            idMusterije_txtBox.Enabled = false;
        }

        private void musterije_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
