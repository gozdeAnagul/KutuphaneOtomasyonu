using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    public class YazarBusiness
    {
        public void YazarDoldur(YazarViewModel yazar)
        {
            MyContext db = new MyContext();
            
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniYazar = new Yazar()
                    {
                        YazarAdi = yazar.YazarAdi,
                        YazarSoyadi = yazar.YazarSoyadi
                    };
                    db.Yazarlar.Add(yeniYazar);
                    db.SaveChanges();

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
