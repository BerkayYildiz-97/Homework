using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_İnheritancehomework
{
    public class Elektronik:Ürün
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool sarjliMi { get; set; }
        public bool KabloluMu { get; set; }
        public string Renk { get; set; }
    }
}
