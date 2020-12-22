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
    public partial class Form1Masa : Form
    {
        public Form1Masa()
        {
            InitializeComponent();
        }
        Masa masa = new Masa();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnlistele_Click(object sender, EventArgs e)
        {
            masa.fiyat = nudfiyat.Value;
            masa.malzeme = txtmalzeme.Text;
            masa.renk = txtrenk.Text;
            masa.sekil = txtsekil.Text;

            string format = string.Format("Malzeme:{0} ,Şekil:{1} , renk:{2} , fiyat:{3} ", masa.malzeme,masa.sekil,masa.renk,masa.fiyat);
            listBox1.Items.Add(format);
        }
    }
}
