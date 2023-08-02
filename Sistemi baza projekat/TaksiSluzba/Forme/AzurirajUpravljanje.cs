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
    public partial class AzurirajUpravljanje : Form
    {
        public AzurirajUpravljanje()
        {
            InitializeComponent();
        }

        private void AzurirajUpravljanje_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            string a="";
            string b = "";

            var lu = s.CreateQuery("select c from Upravlja c");

            IList<Upravlja> u = lu.List<Upravlja>();

            foreach (Upravlja upravlja in u)
            {
                if (upravlja.Id.UpravljaVozilo.RegistarskaOznaka == Convert.ToInt32(textBox1.Text)&& upravlja.Id.UpravljaVozac.JMBG == Convert.ToInt64(textBox2.Text))
                {
                    a = upravlja.DatumPreuzimanja.ToString();
                    b = upravlja.DatumPredaje.ToString();
                }

            }
            if (a != "" && b != "")
            {
                button1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                dateTimePicker1.Value = DateTime.Parse(a.Substring(0, 2) + " " + a.Substring(3, 2) + " " + a.Substring(8, 2));
                dateTimePicker2.Value = DateTime.Parse(b.Substring(0, 2) + " " + b.Substring(3, 2) + " " + b.Substring(8, 2));
            }
            else
            {
                MessageBox.Show("Niste uneli ispravne podatke");
            }
            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.AzurirajUpravljanje(textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            button1.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;

           
        }
    }
}
