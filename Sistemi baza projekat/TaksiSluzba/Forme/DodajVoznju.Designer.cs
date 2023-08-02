
namespace TaksiSluzba.Forme
{
    partial class DodajVoznju
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
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_txtBox = new System.Windows.Forms.TextBox();
            this.pocStan_txtBox = new System.Windows.Forms.TextBox();
            this.krajStan_txtBox = new System.Windows.Forms.TextBox();
            this.pocetak_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kraj_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.osoblje_cmb = new System.Windows.Forms.ComboBox();
            this.vozac_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(391, 238);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(113, 37);
            this.dodaj_btn.TabIndex = 0;
            this.dodaj_btn.Text = "Dodaj voznju";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID voznje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pocetna stanica";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Krajnja stanica";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vreme pocetka voznje";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vreme kraja voznje";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // id_txtBox
            // 
            this.id_txtBox.Location = new System.Drawing.Point(207, 30);
            this.id_txtBox.Name = "id_txtBox";
            this.id_txtBox.Size = new System.Drawing.Size(175, 22);
            this.id_txtBox.TabIndex = 6;
            this.id_txtBox.TextChanged += new System.EventHandler(this.id_txtBox_TextChanged);
            // 
            // pocStan_txtBox
            // 
            this.pocStan_txtBox.Location = new System.Drawing.Point(207, 66);
            this.pocStan_txtBox.Name = "pocStan_txtBox";
            this.pocStan_txtBox.Size = new System.Drawing.Size(175, 22);
            this.pocStan_txtBox.TabIndex = 7;
            this.pocStan_txtBox.TextChanged += new System.EventHandler(this.pocStan_txtBox_TextChanged);
            // 
            // krajStan_txtBox
            // 
            this.krajStan_txtBox.Location = new System.Drawing.Point(207, 104);
            this.krajStan_txtBox.Name = "krajStan_txtBox";
            this.krajStan_txtBox.Size = new System.Drawing.Size(175, 22);
            this.krajStan_txtBox.TabIndex = 8;
            this.krajStan_txtBox.TextChanged += new System.EventHandler(this.krajStan_txtBox_TextChanged);
            // 
            // pocetak_dateTimePicker
            // 
            this.pocetak_dateTimePicker.Location = new System.Drawing.Point(420, 59);
            this.pocetak_dateTimePicker.Name = "pocetak_dateTimePicker";
            this.pocetak_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.pocetak_dateTimePicker.TabIndex = 9;
            this.pocetak_dateTimePicker.ValueChanged += new System.EventHandler(this.pocetak_dateTimePicker_ValueChanged);
            // 
            // kraj_dateTimePicker
            // 
            this.kraj_dateTimePicker.Location = new System.Drawing.Point(668, 59);
            this.kraj_dateTimePicker.Name = "kraj_dateTimePicker";
            this.kraj_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.kraj_dateTimePicker.TabIndex = 10;
            this.kraj_dateTimePicker.ValueChanged += new System.EventHandler(this.kraj_dateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Osoblje koje je primilo poziv";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vozac koji je obavio voznju";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // osoblje_cmb
            // 
            this.osoblje_cmb.FormattingEnabled = true;
            this.osoblje_cmb.Location = new System.Drawing.Point(207, 145);
            this.osoblje_cmb.Name = "osoblje_cmb";
            this.osoblje_cmb.Size = new System.Drawing.Size(175, 24);
            this.osoblje_cmb.TabIndex = 15;
            this.osoblje_cmb.SelectedIndexChanged += new System.EventHandler(this.osoblje_cmb_SelectedIndexChanged);
            // 
            // vozac_cmb
            // 
            this.vozac_cmb.FormattingEnabled = true;
            this.vozac_cmb.Location = new System.Drawing.Point(207, 185);
            this.vozac_cmb.Name = "vozac_cmb";
            this.vozac_cmb.Size = new System.Drawing.Size(175, 24);
            this.vozac_cmb.TabIndex = 16;
            this.vozac_cmb.SelectedIndexChanged += new System.EventHandler(this.vozac_cmb_SelectedIndexChanged);
            // 
            // DodajVoznju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 292);
            this.Controls.Add(this.vozac_cmb);
            this.Controls.Add(this.osoblje_cmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kraj_dateTimePicker);
            this.Controls.Add(this.pocetak_dateTimePicker);
            this.Controls.Add(this.krajStan_txtBox);
            this.Controls.Add(this.pocStan_txtBox);
            this.Controls.Add(this.id_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodaj_btn);
            this.Name = "DodajVoznju";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DodajVoznju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_txtBox;
        private System.Windows.Forms.TextBox pocStan_txtBox;
        private System.Windows.Forms.TextBox krajStan_txtBox;
        private System.Windows.Forms.DateTimePicker pocetak_dateTimePicker;
        private System.Windows.Forms.DateTimePicker kraj_dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox osoblje_cmb;
        private System.Windows.Forms.ComboBox vozac_cmb;
    }
}