using KutuphaneOtomasyonu.Business;
using KutuphaneOtomasyonu.ViewModel;
using KutuphaneOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneOtomasyonu.Data
{

    public class FData
    {
        public MyContext MyContext { get; set; }

        public FData()
        {
            MyContext = new MyContext();
            for (int i = 0; i < 30; i++)
            {
                var yazarBussiness = new YazarBusiness();
                var yazar = new YazarViewModel()
                {
                    YazarAdi = FakeData.NameData.GetFirstName(),
                    YazarSoyadi = FakeData.NameData.GetSurname(),
                };
                yazarBussiness.YazarDoldur(yazar);
            }

            for (int i = 0; i < 30; i++)
            {
                var uyeBusiness = new UyeBusiness();
                var uye = new UyeViewModel()
                {
                    UyeAdi = FakeData.NameData.GetFirstName(),
                    UyeSoyadi = FakeData.NameData.GetSurname(),
                    UyeTCKN = FakeData.TextData.GetNumeric(11),
                    UyeTelefon = "05" + FakeData.TextData.GetNumeric(9)
                };
                uye.UyeEMail = (uye.UyeAdi + "." + uye.UyeSoyadi + "@mail.com").ToLower();
                uyeBusiness.UyeDoldur(uye);

            }
            for (int i = 0; i < 30; i++)
            {
                MyContext.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = FakeData.TextData.GetSentence(),
                    Stok = (short)FakeData.NumberData.GetNumber(1, 10)
                });
            }
        }
    }
}
