
namespace TaksiSluzba
{
    partial class Form1
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
            this.PrikaziZaposlenog = new System.Windows.Forms.Button();
            this.PrikaziMusteriju = new System.Windows.Forms.Button();
            this.PrikaziVozilo = new System.Windows.Forms.Button();
            this.PrikaziPozivMusterije = new System.Windows.Forms.Button();
            this.PrikaziVpravljanjeVozilom = new System.Windows.Forms.Button();
            this.PrikaziVoznju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrikaziZaposlenog
            // 
            this.PrikaziZaposlenog.Location = new System.Drawing.Point(51, 49);
            this.PrikaziZaposlenog.Name = "PrikaziZaposlenog";
            this.PrikaziZaposlenog.Size = new System.Drawing.Size(101, 44);
            this.PrikaziZaposlenog.TabIndex = 6;
            this.PrikaziZaposlenog.Text = "Zaposleni";
            this.PrikaziZaposlenog.UseVisualStyleBackColor = true;
            this.PrikaziZaposlenog.Click += new System.EventHandler(this.PrikaziZaposlenog_Click);
            // 
            // PrikaziMusteriju
            // 
            this.PrikaziMusteriju.Location = new System.Drawing.Point(51, 122);
            this.PrikaziMusteriju.Name = "PrikaziMusteriju";
            this.PrikaziMusteriju.Size = new System.Drawing.Size(101, 44);
            this.PrikaziMusteriju.TabIndex = 9;
            this.PrikaziMusteriju.Text = "Musterije";
            this.PrikaziMusteriju.UseVisualStyleBackColor = true;
            this.PrikaziMusteriju.Click += new System.EventHandler(this.PrikaziMusteriju_Click);
            // 
            // PrikaziVozilo
            // 
            this.PrikaziVozilo.Location = new System.Drawing.Point(187, 122);
            this.PrikaziVozilo.Name = "PrikaziVozilo";
            this.PrikaziVozilo.Size = new System.Drawing.Size(101, 44);
            this.PrikaziVozilo.TabIndex = 11;
            this.PrikaziVozilo.Text = "Vozila";
            this.PrikaziVozilo.UseVisualStyleBackColor = true;
            this.PrikaziVozilo.Click += new System.EventHandler(this.PrikaziVozilo_Click);
            // 
            // PrikaziPozivMusterije
            // 
            this.PrikaziPozivMusterije.Location = new System.Drawing.Point(187, 49);
            this.PrikaziPozivMusterije.Name = "PrikaziPozivMusterije";
            this.PrikaziPozivMusterije.Size = new System.Drawing.Size(101, 44);
            this.PrikaziPozivMusterije.TabIndex = 13;
            this.PrikaziPozivMusterije.Text = "Pozivi";
            this.PrikaziPozivMusterije.UseVisualStyleBackColor = true;
            this.PrikaziPozivMusterije.Click += new System.EventHandler(this.PrikaziPozivMusterije_Click);
            // 
            // PrikaziVpravljanjeVozilom
            // 
            this.PrikaziVpravljanjeVozilom.Location = new System.Drawing.Point(187, 204);
            this.PrikaziVpravljanjeVozilom.Name = "PrikaziVpravljanjeVozilom";
            this.PrikaziVpravljanjeVozilom.Size = new System.Drawing.Size(101, 44);
            this.PrikaziVpravljanjeVozilom.TabIndex = 12;
            this.PrikaziVpravljanjeVozilom.Text = "Upravljanje vozilom";
            this.PrikaziVpravljanjeVozilom.UseVisualStyleBackColor = true;
            this.PrikaziVpravljanjeVozilom.Click += new System.EventHandler(this.PrikaziVpravljanjeVozilom_Click);
            // 
            // PrikaziVoznju
            // 
            this.PrikaziVoznju.Location = new System.Drawing.Point(51, 204);
            this.PrikaziVoznju.Name = "PrikaziVoznju";
            this.PrikaziVoznju.Size = new System.Drawing.Size(101, 44);
            this.PrikaziVoznju.TabIndex = 10;
            this.PrikaziVoznju.Text = "Voznje";
            this.PrikaziVoznju.UseVisualStyleBackColor = true;
            this.PrikaziVoznju.Click += new System.EventHandler(this.PrikaziVoznju_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 312);
            this.Controls.Add(this.PrikaziVozilo);
            this.Controls.Add(this.PrikaziPozivMusterije);
            this.Controls.Add(this.PrikaziZaposlenog);
            this.Controls.Add(this.PrikaziVpravljanjeVozilom);
            this.Controls.Add(this.PrikaziMusteriju);
            this.Controls.Add(this.PrikaziVoznju);
            this.Name = "Form1";
            this.Text = "Taksi sluzba";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PrikaziZaposlenog;
        private System.Windows.Forms.Button PrikaziMusteriju;
        private System.Windows.Forms.Button PrikaziVozilo;
        private System.Windows.Forms.Button PrikaziPozivMusterije;
        private System.Windows.Forms.Button PrikaziVpravljanjeVozilom;
        private System.Windows.Forms.Button PrikaziVoznju;
    }
}

