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
    public partial class FormKitap : Form
    {
        public FormKitap()
        {
            InitializeComponent();
        }

        private void FormKitap_Load(object sender, EventArgs e)
        {

        }
        Kitap kitap = new Kitap();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            kitap.ad = txtad.Text;
            kitap.yazar = txtyazar.Text;
            kitap.sayfaSayısı = nudsayfa.Value;
            kitap.fiyat = nudfiyat.Value;

            string format = string.Format("kitap adı: {0}, yazar: {1}, sayfa sayısı= {2}, fiyat= {3} tl ", kitap.ad, kitap.yazar, kitap.sayfaSayısı, kitap.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
