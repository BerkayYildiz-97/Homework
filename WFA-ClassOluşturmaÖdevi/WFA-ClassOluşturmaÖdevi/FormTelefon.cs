using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ClassOluşturmaÖdevi
{
    public partial class FormTelefon : Form
    {
        public FormTelefon()
        {
            InitializeComponent();
        }

        private void FormTelefon_Load(object sender, EventArgs e)
        {
            label2.Text = "mAh ve inç varsayılan olarak listelenecektir.";
        }
        Telefon telefon = new Telefon();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            telefon.inç = 12;
            telefon.mAh = 3600;
            telefon.marka = txtmarka.Text;
            if (rb8gbram.Checked==true)
            {
                telefon.ram = 8;
            }
            else if (rb12gbram.Checked==true)
            {
                telefon.ram = 12;
            }
           
            string format = string.Format("marka {0}, ram {1} gb , mAh {2} , inç {3}", telefon.marka, telefon.ram, telefon.mAh, telefon.inç);
            listBox1.Items.Add(format);
        }
    }
}
