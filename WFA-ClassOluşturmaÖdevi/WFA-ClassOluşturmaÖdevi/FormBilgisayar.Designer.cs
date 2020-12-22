
namespace WFA_ClassOluşturmaÖdevi
{
    partial class FormBilgisayar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.rb16gbram = new System.Windows.Forms.RadioButton();
            this.rb8gbram = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "marka";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(196, 218);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 16;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // rb16gbram
            // 
            this.rb16gbram.AutoSize = true;
            this.rb16gbram.Location = new System.Drawing.Point(262, 160);
            this.rb16gbram.Name = "rb16gbram";
            this.rb16gbram.Size = new System.Drawing.Size(72, 17);
            this.rb16gbram.TabIndex = 15;
            this.rb16gbram.TabStop = true;
            this.rb16gbram.Text = "16 gb ram";
            this.rb16gbram.UseVisualStyleBackColor = true;
            // 
            // rb8gbram
            // 
            this.rb8gbram.AutoSize = true;
            this.rb8gbram.Location = new System.Drawing.Point(171, 160);
            this.rb8gbram.Name = "rb8gbram";
            this.rb8gbram.Size = new System.Drawing.Size(66, 17);
            this.rb8gbram.TabIndex = 14;
            this.rb8gbram.TabStop = true;
            this.rb8gbram.Text = "8 gb ram";
            this.rb8gbram.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bilgisayar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(433, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 277);
            this.listBox1.TabIndex = 11;
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(171, 123);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 19;
            // 
            // FormBilgisayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.rb16gbram);
            this.Controls.Add(this.rb8gbram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormBilgisayar";
            this.Text = "FormBilgisayar";
            this.Load += new System.EventHandler(this.FormBilgisayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.RadioButton rb16gbram;
        private System.Windows.Forms.RadioButton rb8gbram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbmarka;
    }
}