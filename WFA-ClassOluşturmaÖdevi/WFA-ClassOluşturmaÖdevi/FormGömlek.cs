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
    public partial class FormGömlek : Form
    {
        public FormGömlek()
        {
            InitializeComponent();
        }
        Gomlek gomlek = new Gomlek();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            gomlek.marka = txtmarka.Text;
            gomlek.renk = txtrenk.Text;
            gomlek.desen = txtdesen.Text;
            gomlek.fiyat = nudfiyat.Value;
            string format = string.Format("marka:{0}, renk:{1} , desen:{2}, fiyat:{3}", gomlek.marka, gomlek.renk, gomlek.desen, gomlek.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
