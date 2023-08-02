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
    public partial class BrisanjeUpravljanja : Form
    {
        public BrisanjeUpravljanja()
        {
            InitializeComponent();
        }

        private void BrisanjeUpravljanja_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.ObrisiUpravljanje(textBox1.Text, textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!=null && textBox1.Text!=null)
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox1.Text != null)
            {
                button1.Enabled = true;
            }
        }
    }
}
