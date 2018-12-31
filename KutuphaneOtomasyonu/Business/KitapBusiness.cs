using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    public class KitapBusiness
    {
        MyContext MyContext;
        public void KitapDoldur(KitapViewModel kitap)
        {
            MyContext = new MyContext();
            using (var transaction = MyContext.Database.BeginTransaction())
            {
                try
                {
                    var yeniKitap = new Kitap()
                    {
                        KitapAdi = kitap.KitapAdi,
                        Yazar = kitap.Yazar,
                        Stok=kitap.Stok

                    };
                    MyContext.Kitaplar.Add(yeniKitap);
                    MyContext.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
