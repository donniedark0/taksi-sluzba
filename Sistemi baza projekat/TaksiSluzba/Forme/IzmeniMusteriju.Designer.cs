
namespace TaksiSluzba.Forme
{
    partial class IzmeniMusteriju
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
            this.Adresa_txtBox = new System.Windows.Forms.TextBox();
            this.idMusterije_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brojevi_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izmeni_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Adresa_txtBox
            // 
            this.Adresa_txtBox.Location = new System.Drawing.Point(42, 118);
            this.Adresa_txtBox.Name = "Adresa_txtBox";
            this.Adresa_txtBox.Size = new System.Drawing.Size(213, 22);
            this.Adresa_txtBox.TabIndex = 29;
            // 
            // idMusterije_txtBox
            // 
            this.idMusterije_txtBox.Location = new System.Drawing.Point(42, 44);
            this.idMusterije_txtBox.Name = "idMusterije_txtBox";
            this.idMusterije_txtBox.Size = new System.Drawing.Size(213, 22);
            this.idMusterije_txtBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID musterije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adresa";
            // 
            // brojevi_cmb
            // 
            this.brojevi_cmb.FormattingEnabled = true;
            this.brojevi_cmb.Location = new System.Drawing.Point(42, 218);
            this.brojevi_cmb.Name = "brojevi_cmb";
            this.brojevi_cmb.Size = new System.Drawing.Size(213, 24);
            this.brojevi_cmb.TabIndex = 31;
            this.brojevi_cmb.SelectedIndexChanged += new System.EventHandler(this.brojevi_cmb_SelectedIndexChanged);
            this.brojevi_cmb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Brojevi telefona";
            // 
            // izmeni_btn
            // 
            this.izmeni_btn.Location = new System.Drawing.Point(96, 147);
            this.izmeni_btn.Name = "izmeni_btn";
            this.izmeni_btn.Size = new System.Drawing.Size(105, 32);
            this.izmeni_btn.TabIndex = 33;
            this.izmeni_btn.Text = "Izmeni adresu";
            this.izmeni_btn.UseVisualStyleBackColor = true;
            this.izmeni_btn.Click += new System.EventHandler(this.izmeni_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 45);
            this.button1.TabIndex = 34;
            this.button1.Text = "Dodaj broj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 35;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(127, 252);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 85);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "Klikom na neki broj se omogucuju i druge opcije za rad sa brojevima";
            // 
            // IzmeniMusteriju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 364);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.izmeni_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brojevi_cmb);
            this.Controls.Add(this.Adresa_txtBox);
            this.Controls.Add(this.idMusterije_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "IzmeniMusteriju";
            this.Text = "IzmeniMusteriju";
            this.Load += new System.EventHandler(this.IzmeniMusteriju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Adresa_txtBox;
        private System.Windows.Forms.TextBox idMusterije_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox brojevi_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izmeni_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}