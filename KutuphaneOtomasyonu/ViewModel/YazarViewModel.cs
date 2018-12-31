using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModel
{
    public class YazarViewModel
    {
        public int YazarID { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public override string ToString() => $"{YazarAdi} {YazarSoyadi}";
       
    }
}
