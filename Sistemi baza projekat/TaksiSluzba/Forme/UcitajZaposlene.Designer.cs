
namespace TaksiSluzba.Forme
{
    partial class UcitajZaposlene
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
            this.AOsoblje_listView = new System.Windows.Forms.ListView();
            this.ImeC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimeC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrednjeSlovoC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBGC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrTelC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StrucnaSpremaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vozaci_listView = new System.Windows.Forms.ListView();
            this.ImeCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrezimeCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSlovoCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBGCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresaCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrTelCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KategCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrVozCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevoAO_btn = new System.Windows.Forms.Button();
            this.DesnoAO_btn = new System.Windows.Forms.Button();
            this.Dodaj_btn = new System.Windows.Forms.Button();
            this.vozacLevo_btn = new System.Windows.Forms.Button();
            this.vozacDesno_btn = new System.Windows.Forms.Button();
            this.izbrisiVozaca_btn = new System.Windows.Forms.Button();
            this.izbrisiOsoblje_btn = new System.Windows.Forms.Button();
            this.izmeniOsoblje_btn = new System.Windows.Forms.Button();
            this.izmeniVozaca_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AOsoblje_listView
            // 
            this.AOsoblje_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImeC,
            this.PrezimeC,
            this.SrednjeSlovoC,
            this.JMBGC,
            this.AdresaC,
            this.BrTelC,
            this.StrucnaSpremaC});
            this.AOsoblje_listView.HideSelection = false;
            this.AOsoblje_listView.Location = new System.Drawing.Point(22, 26);
            this.AOsoblje_listView.Name = "AOsoblje_listView";
            this.AOsoblje_listView.Size = new System.Drawing.Size(896, 160);
            this.AOsoblje_listView.TabIndex = 0;
            this.AOsoblje_listView.UseCompatibleStateImageBehavior = false;
            this.AOsoblje_listView.View = System.Windows.Forms.View.Details;
            // 
            // ImeC
            // 
            this.ImeC.Text = "Ime";
            this.ImeC.Width = 95;
            // 
            // PrezimeC
            // 
            this.PrezimeC.Text = "Prezime";
            this.PrezimeC.Width = 107;
            // 
            // SrednjeSlovoC
            // 
            this.SrednjeSlovoC.Text = "Srednje slovo";
            this.SrednjeSlovoC.Width = 46;
            // 
            // JMBGC
            // 
            this.JMBGC.Text = "JMBG";
            this.JMBGC.Width = 114;
            // 
            // AdresaC
            // 
            this.AdresaC.Text = "Adresa";
            this.AdresaC.Width = 134;
            // 
            // BrTelC
            // 
            this.BrTelC.Text = "Broj telefona";
            this.BrTelC.Width = 119;
            // 
            // StrucnaSpremaC
            // 
            this.StrucnaSpremaC.Text = "Strucna sprema";
            this.StrucnaSpremaC.Width = 270;
            // 
            // Vozaci_listView
            // 
            this.Vozaci_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImeCV,
            this.PrezimeCV,
            this.SSlovoCV,
            this.JMBGCV,
            this.AdresaCV,
            this.BrTelCV,
            this.KategCV,
            this.BrVozCV});
            this.Vozaci_listView.HideSelection = false;
            this.Vozaci_listView.Location = new System.Drawing.Point(22, 302);
            this.Vozaci_listView.Name = "Vozaci_listView";
            this.Vozaci_listView.Size = new System.Drawing.Size(896, 173);
            this.Vozaci_listView.TabIndex = 1;
            this.Vozaci_listView.UseCompatibleStateImageBehavior = false;
            this.Vozaci_listView.View = System.Windows.Forms.View.Details;
            // 
            // ImeCV
            // 
            this.ImeCV.Text = "Ime";
            this.ImeCV.Width = 95;
            // 
            // PrezimeCV
            // 
            this.PrezimeCV.Text = "Prezime";
            this.PrezimeCV.Width = 107;
            // 
            // SSlovoCV
            // 
            this.SSlovoCV.Text = "Srednje slovo";
            this.SSlovoCV.Width = 46;
            // 
            // JMBGCV
            // 
            this.JMBGCV.Text = "JMBG";
            this.JMBGCV.Width = 114;
            // 
            // AdresaCV
            // 
            this.AdresaCV.Text = "Adresa";
            this.AdresaCV.Width = 134;
            // 
            // BrTelCV
            // 
            this.BrTelCV.Text = "Broj telefona";
            this.BrTelCV.Width = 119;
            // 
            // KategCV
            // 
            this.KategCV.Text = "Kategorija";
            this.KategCV.Width = 150;
            // 
            // BrVozCV
            // 
            this.BrVozCV.Text = "Broj vozacke";
            this.BrVozCV.Width = 116;
            // 
            // LevoAO_btn
            // 
            this.LevoAO_btn.Location = new System.Drawing.Point(22, 202);
            this.LevoAO_btn.Name = "LevoAO_btn";
            this.LevoAO_btn.Size = new System.Drawing.Size(173, 25);
            this.LevoAO_btn.TabIndex = 2;
            this.LevoAO_btn.Text = "<-";
            this.LevoAO_btn.UseVisualStyleBackColor = true;
            this.LevoAO_btn.Click += new System.EventHandler(this.LevoAO_btn_Click);
            // 
            // DesnoAO_btn
            // 
            this.DesnoAO_btn.Location = new System.Drawing.Point(745, 202);
            this.DesnoAO_btn.Name = "DesnoAO_btn";
            this.DesnoAO_btn.Size = new System.Drawing.Size(173, 25);
            this.DesnoAO_btn.TabIndex = 3;
            this.DesnoAO_btn.Text = "->";
            this.DesnoAO_btn.UseVisualStyleBackColor = true;
            this.DesnoAO_btn.Click += new System.EventHandler(this.DesnoAO_btn_Click);
            // 
            // Dodaj_btn
            // 
            this.Dodaj_btn.Location = new System.Drawing.Point(408, 580);
            this.Dodaj_btn.Name = "Dodaj_btn";
            this.Dodaj_btn.Size = new System.Drawing.Size(130, 46);
            this.Dodaj_btn.TabIndex = 4;
            this.Dodaj_btn.Text = "Dodaj zaposlenog";
            this.Dodaj_btn.UseVisualStyleBackColor = true;
            this.Dodaj_btn.Click += new System.EventHandler(this.Dodaj_btn_Click);
            // 
            // vozacLevo_btn
            // 
            this.vozacLevo_btn.Location = new System.Drawing.Point(22, 494);
            this.vozacLevo_btn.Name = "vozacLevo_btn";
            this.vozacLevo_btn.Size = new System.Drawing.Size(173, 25);
            this.vozacLevo_btn.TabIndex = 5;
            this.vozacLevo_btn.Text = "<-";
            this.vozacLevo_btn.UseVisualStyleBackColor = true;
            this.vozacLevo_btn.Click += new System.EventHandler(this.vozacLevo_btn_Click);
            // 
            // vozacDesno_btn
            // 
            this.vozacDesno_btn.Location = new System.Drawing.Point(745, 494);
            this.vozacDesno_btn.Name = "vozacDesno_btn";
            this.vozacDesno_btn.Size = new System.Drawing.Size(173, 25);
            this.vozacDesno_btn.TabIndex = 6;
            this.vozacDesno_btn.Text = "->";
            this.vozacDesno_btn.UseVisualStyleBackColor = true;
            this.vozacDesno_btn.Click += new System.EventHandler(this.vozacDesno_btn_Click);
            // 
            // izbrisiVozaca_btn
            // 
            this.izbrisiVozaca_btn.Location = new System.Drawing.Point(546, 525);
            this.izbrisiVozaca_btn.Name = "izbrisiVozaca_btn";
            this.izbrisiVozaca_btn.Size = new System.Drawing.Size(130, 35);
            this.izbrisiVozaca_btn.TabIndex = 7;
            this.izbrisiVozaca_btn.Text = "Izbrisi vozaca";
            this.izbrisiVozaca_btn.UseVisualStyleBackColor = true;
            this.izbrisiVozaca_btn.Click += new System.EventHandler(this.izbrisiVozaca_btn_Click);
            // 
            // izbrisiOsoblje_btn
            // 
            this.izbrisiOsoblje_btn.Location = new System.Drawing.Point(546, 231);
            this.izbrisiOsoblje_btn.Name = "izbrisiOsoblje_btn";
            this.izbrisiOsoblje_btn.Size = new System.Drawing.Size(130, 35);
            this.izbrisiOsoblje_btn.TabIndex = 8;
            this.izbrisiOsoblje_btn.Text = "Izbrisi osoblje";
            this.izbrisiOsoblje_btn.UseVisualStyleBackColor = true;
            this.izbrisiOsoblje_btn.Click += new System.EventHandler(this.izbrisiOsoblje_btn_Click);
            // 
            // izmeniOsoblje_btn
            // 
            this.izmeniOsoblje_btn.Location = new System.Drawing.Point(272, 231);
            this.izmeniOsoblje_btn.Name = "izmeniOsoblje_btn";
            this.izmeniOsoblje_btn.Size = new System.Drawing.Size(130, 35);
            this.izmeniOsoblje_btn.TabIndex = 9;
            this.izmeniOsoblje_btn.Text = "Izmeni osoblje";
            this.izmeniOsoblje_btn.UseVisualStyleBackColor = true;
            this.izmeniOsoblje_btn.Click += new System.EventHandler(this.izmeniOsoblje_btn_Click);
            // 
            // izmeniVozaca_btn
            // 
            this.izmeniVozaca_btn.Location = new System.Drawing.Point(272, 525);
            this.izmeniVozaca_btn.Name = "izmeniVozaca_btn";
            this.izmeniVozaca_btn.Size = new System.Drawing.Size(130, 35);
            this.izmeniVozaca_btn.TabIndex = 10;
            this.izmeniVozaca_btn.Text = "Izmeni vozaca";
            this.izmeniVozaca_btn.UseVisualStyleBackColor = true;
            this.izmeniVozaca_btn.Click += new System.EventHandler(this.izmeniVozaca_btn_Click);
            // 
            // UcitajZaposlene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 643);
            this.Controls.Add(this.izmeniVozaca_btn);
            this.Controls.Add(this.izmeniOsoblje_btn);
            this.Controls.Add(this.izbrisiOsoblje_btn);
            this.Controls.Add(this.izbrisiVozaca_btn);
            this.Controls.Add(this.vozacDesno_btn);
            this.Controls.Add(this.vozacLevo_btn);
            this.Controls.Add(this.Dodaj_btn);
            this.Controls.Add(this.DesnoAO_btn);
            this.Controls.Add(this.LevoAO_btn);
            this.Controls.Add(this.Vozaci_listView);
            this.Controls.Add(this.AOsoblje_listView);
            this.Name = "UcitajZaposlene";
            this.Text = "UcitajZaposlene";
            this.Load += new System.EventHandler(this.UcitajZaposlene_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AOsoblje_listView;
        private System.Windows.Forms.ColumnHeader ImeC;
        private System.Windows.Forms.ColumnHeader PrezimeC;
        private System.Windows.Forms.ColumnHeader SrednjeSlovoC;
        private System.Windows.Forms.ColumnHeader JMBGC;
        private System.Windows.Forms.ColumnHeader AdresaC;
        private System.Windows.Forms.ColumnHeader BrTelC;
        private System.Windows.Forms.ColumnHeader StrucnaSpremaC;
        private System.Windows.Forms.ListView Vozaci_listView;
        private System.Windows.Forms.ColumnHeader ImeCV;
        private System.Windows.Forms.ColumnHeader PrezimeCV;
        private System.Windows.Forms.ColumnHeader SSlovoCV;
        private System.Windows.Forms.ColumnHeader JMBGCV;
        private System.Windows.Forms.ColumnHeader AdresaCV;
        private System.Windows.Forms.ColumnHeader BrTelCV;
        private System.Windows.Forms.ColumnHeader KategCV;
        private System.Windows.Forms.ColumnHeader BrVozCV;
        private System.Windows.Forms.Button LevoAO_btn;
        private System.Windows.Forms.Button DesnoAO_btn;
        private System.Windows.Forms.Button Dodaj_btn;
        private System.Windows.Forms.Button vozacLevo_btn;
        private System.Windows.Forms.Button vozacDesno_btn;
        private System.Windows.Forms.Button izbrisiVozaca_btn;
        private System.Windows.Forms.Button izbrisiOsoblje_btn;
        private System.Windows.Forms.Button izmeniOsoblje_btn;
        private System.Windows.Forms.Button izmeniVozaca_btn;
    }
}