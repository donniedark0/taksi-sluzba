
namespace TaksiSluzba.Forme
{
    partial class PrikaziVoznju
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
            this.voznja_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.izbrisi_brn = new System.Windows.Forms.Button();
            this.levo_btn = new System.Windows.Forms.Button();
            this.desno_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voznja_listView
            // 
            this.voznja_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7});
            this.voznja_listView.HideSelection = false;
            this.voznja_listView.Location = new System.Drawing.Point(26, 29);
            this.voznja_listView.Name = "voznja_listView";
            this.voznja_listView.Size = new System.Drawing.Size(762, 221);
            this.voznja_listView.TabIndex = 0;
            this.voznja_listView.UseCompatibleStateImageBehavior = false;
            this.voznja_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID voznje";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Pocetna stanica";
            this.columnHeader4.Width = 167;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Krajnja stanica";
            this.columnHeader5.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Vreme pocetka voznje";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Vreme kraja voznje";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Osoblje koje je primilo poziv";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vozac koji je vozio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj voznju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Izmeni voznju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // izbrisi_brn
            // 
            this.izbrisi_brn.Location = new System.Drawing.Point(538, 269);
            this.izbrisi_brn.Name = "izbrisi_brn";
            this.izbrisi_brn.Size = new System.Drawing.Size(138, 47);
            this.izbrisi_brn.TabIndex = 3;
            this.izbrisi_brn.Text = "Izbrisi voznju";
            this.izbrisi_brn.UseVisualStyleBackColor = true;
            this.izbrisi_brn.Click += new System.EventHandler(this.izbrisi_btn_Click);
            // 
            // levo_btn
            // 
            this.levo_btn.Location = new System.Drawing.Point(26, 256);
            this.levo_btn.Name = "levo_btn";
            this.levo_btn.Size = new System.Drawing.Size(75, 23);
            this.levo_btn.TabIndex = 4;
            this.levo_btn.Text = "<-";
            this.levo_btn.UseVisualStyleBackColor = true;
            this.levo_btn.Click += new System.EventHandler(this.levo_btn_Click);
            // 
            // desno_btn
            // 
            this.desno_btn.Location = new System.Drawing.Point(713, 256);
            this.desno_btn.Name = "desno_btn";
            this.desno_btn.Size = new System.Drawing.Size(75, 23);
            this.desno_btn.TabIndex = 5;
            this.desno_btn.Text = "->";
            this.desno_btn.UseVisualStyleBackColor = true;
            this.desno_btn.Click += new System.EventHandler(this.desno_btn_Click);
            // 
            // PrikaziVoznju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.desno_btn);
            this.Controls.Add(this.levo_btn);
            this.Controls.Add(this.izbrisi_brn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voznja_listView);
            this.Name = "PrikaziVoznju";
            this.Text = "PrikaziVoznju";
            this.Load += new System.EventHandler(this.PrikaziVoznju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView voznja_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button izbrisi_brn;
        private System.Windows.Forms.Button levo_btn;
        private System.Windows.Forms.Button desno_btn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}