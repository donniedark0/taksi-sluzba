
namespace TaksiSluzba.Forme
{
    partial class UcitajMusterije
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
            this.brojevi_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musterija_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adresa_txtBox = new System.Windows.Forms.TextBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.izbrisi_btn = new System.Windows.Forms.Button();
            this.popust_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // brojevi_cmb
            // 
            this.brojevi_cmb.FormattingEnabled = true;
            this.brojevi_cmb.Location = new System.Drawing.Point(58, 147);
            this.brojevi_cmb.Name = "brojevi_cmb";
            this.brojevi_cmb.Size = new System.Drawing.Size(148, 24);
            this.brojevi_cmb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Brojevi telefona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Izaberite ID musterije";
            // 
            // musterija_cmb
            // 
            this.musterija_cmb.FormattingEnabled = true;
            this.musterija_cmb.Location = new System.Drawing.Point(58, 55);
            this.musterija_cmb.Name = "musterija_cmb";
            this.musterija_cmb.Size = new System.Drawing.Size(148, 24);
            this.musterija_cmb.TabIndex = 17;
            this.musterija_cmb.SelectedIndexChanged += new System.EventHandler(this.musterija_cmb_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adresa";
            // 
            // Adresa_txtBox
            // 
            this.Adresa_txtBox.Location = new System.Drawing.Point(58, 213);
            this.Adresa_txtBox.Name = "Adresa_txtBox";
            this.Adresa_txtBox.Size = new System.Drawing.Size(148, 22);
            this.Adresa_txtBox.TabIndex = 30;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(75, 373);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(116, 44);
            this.dodaj_btn.TabIndex = 31;
            this.dodaj_btn.Text = "Dodaj musteriju";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(75, 250);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(116, 44);
            this.izmeni_btn.TabIndex = 32;
            this.izmeni_btn.Text = "Izmeni musteriju";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // izbrisi_btn
            // 
            this.izbrisi_btn.Location = new System.Drawing.Point(75, 311);
            this.izbrisi_btn.Name = "izbrisi_btn";
            this.izbrisi_btn.Size = new System.Drawing.Size(116, 44);
            this.izbrisi_btn.TabIndex = 33;
            this.izbrisi_btn.Text = "Izbrisi musteriju";
            this.izbrisi_btn.UseVisualStyleBackColor = true;
            this.izbrisi_btn.Click += new System.EventHandler(this.izbrisi_btn_Click);
            // 
            // popust_checkBox
            // 
            this.popust_checkBox.AutoSize = true;
            this.popust_checkBox.Location = new System.Drawing.Point(124, 85);
            this.popust_checkBox.Name = "popust_checkBox";
            this.popust_checkBox.Size = new System.Drawing.Size(82, 21);
            this.popust_checkBox.TabIndex = 34;
            this.popust_checkBox.Text = "Popust?";
            this.popust_checkBox.UseVisualStyleBackColor = true;
            // 
            // UcitajMusterije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 429);
            this.Controls.Add(this.popust_checkBox);
            this.Controls.Add(this.izbrisi_btn);
            this.Controls.Add(this.izmeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.Adresa_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brojevi_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musterija_cmb);
            this.Name = "UcitajMusterije";
            this.Text = "UcitajMusterije";
            this.Load += new System.EventHandler(this.UcitajMusterije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brojevi_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox musterija_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adresa_txtBox;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button izbrisi_btn;
        private System.Windows.Forms.CheckBox popust_checkBox;
    }
}