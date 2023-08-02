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
    public partial class IzmeniMusteriju : Form
    {
        public IList<long> _listaBrojeva;
        public int _idMusterije;
        public int j;
        public long noviBroj;
        public IzmeniMusteriju(int id)
        {
            InitializeComponent();
            _idMusterije = id;
        }

        private void IzmeniMusteriju_Load(object sender, EventArgs e)
        {
            j = 0;
            idMusterije_txtBox.Text = _idMusterije.ToString();
            idMusterije_txtBox.Enabled = false;
            MusterijaPregled musInfo = DTOManager.UcitajInfoJedneMusterije(_idMusterije);
            _listaBrojeva = DTOManager.FiltrirajBrojeveTelefona(musInfo);
            Adresa_txtBox.Text = musInfo.Adresa;
            brojevi_cmb.DataSource = _listaBrojeva;
        }


        private void izmeni_btn_Click(object sender, EventArgs e)
        { 
            MusterijaPregled novaMusterija = new MusterijaPregled();

           IList<BrTelPregled> brojeviZaUpis = new List<BrTelPregled>();


            foreach (long br in _listaBrojeva)
            {
                BrTelPregled brojZaDodavanje = new BrTelPregled();
                brojZaDodavanje.BrojTel = br;
                brojeviZaUpis.Add(brojZaDodavanje);
            }

            novaMusterija.Adresa = Adresa_txtBox.Text;
            novaMusterija.IDMusterije = _idMusterije;
            novaMusterija.Brojevi = brojeviZaUpis;


            foreach (BrTelPregled broj in novaMusterija.Brojevi)
            {
                MessageBox.Show(broj.BrojTel.ToString());

            }

            if (DTOManager.IzmeniMusteriju(novaMusterija))
            {
                MessageBox.Show("Uspešno ste izmenili musteriju!");
                Adresa_txtBox.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
            }
        }

        private void brojevi_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (j != 0)
            {
                BrTelPregled stariBroj = new BrTelPregled();
                stariBroj.BrojTel = long.Parse(brojevi_cmb.SelectedItem.ToString());
                stariBroj.Musterija.IDMusterije = _idMusterije;
                IzmeniBroj izmeniBroj = new IzmeniBroj(stariBroj);
                izmeniBroj.ShowDialog();

            }
            j++;
        }
        
        private void mouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajBrojTelefona dodajBrojTelefona = new DodajBrojTelefona(_idMusterije);
            dodajBrojTelefona.ShowDialog();
        }
    }
}
