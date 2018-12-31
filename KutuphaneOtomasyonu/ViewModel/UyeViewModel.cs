using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.ViewModel
{
    public class UyeViewModel
    {
        public int UyeID { get; set; }
        public string  UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeTCKN { get; set; }
        public string UyeTelefon { get; set; }
        public string UyeEMail { get; set; }

        public List<Kiralanan> Kiralananlar { get; set; }

        public override string ToString() => $"{UyeID} - {UyeAdi} {UyeSoyadi}";
       

    }
}
