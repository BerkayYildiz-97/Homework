using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_İnheritancehomework
{
    public class Kamera:Elektronik
    {
        public int CekimKalitesi { get; set; }
        public double CekimFrekansAralıgı { get; set; }
        public int Hafıza { get; set; }
    }
}
