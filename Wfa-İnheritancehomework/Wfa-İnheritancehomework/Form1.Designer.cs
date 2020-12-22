
namespace Wfa_İnheritancehomework
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
            this.lvikitaplar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvioyunkonsol = new System.Windows.Forms.ListView();
            this.lvielektronik = new System.Windows.Forms.ListView();
            this.lvimüzik = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvikitaplar
            // 
            this.lvikitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvikitaplar.FullRowSelect = true;
            this.lvikitaplar.GridLines = true;
            this.lvikitaplar.HideSelection = false;
            this.lvikitaplar.Location = new System.Drawing.Point(346, 4);
            this.lvikitaplar.Name = "lvikitaplar";
            this.lvikitaplar.Size = new System.Drawing.Size(869, 101);
            this.lvikitaplar.TabIndex = 8;
            this.lvikitaplar.UseCompatibleStateImageBehavior = false;
            this.lvikitaplar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitap Adı";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazar";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basım Yılı";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yayın Evi";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kapak Türü";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.Width = 80;
            // 
            // lvioyunkonsol
            // 
            this.lvioyunkonsol.FullRowSelect = true;
            this.lvioyunkonsol.GridLines = true;
            this.lvioyunkonsol.HideSelection = false;
            this.lvioyunkonsol.Location = new System.Drawing.Point(346, 111);
            this.lvioyunkonsol.Name = "lvioyunkonsol";
            this.lvioyunkonsol.Size = new System.Drawing.Size(869, 101);
            this.lvioyunkonsol.TabIndex = 8;
            this.lvioyunkonsol.UseCompatibleStateImageBehavior = false;
            this.lvioyunkonsol.View = System.Windows.Forms.View.Details;
            // 
            // lvielektronik
            // 
            this.lvielektronik.HideSelection = false;
            this.lvielektronik.Location = new System.Drawing.Point(346, 218);
            this.lvielektronik.Name = "lvielektronik";
            this.lvielektronik.Size = new System.Drawing.Size(869, 101);
            this.lvielektronik.TabIndex = 8;
            this.lvielektronik.UseCompatibleStateImageBehavior = false;
            // 
            // lvimüzik
            // 
            this.lvimüzik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvimüzik.FullRowSelect = true;
            this.lvimüzik.GridLines = true;
            this.lvimüzik.HideSelection = false;
            this.lvimüzik.Location = new System.Drawing.Point(346, 325);
            this.lvimüzik.Name = "lvimüzik";
            this.lvimüzik.Size = new System.Drawing.Size(869, 101);
            this.lvimüzik.TabIndex = 8;
            this.lvimüzik.UseCompatibleStateImageBehavior = false;
            this.lvimüzik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sanatçı Adı";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Albüm Adı";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Çıkış Yılı";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dil";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tür";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Fiyat";
            this.columnHeader12.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.lvimüzik);
            this.Controls.Add(this.lvielektronik);
            this.Controls.Add(this.lvioyunkonsol);
            this.Controls.Add(this.lvikitaplar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvikitaplar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvioyunkonsol;
        private System.Windows.Forms.ListView lvielektronik;
        private System.Windows.Forms.ListView lvimüzik;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

