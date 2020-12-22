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
    public partial class FormBilgisayar : Form
    {
        public FormBilgisayar()
        {
            InitializeComponent();
        }

        private void FormBilgisayar_Load(object sender, EventArgs e)
        {
            string[] bilgisayarlar = { "Lenovo", "HP", "Asus" };
            foreach (string item in bilgisayarlar)
            {
                cmbmarka.Items.Add(item);
            }
        }
        Bilgisayar bilgisayar = new Bilgisayar();
        string harddisk = "";
        private void btnlistele_Click(object sender, EventArgs e)
        {
            bilgisayar.marka = cmbmarka.Text;
            if (rb8gbram.Checked)
            {
                bilgisayar.ram = 8;
                rb16gbram.Visible = true;
            }
            else if (rb16gbram.Checked)
            {
                bilgisayar.ram = 16;
                rb8gbram.Visible = false;
            }

            bilgisayar.hardDisk =Convert.ToInt32(harddisk) ;
            string format = string.Format("marka {0} , ram {1} gb ", bilgisayar.marka, bilgisayar.ram);
            listBox1.Items.Add(format);
        }


    }
}
