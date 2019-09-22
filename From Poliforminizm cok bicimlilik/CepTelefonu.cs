using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Poliforminizm_cok_bicimlilik
{
    public class CepTelefonu:URUN
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public CepTelefonu(string ad,double fiyat,string marka)
        {
            urunadi = ad;
            Fiyat = fiyat;
            Marka = marka;
        }
    }
}
