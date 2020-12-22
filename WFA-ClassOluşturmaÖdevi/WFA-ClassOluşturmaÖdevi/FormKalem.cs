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
    public partial class FormKalem : Form
    {
        public FormKalem()
        {
            InitializeComponent();
        }
        Kalem kalem = new Kalem();
        string yazıTipi = "";
        private void btnlistele_Click(object sender, EventArgs e)
        {
            kalem.marka = txtmarka.Text;
            kalem.renk = txtrenk.Text;
            kalem.fiyat = nudfiyat.Value;
            if (rbuclu.Checked)
            {
                yazıTipi = "Uçlu";
            }
            if (rbtükenmez.Checked)
            {
                yazıTipi = "Tükenmez";
            }
            string format = string.Format("Marka:{0},Renk:{1},fiyat:{2},Yazı Tipi:{3}", kalem.marka, kalem.renk, kalem.fiyat, yazıTipi);
            listBox1.Items.Add(format);
        }
    }
}
