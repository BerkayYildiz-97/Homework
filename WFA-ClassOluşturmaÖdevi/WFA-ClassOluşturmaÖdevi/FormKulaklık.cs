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
    public partial class FormKulaklık : Form
    {
        public FormKulaklık()
        {
            InitializeComponent();
        }
        Kulaklık kulaklik = new Kulaklık();
        string kabloluMu="";
        private void btnlistele_Click(object sender, EventArgs e)
        {
            kulaklik.db = nuddb.Value;
            kulaklik.fiyat = nudfiyat.Value;
            kulaklik.marka = txtmarka.Text;
            kulaklik.renk = txtrenk.Text;

            if (rbbluetooth.Checked)
            {
                kulaklik.kablosuzMu = true;
                kabloluMu = "Bluetooth";
            }
            if (rbkablolu.Checked)
            {
                kulaklik.kablosuzMu = false;
                kabloluMu = "Kablolu";
            }
            string format = string.Format("marka: {0} , renk:{1} , db:{2}, fiyat: {3} ,kablolu mu:{4} ", kulaklik.marka, kulaklik.renk, kulaklik.db,kulaklik.fiyat, kabloluMu);
            listBox1.Items.Add(format);
        }
    }
}
