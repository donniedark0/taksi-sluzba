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
    public partial class IzmeniBroj : Form
    {
        public BrTelPregled _izmenjeniBroj;
        public BrTelPregled _stariBroj;
        public IzmeniBroj()
        {
            InitializeComponent();
        }
        public IzmeniBroj(BrTelPregled brojZaMenjanje)
        {
            InitializeComponent();
            brojZaMenjanje_txtBox.Text = brojZaMenjanje.BrojTel.ToString();
            _izmenjeniBroj = new BrTelPregled();
            _izmenjeniBroj.Musterija.IDMusterije = brojZaMenjanje.Musterija.IDMusterije;
            _stariBroj = brojZaMenjanje;
           
        }

        private void IzmeniBroj_Load(object sender, EventArgs e)
        {

        }

        public void Potvrdi_btn_Click(object sender, EventArgs e)
        {
            _izmenjeniBroj.BrojTel = long.Parse(brojZaMenjanje_txtBox.Text);
            if (DTOManager.IzmeniBrojTelefona(_izmenjeniBroj, _stariBroj))
            {
                MessageBox.Show("Uspesno ste izmenili broj telefona.");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
            DialogResult = DialogResult.OK;

        }

        private void izbrisi_btn_Click(object sender, EventArgs e)
        {
            if (DTOManager.ObrisiBrojTelefona(_stariBroj))
            {
                MessageBox.Show("Uspesno ste izbrisali broj telefona.");
            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
