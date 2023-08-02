
namespace TaksiSluzba.Forme
{
    partial class Upravljanja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prikazi_btn = new System.Windows.Forms.Button();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izbrisi_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izbrisi_btn);
            this.groupBox1.Controls.Add(this.dodaj_btn);
            this.groupBox1.Controls.Add(this.izmeni_btn);
            this.groupBox1.Controls.Add(this.prikazi_btn);
            this.groupBox1.Location = new System.Drawing.Point(42, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacije nad upravljanjem";
            // 
            // prikazi_btn
            // 
            this.prikazi_btn.Location = new System.Drawing.Point(21, 39);
            this.prikazi_btn.Name = "prikazi_btn";
            this.prikazi_btn.Size = new System.Drawing.Size(129, 52);
            this.prikazi_btn.TabIndex = 0;
            this.prikazi_btn.Text = "Prikazi upravljanje";
            this.prikazi_btn.UseVisualStyleBackColor = true;
            this.prikazi_btn.Click += new System.EventHandler(this.prikazi_btn_Click);
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(184, 39);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(126, 52);
            this.izmeni_btn.TabIndex = 1;
            this.izmeni_btn.Text = "Izmeni upravljanje";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(28, 117);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(122, 52);
            this.dodaj_btn.TabIndex = 2;
            this.dodaj_btn.Text = "Dodaj upravljanje";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izbrisi_btn
            // 
            this.izbrisi_btn.Location = new System.Drawing.Point(184, 117);
            this.izbrisi_btn.Name = "izbrisi_btn";
            this.izbrisi_btn.Size = new System.Drawing.Size(117, 52);
            this.izbrisi_btn.TabIndex = 3;
            this.izbrisi_btn.Text = "Izbrisi upravljanje";
            this.izbrisi_btn.UseVisualStyleBackColor = true;
            this.izbrisi_btn.Click += new System.EventHandler(this.izbrisi_btn_Click);
            // 
            // Upravljanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "Upravljanja";
            this.Text = "Upravljanja";
            this.Load += new System.EventHandler(this.Upravljanja_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button prikazi_btn;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button izbrisi_btn;
        private System.Windows.Forms.Button dodaj_btn;
    }
}