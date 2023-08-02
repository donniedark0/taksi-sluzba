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
    public partial class DodajMusteriju : Form
    {
        public DodajMusteriju()
        {
            InitializeComponent();
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            if (DTOManager.DodajMusteriju(int.Parse(idMusterije_txtBox.Text), Adresa_txtBox.Text))
            {
                MessageBox.Show("Uspešno ste dodali musteriju!");
                idMusterije_txtBox.Text = String.Empty;
                Adresa_txtBox.Text = String.Empty;
                
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }

        private void DodajMusteriju_Load(object sender, EventArgs e)
        {

        }

        private void dodajtel_btn_Click(object sender, EventArgs e)
        {
            DodajBrojTelefona dodajBrTel = new DodajBrojTelefona(int.Parse(idMusterije_txtBox.Text));
            dodajBrTel.ShowDialog();
        }
    }
}
