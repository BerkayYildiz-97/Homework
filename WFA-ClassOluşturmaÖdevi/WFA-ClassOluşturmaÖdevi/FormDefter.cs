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
    public partial class FormDefter : Form
    {
        public FormDefter()
        {
            InitializeComponent();
        }
        Defter defter = new Defter();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            defter.marka = txtad.Text;
            defter.yaprakSayisi = nudyaprak.Value;
            defter.fiyat = nudfiyat.Value;
            if (rbcizgili.Checked)
            {
                defter.tür = "çizgili";
            }
            else if (rbkareli.Checked)
            {
                defter.tür = "kareli";

            }
            string format = string.Format("marka:{0} ,tür:{1} ,yaprak sayısı={2}, fiyat={3} tl", defter.marka, defter.tür, defter.yaprakSayisi, defter.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
