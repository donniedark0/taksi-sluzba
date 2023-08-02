
namespace TaksiSluzba.Forme
{
    partial class DodajMusteriju
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
            this.Dodaj_btn = new System.Windows.Forms.Button();
            this.Adresa_txtBox = new System.Windows.Forms.TextBox();
            this.idMusterije_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajtel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_btn
            // 
            this.Dodaj_btn.Location = new System.Drawing.Point(131, 98);
            this.Dodaj_btn.Name = "Dodaj_btn";
            this.Dodaj_btn.Size = new System.Drawing.Size(88, 32);
            this.Dodaj_btn.TabIndex = 25;
            this.Dodaj_btn.Text = "Dodaj";
            this.Dodaj_btn.UseVisualStyleBackColor = true;
            this.Dodaj_btn.Click += new System.EventHandler(this.Dodaj_btn_Click);
            // 
            // Adresa_txtBox
            // 
            this.Adresa_txtBox.Location = new System.Drawing.Point(131, 57);
            this.Adresa_txtBox.Name = "Adresa_txtBox";
            this.Adresa_txtBox.Size = new System.Drawing.Size(197, 22);
            this.Adresa_txtBox.TabIndex = 24;
            // 
            // idMusterije_txtBox
            // 
            this.idMusterije_txtBox.Location = new System.Drawing.Point(131, 23);
            this.idMusterije_txtBox.Name = "idMusterije_txtBox";
            this.idMusterije_txtBox.Size = new System.Drawing.Size(197, 22);
            this.idMusterije_txtBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID musterije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adresa";
            // 
            // dodajtel_btn
            // 
            this.dodajtel_btn.Location = new System.Drawing.Point(240, 98);
            this.dodajtel_btn.Name = "dodajtel_btn";
            this.dodajtel_btn.Size = new System.Drawing.Size(88, 51);
            this.dodajtel_btn.TabIndex = 26;
            this.dodajtel_btn.Text = "Dodaj broj telefona";
            this.dodajtel_btn.UseVisualStyleBackColor = true;
            this.dodajtel_btn.Click += new System.EventHandler(this.dodajtel_btn_Click);
            // 
            // DodajMusteriju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 168);
            this.Controls.Add(this.dodajtel_btn);
            this.Controls.Add(this.Dodaj_btn);
            this.Controls.Add(this.Adresa_txtBox);
            this.Controls.Add(this.idMusterije_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "DodajMusteriju";
            this.Text = "DodajMusteriju";
            this.Load += new System.EventHandler(this.DodajMusteriju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_btn;
        private System.Windows.Forms.TextBox Adresa_txtBox;
        private System.Windows.Forms.TextBox idMusterije_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajtel_btn;
    }
}