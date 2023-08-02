using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiSluzba.Entiteti;
using NHibernate;
using System.Data.SqlClient;

namespace TaksiSluzba.Forme
{
    public partial class PrikazUpravljanjaVozilom : Form
    {
        public PrikazUpravljanjaVozilom()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.PrikazUpravljanjaVozilomZaVozilo(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.PrikazUpravljanjaVozilomZaVozaca(textBox2.Text);
        }
    }
}
