using NHibernate;
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

namespace TaksiSluzba.Forme
{
    public partial class ObrisiVozilo : Form
    {
        public ObrisiVozilo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.ObrisiVozilo(textBox1.Text);
        }
    }
}
