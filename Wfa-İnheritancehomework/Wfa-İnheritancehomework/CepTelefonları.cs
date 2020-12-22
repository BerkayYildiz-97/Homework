using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_İnheritancehomework
{
    public class CepTelefonları:Telefon
    {
        public int SarjKapasitesi { get; set; }
        public int RamKapasitesi { get; set; }
        public int Hafıza { get; set; }
        public bool SarjCihaziVarMi { get; set; }
    }
}
