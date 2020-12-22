
namespace WFA_ClassOluşturmaÖdevi
{
    partial class FormDefter
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.nudyaprak = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbcizgili = new System.Windows.Forms.RadioButton();
            this.rbkareli = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudyaprak)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Yaprak Sayısı";
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(138, 211);
            this.nudfiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 20);
            this.nudfiyat.TabIndex = 32;
            // 
            // nudyaprak
            // 
            this.nudyaprak.Location = new System.Drawing.Point(138, 185);
            this.nudyaprak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudyaprak.Name = "nudyaprak";
            this.nudyaprak.Size = new System.Drawing.Size(120, 20);
            this.nudyaprak.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Marka";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(163, 285);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 27;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Defter";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(138, 123);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(318, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 277);
            this.listBox1.TabIndex = 24;
            // 
            // rbcizgili
            // 
            this.rbcizgili.AutoSize = true;
            this.rbcizgili.Location = new System.Drawing.Point(125, 158);
            this.rbcizgili.Name = "rbcizgili";
            this.rbcizgili.Size = new System.Drawing.Size(53, 17);
            this.rbcizgili.TabIndex = 35;
            this.rbcizgili.TabStop = true;
            this.rbcizgili.Text = "Çizgilii";
            this.rbcizgili.UseVisualStyleBackColor = true;
            // 
            // rbkareli
            // 
            this.rbkareli.AutoSize = true;
            this.rbkareli.Location = new System.Drawing.Point(207, 160);
            this.rbkareli.Name = "rbkareli";
            this.rbkareli.Size = new System.Drawing.Size(51, 17);
            this.rbkareli.TabIndex = 36;
            this.rbkareli.TabStop = true;
            this.rbkareli.Text = "Kareli";
            this.rbkareli.UseVisualStyleBackColor = true;
            // 
            // FormDefter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbkareli);
            this.Controls.Add(this.rbcizgili);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.nudyaprak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.listBox1);
            this.Name = "FormDefter";
            this.Text = "FormDefter";
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudyaprak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.NumericUpDown nudyaprak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbcizgili;
        private System.Windows.Forms.RadioButton rbkareli;
    }
}