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
    public partial class DodajUpravljanje : Form
    {
        public DodajUpravljanje()
        {
            InitializeComponent();
        }

        private void DodajUpravljanje_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.DodajUpravljanje(textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
