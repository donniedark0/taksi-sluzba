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
    public partial class IzbrisiZaposlenog : Form
    {
        public IzbrisiZaposlenog()
        {
            InitializeComponent();
        }

        private void Izbrisi_btn_Click(object sender, EventArgs e)
        {
            if (AO_chckBox.Checked && !Vozac_chckBox.Checked)
            {
                if (DTOManager.ObrisiAOsoblje(long.Parse(JMBG_txtBox.Text)))
                {
                    MessageBox.Show("Uspešno ste izbrisali administrativno osoblje!");

                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }

            }
            else if (!AO_chckBox.Checked && Vozac_chckBox.Checked)
            {
                if (DTOManager.ObrisiVozaca(long.Parse(JMBG_txtBox.Text)))
                {
                    MessageBox.Show("Uspešno ste izbrisali administrativno osoblje!");

                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }

            }
        }
    }
}
