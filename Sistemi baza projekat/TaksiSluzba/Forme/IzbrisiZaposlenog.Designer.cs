
namespace TaksiSluzba.Forme
{
    partial class IzbrisiZaposlenog
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
            this.Izbrisi_btn = new System.Windows.Forms.Button();
            this.Vozac_chckBox = new System.Windows.Forms.CheckBox();
            this.AO_chckBox = new System.Windows.Forms.CheckBox();
            this.JMBG_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Izbrisi_btn
            // 
            this.Izbrisi_btn.Location = new System.Drawing.Point(326, 88);
            this.Izbrisi_btn.Name = "Izbrisi_btn";
            this.Izbrisi_btn.Size = new System.Drawing.Size(85, 36);
            this.Izbrisi_btn.TabIndex = 42;
            this.Izbrisi_btn.Text = "Izbrisi";
            this.Izbrisi_btn.UseVisualStyleBackColor = true;
            this.Izbrisi_btn.Click += new System.EventHandler(this.Izbrisi_btn_Click);
            // 
            // Vozac_chckBox
            // 
            this.Vozac_chckBox.AutoSize = true;
            this.Vozac_chckBox.Location = new System.Drawing.Point(228, 53);
            this.Vozac_chckBox.Name = "Vozac_chckBox";
            this.Vozac_chckBox.Size = new System.Drawing.Size(69, 21);
            this.Vozac_chckBox.TabIndex = 41;
            this.Vozac_chckBox.Text = "Vozac";
            this.Vozac_chckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Vozac_chckBox.UseVisualStyleBackColor = true;
            // 
            // AO_chckBox
            // 
            this.AO_chckBox.AutoSize = true;
            this.AO_chckBox.Location = new System.Drawing.Point(40, 53);
            this.AO_chckBox.Name = "AO_chckBox";
            this.AO_chckBox.Size = new System.Drawing.Size(175, 21);
            this.AO_chckBox.TabIndex = 40;
            this.AO_chckBox.Text = "Administrativno osoblje";
            this.AO_chckBox.UseVisualStyleBackColor = true;
            // 
            // JMBG_txtBox
            // 
            this.JMBG_txtBox.Location = new System.Drawing.Point(95, 95);
            this.JMBG_txtBox.Name = "JMBG_txtBox";
            this.JMBG_txtBox.Size = new System.Drawing.Size(197, 22);
            this.JMBG_txtBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "JMBG";
            // 
            // IzbrisiZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 175);
            this.Controls.Add(this.Izbrisi_btn);
            this.Controls.Add(this.Vozac_chckBox);
            this.Controls.Add(this.AO_chckBox);
            this.Controls.Add(this.JMBG_txtBox);
            this.Controls.Add(this.label5);
            this.Name = "IzbrisiZaposlenog";
            this.Text = "IzbrisiZaposlenog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Izbrisi_btn;
        private System.Windows.Forms.CheckBox Vozac_chckBox;
        private System.Windows.Forms.CheckBox AO_chckBox;
        private System.Windows.Forms.TextBox JMBG_txtBox;
        private System.Windows.Forms.Label label5;
    }
}