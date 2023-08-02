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
    public partial class AzurirajVozilo : Form
    {
        public AzurirajVozilo()
        {
            InitializeComponent();
        }

        private void AzurirajVozilo_Load(object sender, EventArgs e)
        {
            BojaTB.Visible = false;
            boja.Visible = false;
            godinaproizvodnje.Visible = false;
            GodinaProizvodnjeTB.Visible = false;
            dateTimePicker1.Visible = false;
            datumistekareg.Visible = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button2.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null)
            {
                ISession s = DataLayer.GetSession();
                LicnoVozilo lv = s.Load<LicnoVozilo>(Convert.ToInt32(textBox1.Text));
                try
                {
                    BojaTB.Text = lv.Boja;
                    if(BojaTB.Text!=null)
                    {
                        boja.Visible = true;
                        BojaTB.Visible = true;
                    }
                }
                catch(Exception ex)
                {

                }
                SluzbenoVozilo sv = s.Load<SluzbenoVozilo>(Convert.ToInt32(textBox1.Text));
                try
                {
                    string a = sv.DatumIstekaRegistracije.ToString();
                    dateTimePicker1.Value = DateTime.Parse(a.Substring(0, 2) + " " + a.Substring(3, 2) + " " + a.Substring(8, 2));
                    GodinaProizvodnjeTB.Text = sv.GodinaProizvodnje.ToString();
                    
                        godinaproizvodnje.Visible = true;
                        GodinaProizvodnjeTB.Visible = true;
                        dateTimePicker1.Visible = true;
                        datumistekareg.Visible = true;

                    

                }
                catch(Exception ex)
                {

                }
                TipVozila tv = s.Load<TipVozila>(textBox1.Text);
                try
                {
                    button2.Enabled = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox2.Text = tv.ModelVozila;
                    textBox3.Text = tv.Marka;
                    textBox4.Text = tv.Karoserija;
                    textBox5.Text = tv.Kapacitet;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Nepostoji vozilo s tom registracijom ");
                }
               

                s.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTOManager dm = new DTOManager();
            dm.AzurirajVozilo(textBox1.Text, BojaTB.Text, GodinaProizvodnjeTB.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
    }
}
