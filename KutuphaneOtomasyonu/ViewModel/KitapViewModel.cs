using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModel
{
    public class KitapViewModel
    {
        public int  KitapID { get; set; }
        public string KitapAdi { get; set; }
        public Yazar Yazar { get; set; }
        public short Stok { get; set; }

        public override string ToString() => $"{Yazar.YazarAdi} {Yazar.YazarSoyadi}-{KitapAdi}-{Stok}";
    }
}
