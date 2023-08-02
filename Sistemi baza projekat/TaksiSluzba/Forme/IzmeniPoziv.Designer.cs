
namespace TaksiSluzba.Forme
{
    partial class IzmeniPoziv
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aosoblje_cmb = new System.Windows.Forms.ComboBox();
            this.musterija_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // brojevi_cmb
            // 
            this.brojevi_cmb.FormattingEnabled = true;
            this.brojevi_cmb.Location = new System.Drawing.Point(45, 134);
            this.brojevi_cmb.Name = "brojevi_cmb";
            this.brojevi_cmb.Size = new System.Drawing.Size(148, 24);
            this.brojevi_cmb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Izaberite broj telefona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Izaberite administrativno osoblje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Izaberite ID musterije";
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(207, 296);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(105, 40);
            this.izmeni_btn.TabIndex = 12;
            this.izmeni_btn.Text = "Izmeni poziv";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(273, 132);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // aosoblje_cmb
            // 
            this.aosoblje_cmb.FormattingEnabled = true;
            this.aosoblje_cmb.Location = new System.Drawing.Point(273, 48);
            this.aosoblje_cmb.Name = "aosoblje_cmb";
            this.aosoblje_cmb.Size = new System.Drawing.Size(245, 24);
            this.aosoblje_cmb.TabIndex = 10;
            // 
            // musterija_cmb
            // 
            this.musterija_cmb.FormattingEnabled = true;
            this.musterija_cmb.Location = new System.Drawing.Point(45, 48);
            this.musterija_cmb.Name = "musterija_cmb";
            this.musterija_cmb.Size = new System.Drawing.Size(148, 24);
            this.musterija_cmb.TabIndex = 9;
            // 
            // IzmeniPoziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 355);
            this.Controls.Add(this.brojevi_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izmeni_btn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.aosoblje_cmb);
            this.Controls.Add(this.musterija_cmb);
            this.Name = "IzmeniPoziv";
            this.Text = "IzmeniPoziv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brojevi_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox aosoblje_cmb;
        private System.Windows.Forms.ComboBox musterija_cmb;
    }
}