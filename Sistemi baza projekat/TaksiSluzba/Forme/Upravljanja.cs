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
    public partial class Upravljanja : Form
    {
        public Upravljanja()
        {
            InitializeComponent();
        }

        private void Upravljanja_Load(object sender, EventArgs e)
        {

        }

        private void prikazi_btn_Click(object sender, EventArgs e)
        {
            PrikazUpravljanjaVozilom f = new PrikazUpravljanjaVozilom();
            f.ShowDialog();
        }

        private void izmeni_btn_Click(object sender, EventArgs e)
        {
            AzurirajUpravljanje f = new AzurirajUpravljanje();
            f.ShowDialog();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            DodajUpravljanje f = new DodajUpravljanje();
            f.ShowDialog();
        }

        private void izbrisi_btn_Click(object sender, EventArgs e)
        {
            BrisanjeUpravljanja f = new BrisanjeUpravljanja();
            f.ShowDialog();
        }
    }
}
