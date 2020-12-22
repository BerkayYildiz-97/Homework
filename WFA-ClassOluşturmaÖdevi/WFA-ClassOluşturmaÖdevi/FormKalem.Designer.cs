
namespace WFA_ClassOluşturmaÖdevi
{
    partial class FormKalem
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.rbtükenmez = new System.Windows.Forms.RadioButton();
            this.rbuclu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(398, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 290);
            this.listBox1.TabIndex = 0;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(165, 58);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(118, 20);
            this.txtmarka.TabIndex = 1;
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(165, 113);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 20);
            this.nudfiyat.TabIndex = 2;
            // 
            // rbtükenmez
            // 
            this.rbtükenmez.AutoSize = true;
            this.rbtükenmez.Location = new System.Drawing.Point(218, 139);
            this.rbtükenmez.Name = "rbtükenmez";
            this.rbtükenmez.Size = new System.Drawing.Size(71, 17);
            this.rbtükenmez.TabIndex = 3;
            this.rbtükenmez.TabStop = true;
            this.rbtükenmez.Text = "tükenmez";
            this.rbtükenmez.UseVisualStyleBackColor = true;
            // 
            // rbuclu
            // 
            this.rbuclu.AutoSize = true;
            this.rbuclu.Location = new System.Drawing.Point(165, 139);
            this.rbuclu.Name = "rbuclu";
            this.rbuclu.Size = new System.Drawing.Size(45, 17);
            this.rbuclu.TabIndex = 4;
            this.rbuclu.TabStop = true;
            this.rbuclu.Text = "uçlu";
            this.rbuclu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kalem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "renk";
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(165, 86);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(118, 20);
            this.txtrenk.TabIndex = 9;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(187, 175);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // FormKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbuclu);
            this.Controls.Add(this.rbtükenmez);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.listBox1);
            this.Name = "FormKalem";
            this.Text = "FormKalem";
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.RadioButton rbtükenmez;
        private System.Windows.Forms.RadioButton rbuclu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.Button btnlistele;
    }
}