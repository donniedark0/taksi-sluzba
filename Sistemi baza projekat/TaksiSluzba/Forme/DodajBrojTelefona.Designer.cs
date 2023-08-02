
namespace TaksiSluzba.Forme
{
    partial class DodajBrojTelefona
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
            this.Musterija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brTel_textBox = new System.Windows.Forms.TextBox();
            this.dodajBr_btn = new System.Windows.Forms.Button();
            this.idMusterije_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Musterija
            // 
            this.Musterija.AutoSize = true;
            this.Musterija.Location = new System.Drawing.Point(44, 51);
            this.Musterija.Name = "Musterija";
            this.Musterija.Size = new System.Drawing.Size(82, 17);
            this.Musterija.TabIndex = 1;
            this.Musterija.Text = "ID musterije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj telefona";
            // 
            // brTel_textBox
            // 
            this.brTel_textBox.Location = new System.Drawing.Point(161, 94);
            this.brTel_textBox.Name = "brTel_textBox";
            this.brTel_textBox.Size = new System.Drawing.Size(166, 22);
            this.brTel_textBox.TabIndex = 3;
            // 
            // dodajBr_btn
            // 
            this.dodajBr_btn.Location = new System.Drawing.Point(109, 145);
            this.dodajBr_btn.Name = "dodajBr_btn";
            this.dodajBr_btn.Size = new System.Drawing.Size(145, 38);
            this.dodajBr_btn.TabIndex = 4;
            this.dodajBr_btn.Text = "Dodaj broj telefona";
            this.dodajBr_btn.UseVisualStyleBackColor = true;
            this.dodajBr_btn.Click += new System.EventHandler(this.dodajBr_btn_Click);
            // 
            // idMusterije_txtBox
            // 
            this.idMusterije_txtBox.Location = new System.Drawing.Point(161, 48);
            this.idMusterije_txtBox.Name = "idMusterije_txtBox";
            this.idMusterije_txtBox.Size = new System.Drawing.Size(166, 22);
            this.idMusterije_txtBox.TabIndex = 5;
            // 
            // DodajBrojTelefona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 221);
            this.Controls.Add(this.idMusterije_txtBox);
            this.Controls.Add(this.dodajBr_btn);
            this.Controls.Add(this.brTel_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Musterija);
            this.Name = "DodajBrojTelefona";
            this.Text = "DodajBrojTelefona";
            this.Load += new System.EventHandler(this.DodajBrojTelefona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Musterija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brTel_textBox;
        private System.Windows.Forms.Button dodajBr_btn;
        private System.Windows.Forms.TextBox idMusterije_txtBox;
    }
}