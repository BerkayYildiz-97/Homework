
namespace WFA_ClassOluşturmaÖdevi
{
    partial class FormTelefon
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb8gbram = new System.Windows.Forms.RadioButton();
            this.rb12gbram = new System.Windows.Forms.RadioButton();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(448, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 277);
            this.listBox1.TabIndex = 0;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(186, 69);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefon";
            // 
            // rb8gbram
            // 
            this.rb8gbram.AutoSize = true;
            this.rb8gbram.Location = new System.Drawing.Point(186, 106);
            this.rb8gbram.Name = "rb8gbram";
            this.rb8gbram.Size = new System.Drawing.Size(66, 17);
            this.rb8gbram.TabIndex = 3;
            this.rb8gbram.TabStop = true;
            this.rb8gbram.Text = "8 gb ram";
            this.rb8gbram.UseVisualStyleBackColor = true;
            // 
            // rb12gbram
            // 
            this.rb12gbram.AutoSize = true;
            this.rb12gbram.Location = new System.Drawing.Point(277, 106);
            this.rb12gbram.Name = "rb12gbram";
            this.rb12gbram.Size = new System.Drawing.Size(72, 17);
            this.rb12gbram.TabIndex = 4;
            this.rb12gbram.TabStop = true;
            this.rb12gbram.Text = "12 gb ram";
            this.rb12gbram.UseVisualStyleBackColor = true;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(211, 164);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 7;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(75, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 36);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ram";
            // 
            // FormTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.rb12gbram);
            this.Controls.Add(this.rb8gbram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.listBox1);
            this.Name = "FormTelefon";
            this.Text = "FormTelefon";
            this.Load += new System.EventHandler(this.FormTelefon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb8gbram;
        private System.Windows.Forms.RadioButton rb12gbram;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}