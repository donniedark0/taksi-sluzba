
namespace TaksiSluzba.Forme
{
    partial class IzmeniBroj
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
            this.brojZaMenjanje_txtBox = new System.Windows.Forms.TextBox();
            this.potvrdi_btn = new System.Windows.Forms.Button();
            this.izbrisi_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brojZaMenjanje_txtBox
            // 
            this.brojZaMenjanje_txtBox.Location = new System.Drawing.Point(32, 37);
            this.brojZaMenjanje_txtBox.Name = "brojZaMenjanje_txtBox";
            this.brojZaMenjanje_txtBox.Size = new System.Drawing.Size(243, 22);
            this.brojZaMenjanje_txtBox.TabIndex = 0;
            // 
            // potvrdi_btn
            // 
            this.potvrdi_btn.Location = new System.Drawing.Point(32, 65);
            this.potvrdi_btn.Name = "potvrdi_btn";
            this.potvrdi_btn.Size = new System.Drawing.Size(110, 37);
            this.potvrdi_btn.TabIndex = 1;
            this.potvrdi_btn.Text = "Izmeni";
            this.potvrdi_btn.UseVisualStyleBackColor = true;
            this.potvrdi_btn.Click += new System.EventHandler(this.Potvrdi_btn_Click);
            // 
            // izbrisi_btn
            // 
            this.izbrisi_btn.Location = new System.Drawing.Point(165, 65);
            this.izbrisi_btn.Name = "izbrisi_btn";
            this.izbrisi_btn.Size = new System.Drawing.Size(110, 37);
            this.izbrisi_btn.TabIndex = 2;
            this.izbrisi_btn.Text = "Izbrisi";
            this.izbrisi_btn.UseVisualStyleBackColor = true;
            this.izbrisi_btn.Click += new System.EventHandler(this.izbrisi_btn_Click);
            // 
            // IzmeniBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 125);
            this.Controls.Add(this.izbrisi_btn);
            this.Controls.Add(this.potvrdi_btn);
            this.Controls.Add(this.brojZaMenjanje_txtBox);
            this.Name = "IzmeniBroj";
            this.Text = "IzmeniBroj";
            this.Load += new System.EventHandler(this.IzmeniBroj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brojZaMenjanje_txtBox;
        private System.Windows.Forms.Button potvrdi_btn;
        private System.Windows.Forms.Button izbrisi_btn;
    }
}