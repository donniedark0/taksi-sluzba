
namespace TaksiSluzba.Forme
{
    partial class Vozila
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
            this.button1 = new System.Windows.Forms.Button();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izbrisi_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prikazi vozilo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.prikazi_btn_Click);
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(177, 39);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(129, 41);
            this.izmeni_btn.TabIndex = 1;
            this.izmeni_btn.Text = "Izmeni vozilo";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(21, 110);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(129, 41);
            this.dodaj_btn.TabIndex = 2;
            this.dodaj_btn.Text = "Dodaj vozilo";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izbrisi_btn
            // 
            this.izbrisi_btn.Location = new System.Drawing.Point(177, 110);
            this.izbrisi_btn.Name = "izbrisi_btn";
            this.izbrisi_btn.Size = new System.Drawing.Size(129, 41);
            this.izbrisi_btn.TabIndex = 3;
            this.izbrisi_btn.Text = "Izbrisi vozilo";
            this.izbrisi_btn.UseVisualStyleBackColor = true;
            this.izbrisi_btn.Click += new System.EventHandler(this.izbrisi_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izbrisi_btn);
            this.groupBox1.Controls.Add(this.dodaj_btn);
            this.groupBox1.Controls.Add(this.izmeni_btn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacije nad vozilima";
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 249);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vozila";
            this.Text = "Vozila";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button izbrisi_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}