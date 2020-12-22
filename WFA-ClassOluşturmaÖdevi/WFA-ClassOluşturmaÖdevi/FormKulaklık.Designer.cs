
namespace WFA_ClassOluşturmaÖdevi
{
    partial class FormKulaklık
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
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.nuddb = new System.Windows.Forms.NumericUpDown();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.rbkablolu = new System.Windows.Forms.RadioButton();
            this.rbbluetooth = new System.Windows.Forms.RadioButton();
            this.btnlistele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuddb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(119, 54);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 0;
            // 
            // nuddb
            // 
            this.nuddb.Location = new System.Drawing.Point(119, 135);
            this.nuddb.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuddb.Name = "nuddb";
            this.nuddb.Size = new System.Drawing.Size(120, 20);
            this.nuddb.TabIndex = 1;
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(119, 83);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(100, 20);
            this.txtrenk.TabIndex = 2;
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(119, 109);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 20);
            this.nudfiyat.TabIndex = 3;
            // 
            // rbkablolu
            // 
            this.rbkablolu.AutoSize = true;
            this.rbkablolu.Location = new System.Drawing.Point(119, 171);
            this.rbkablolu.Name = "rbkablolu";
            this.rbkablolu.Size = new System.Drawing.Size(60, 17);
            this.rbkablolu.TabIndex = 4;
            this.rbkablolu.TabStop = true;
            this.rbkablolu.Text = "Kablolu";
            this.rbkablolu.UseVisualStyleBackColor = true;
            // 
            // rbbluetooth
            // 
            this.rbbluetooth.AutoSize = true;
            this.rbbluetooth.Location = new System.Drawing.Point(210, 171);
            this.rbbluetooth.Name = "rbbluetooth";
            this.rbbluetooth.Size = new System.Drawing.Size(70, 17);
            this.rbbluetooth.TabIndex = 5;
            this.rbbluetooth.TabStop = true;
            this.rbbluetooth.Text = "Bluetooth";
            this.rbbluetooth.UseVisualStyleBackColor = true;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(119, 211);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 6;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(343, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(391, 264);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "db";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "fiyat";
            // 
            // FormKulaklık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.rbbluetooth);
            this.Controls.Add(this.rbkablolu);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.nuddb);
            this.Controls.Add(this.txtmarka);
            this.Name = "FormKulaklık";
            this.Text = "FormKulaklık";
            ((System.ComponentModel.ISupportInitialize)(this.nuddb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.NumericUpDown nuddb;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.RadioButton rbkablolu;
        private System.Windows.Forms.RadioButton rbbluetooth;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}