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
    public partial class Vozila : Form
    {
        public Vozila()
        {
            InitializeComponent();
        }

        private void prikazi_btn_Click(object sender, EventArgs e)
        {
            PrikazVozila f = new PrikazVozila();
            f.ShowDialog();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            DodajVozilo f = new DodajVozilo();
            f.ShowDialog();
        }

        private void izmeni_btn_Click(object sender, EventArgs e)
        {
            AzurirajVozilo f = new AzurirajVozilo();
            f.ShowDialog();
        }

        private void izbrisi_btn_Click(object sender, EventArgs e)
        {
            ObrisiVozilo f = new ObrisiVozilo();
            f.ShowDialog();
        }
    }
}
