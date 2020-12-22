using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfa_İnheritancehomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Siir siir = new Siir();
        Roman roman = new Roman();
        Sosyoloji sosyoloji = new Sosyoloji();
        OrganizeSuc organizesuc = new OrganizeSuc();
        TürkTarihi türktarihi = new TürkTarihi();
        DünyaTarihi dünyatarihi = new DünyaTarihi();

        List<Kitap> edebiEserler = new List<Kitap>();
        List<Müzik> müzikler = new List<Müzik>();

        TurkcePop türkcepop = new TurkcePop();
        TurkceRock türkcerock = new TurkceRock();
        YabanciPop yabancipop = new YabanciPop();
        YabanciRock yabancirock = new YabanciRock();
        KaraokeYerli karaokeyerli = new KaraokeYerli();


 

        private void Form1_Load(object sender, EventArgs e)
        {
            siir.KitapAdi = "Büyük Saat";
            siir.Yazar = "Turgut Uyar";
            siir.BasimTarihi = 1982;
            siir.Yayınevi = "İş bankası yayınları";
            siir.KapakTuru = "karton kapak";
            siir.Fiyat = 25;

            roman.KitapAdi = "Akıl Oyunları";
            roman.Yazar = "Daniel Palmer";
            roman.BasimTarihi = 1975;
            roman.Yayınevi= "İş bankası yayınları";
            roman.KapakTuru = "kalın kapak";
            roman.Fiyat = 30;

            sosyoloji.KitapAdi = "Bu Ülke";
            sosyoloji.Yazar = "Cemil Meriç";
            sosyoloji.BasimTarihi = 1975;
            sosyoloji.Yayınevi = "yapıkredi yayınları";
            sosyoloji.KapakTuru = "ince kapak";
            sosyoloji.Fiyat = 20;

            organizesuc.KitapAdi = "el kaide nin sırları";
            organizesuc.Yazar = "faik bulut";
            organizesuc.BasimTarihi = 2010;
            organizesuc.Yayınevi = "cumhuriyet yayınları";
            organizesuc.KapakTuru = "karton kapak";
            organizesuc.Fiyat = 27;

            türktarihi.KitapAdi = "Atatürk ve demokratik Türkiye";
            türktarihi.Yazar = "Halil İnalcık";
            türktarihi.BasimTarihi = 1988;
            türktarihi.Yayınevi = "kolektif kitap";
            türktarihi.KapakTuru= "karton kapak";
            türktarihi.Fiyat = 38;

            dünyatarihi.KitapAdi = "Hayvanlardan Tanrılara sapiens";
            dünyatarihi.Yazar = "yuval noah narari";
            dünyatarihi.BasimTarihi = 2018;
            dünyatarihi.Yayınevi= "kolektif kitap";
            dünyatarihi.KapakTuru= "karton kapak";
            dünyatarihi.Fiyat = 38;

            edebiEserler.Add(siir);
            edebiEserler.Add(roman);
            edebiEserler.Add(sosyoloji);
            edebiEserler.Add(organizesuc);
            edebiEserler.Add(türktarihi);
            edebiEserler.Add(dünyatarihi);


            türkcepop.SanatciAdi = "yalın";
            türkcepop.AlbümAdi = "oyunbaz";
            türkcepop.CikisYili = 2020;
            türkcepop.Dil = "Türkçe";
            türkcepop.Türü = "pop";
            türkcepop.Fiyat = 30;

            türkcerock.SanatciAdi = "barış akarsu";
            türkcerock.AlbümAdi = "kimdir o";
            türkcerock.CikisYili = 2004;
            türkcerock.Dil = "Türkçe";
            türkcerock.Türü = "rock";
            türkcerock.Fiyat = 35;

            yabancipop.SanatciAdi = "dua lipa";
            yabancipop.AlbümAdi = "Break my heart";
            yabancipop.CikisYili = 2018;
            yabancipop.Dil = "ingilizce";
            yabancipop.Türü = "pop";
            yabancipop.Fiyat = 32;

            yabancirock.SanatciAdi = "scorpions";
            yabancirock.AlbümAdi = "still loving you";
            yabancirock.CikisYili = 1985;
            yabancirock.Dil = "ingilizce";
            yabancirock.Türü = "rock";
            yabancirock.Fiyat = 36;

            karaokeyerli.SanatciAdi = "duman";
            karaokeyerli.AlbümAdi = "helal olsun";
            karaokeyerli.CikisYili = 2009;
            karaokeyerli.Dil = "Türkçe";
            karaokeyerli.Türü = "rock";
            karaokeyerli.Fiyat = 15;

            müzikler.Add(türkcepop);
            müzikler.Add(türkcerock);
            müzikler.Add(yabancipop);
            müzikler.Add(yabancirock);
            müzikler.Add(karaokeyerli);


            foreach (Kitap edebiEser in edebiEserler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = edebiEser.KitapAdi;
                lvi.SubItems.Add(edebiEser.Yazar);
                lvi.SubItems.Add(edebiEser.BasimTarihi.ToString());
                lvi.SubItems.Add(edebiEser.Yayınevi);
                lvi.SubItems.Add(edebiEser.KapakTuru);
                lvi.SubItems.Add(edebiEser.Fiyat.ToString());
                lvikitaplar.Items.Add(lvi);
            }

            foreach (Müzik müzik in müzikler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = müzik.SanatciAdi;
                lvi.SubItems.Add(müzik.AlbümAdi);
                lvi.SubItems.Add(müzik.CikisYili.ToString());
                lvi.SubItems.Add(müzik.Dil);
                lvi.SubItems.Add(müzik.Türü);
                lvi.SubItems.Add(müzik.Fiyat.ToString());
                lvimüzik.Items.Add(lvi);

            }


            

        }
    }
}
