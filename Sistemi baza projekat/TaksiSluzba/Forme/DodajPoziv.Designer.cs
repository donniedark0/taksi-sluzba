
namespace TaksiSluzba.Forme
{
    partial class DodajPoziv
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
            this.musterija_cmb = new System.Windows.Forms.ComboBox();
            this.aosoblje_cmb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brojevi_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // musterija_cmb
            // 
            this.musterija_cmb.FormattingEnabled = true;
            this.musterija_cmb.Location = new System.Drawing.Point(35, 38);
            this.musterija_cmb.Name = "musterija_cmb";
            this.musterija_cmb.Size = new System.Drawing.Size(148, 24);
            this.musterija_cmb.TabIndex = 0;
            this.musterija_cmb.SelectedIndexChanged += new System.EventHandler(this.musterija_cmb_SelectedIndexChanged);
            // 
            // aosoblje_cmb
            // 
            this.aosoblje_cmb.FormattingEnabled = true;
            this.aosoblje_cmb.Location = new System.Drawing.Point(263, 38);
            this.aosoblje_cmb.Name = "aosoblje_cmb";
            this.aosoblje_cmb.Size = new System.Drawing.Size(245, 24);
            this.aosoblje_cmb.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(197, 286);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(105, 40);
            this.dodaj_btn.TabIndex = 4;
            this.dodaj_btn.Text = "Dodaj poziv";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite ID musterije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Izaberite administrativno osoblje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izaberite broj telefona";
            // 
            // brojevi_cmb
            // 
            this.brojevi_cmb.FormattingEnabled = true;
            this.brojevi_cmb.Location = new System.Drawing.Point(35, 124);
            this.brojevi_cmb.Name = "brojevi_cmb";
            this.brojevi_cmb.Size = new System.Drawing.Size(148, 24);
            this.brojevi_cmb.TabIndex = 8;
            // 
            // DodajPoziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 347);
            this.Controls.Add(this.brojevi_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.aosoblje_cmb);
            this.Controls.Add(this.musterija_cmb);
            this.Name = "DodajPoziv";
            this.Text = "DodajPoziv";
            this.Load += new System.EventHandler(this.DodajPoziv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox musterija_cmb;
        private System.Windows.Forms.ComboBox aosoblje_cmb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox brojevi_cmb;
    }
}