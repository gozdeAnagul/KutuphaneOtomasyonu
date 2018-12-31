using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business
{
    public class UyeBusiness
    {
        public void UyeDoldur(UyeViewModel uye)
        {
            MyContext MyContext = new MyContext();
            using (var transaction = MyContext.Database.BeginTransaction())
            {
                try
                {
                    var yeniUye = new Uye()
                    {
                        UyeAdi = uye.UyeAdi,
                        UyeSoyadi = uye.UyeSoyadi,
                        UyeEMail=uye.UyeEMail,
                        UyeTCKN=uye.UyeTCKN,
                        UyeTelefon=uye.UyeTelefon

                    };
                    MyContext.Uyeler.Add(yeniUye);
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
