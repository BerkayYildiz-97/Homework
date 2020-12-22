using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_İnheritancehomework
{
    public class Müzik:Ürün
    {
        public string SanatciAdi { get; set; }
        public string AlbümAdi { get; set; }
        public int CikisYili { get; set; }
        public string Dil { get; set; }
        public string Türü { get; set; }
    }
}
