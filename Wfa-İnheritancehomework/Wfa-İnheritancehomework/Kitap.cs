using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_İnheritancehomework
{
    public class Kitap : Ürün
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public int BasimTarihi { get; set; }
        public string Yayınevi { get; set; }
        public string KapakTuru { get; set; }
    }
}
