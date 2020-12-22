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
    public partial class FormTop : Form
    {
        public FormTop()
        {
            InitializeComponent();
        }
        Top top = new Top();
        private void FormTop_Load(object sender, EventArgs e)
        {
            string[] markalar = { "Nike", "Adidas", "Puma" };
            string[] türler = { "Futbol", "Voleybol", "Basketbol" };
            foreach (string marka in markalar)
            {
                cmbmarka.Items.Add(marka);
            }
            foreach (string tur in türler)
            {
                cmbtür.Items.Add(tur);
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            top.marka = cmbmarka.Text;
            top.tür = cmbtür.Text;
            top.renk = txtfiyat.Text;
            top.fiyat = nudfiyat.Value;
            string format = string.Format("marka: {0}, tür: {1}, renk:{2}, fiyat:{3} tl ", top.marka, top.tür, top.renk, top.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
