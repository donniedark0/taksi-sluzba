
namespace TaksiSluzba.Forme
{
    partial class UcitajPoziv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.poziv_listView = new System.Windows.Forms.ListView();
            this.idMusterije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmbgZaposlenog = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vremePoziva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.izbrisiPoziv_btn = new System.Windows.Forms.Button();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.Dodaj_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poziv_listView
            // 
            this.poziv_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMusterije,
            this.jmbgZaposlenog,
            this.vremePoziva,
            this.brTelefona});
            this.poziv_listView.HideSelection = false;
            this.poziv_listView.Location = new System.Drawing.Point(27, 30);
            this.poziv_listView.Name = "poziv_listView";
            this.poziv_listView.Size = new System.Drawing.Size(732, 230);
            this.poziv_listView.TabIndex = 0;
            this.poziv_listView.UseCompatibleStateImageBehavior = false;
            this.poziv_listView.View = System.Windows.Forms.View.Details;
            this.poziv_listView.SelectedIndexChanged += new System.EventHandler(this.poziv_listView_SelectedIndexChanged);
            // 
            // idMusterije
            // 
            this.idMusterije.Text = "ID musterije";
            this.idMusterije.Width = 144;
            // 
            // jmbgZaposlenog
            // 
            this.jmbgZaposlenog.Text = "JMBG osoblja";
            this.jmbgZaposlenog.Width = 168;
            // 
            // vremePoziva
            // 
            this.vremePoziva.Text = "Vreme poziva";
            this.vremePoziva.Width = 137;
            // 
            // brTelefona
            // 
            this.brTelefona.Text = "Broj telefona";
            this.brTelefona.Width = 126;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // izbrisiPoziv_btn
            // 
            this.izbrisiPoziv_btn.Location = new System.Drawing.Point(186, 282);
            this.izbrisiPoziv_btn.Name = "izbrisiPoziv_btn";
            this.izbrisiPoziv_btn.Size = new System.Drawing.Size(101, 34);
            this.izbrisiPoziv_btn.TabIndex = 3;
            this.izbrisiPoziv_btn.Text = "Izbrisi poziv";
            this.izbrisiPoziv_btn.UseVisualStyleBackColor = true;
            this.izbrisiPoziv_btn.Click += new System.EventHandler(this.izbrisiPoziv_btn_Click);
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(321, 282);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(101, 34);
            this.izmeni_btn.TabIndex = 4;
            this.izmeni_btn.Text = "Izmeni poziv";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // Dodaj_btn
            // 
            this.Dodaj_btn.Location = new System.Drawing.Point(456, 282);
            this.Dodaj_btn.Name = "Dodaj_btn";
            this.Dodaj_btn.Size = new System.Drawing.Size(106, 34);
            this.Dodaj_btn.TabIndex = 5;
            this.Dodaj_btn.Text = "Dodaj poziv";
            this.Dodaj_btn.UseVisualStyleBackColor = true;
            this.Dodaj_btn.Click += new System.EventHandler(this.Dodaj_btn_Click);
            // 
            // UcitajPoziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.Dodaj_btn);
            this.Controls.Add(this.izmeni_btn);
            this.Controls.Add(this.izbrisiPoziv_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poziv_listView);
            this.Name = "UcitajPoziv";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UcitajPoziv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView poziv_listView;
        private System.Windows.Forms.ColumnHeader idMusterije;
        private System.Windows.Forms.ColumnHeader jmbgZaposlenog;
        private System.Windows.Forms.ColumnHeader vremePoziva;
        private System.Windows.Forms.ColumnHeader brTelefona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button izbrisiPoziv_btn;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button Dodaj_btn;
    }
}