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

namespace TaksiSluzba.Forme
{
    public partial class DodajVozilo : Form
    {
        public DodajVozilo()
        {
            InitializeComponent();
        }

        private void DodajVozilo_Load(object sender, EventArgs e)
        {
            boja.Visible = false;
            godinaproizvodnje.Visible = false;
            datumistekareg.Visible = false;
            BojaTB.Visible = false;
            GodinaProizvodnjeTB.Visible = false;
            dateTimePicker1.Visible = false;
            button2.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                boja.Visible = true;
                godinaproizvodnje.Visible = false;
                datumistekareg.Visible = false;
                BojaTB.Visible = true;
                GodinaProizvodnjeTB.Visible = false;
                dateTimePicker1.Visible = false;

            }
            if (radioButton2.Checked == true)
            {
                boja.Visible = false;
                godinaproizvodnje.Visible = true;
                datumistekareg.Visible = true;
                BojaTB.Visible = false;
                GodinaProizvodnjeTB.Visible = true;
                dateTimePicker1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DTOManager dm = new DTOManager();
            int x = 0;

            if(radioButton1.Checked==true)
            {
                x = 1;
            }
            if(radioButton2.Checked==true)
            {
                x = 0;
            }
            dm.DodajVozilo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, x, BojaTB.Text, GodinaProizvodnjeTB.Text, dateTimePicker1.Value);
            
        }

        private void BojaTB_TextChanged(object sender, EventArgs e)
        {
            if (BojaTB.Text != null)
            {
                button2.Enabled = true;
            }
            else
                button2.Enabled = false;
        }

        private void GodinaProizvodnjeTB_TextChanged(object sender, EventArgs e)
        {
            if (GodinaProizvodnjeTB.Text != null)
            {
                button2.Enabled = true;
            }
            else
                button2.Enabled = false;
        }
    }
}
