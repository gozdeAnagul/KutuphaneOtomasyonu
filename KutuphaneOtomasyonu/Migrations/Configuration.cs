namespace KutuphaneOtomasyonu.Migrations
{
    using KutuphaneOtomasyonu.Data;
    using KutuphaneOtomasyonu.ViewModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KutuphaneOtomasyonu.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KutuphaneOtomasyonu.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var db = context;
            FData fData = new FData();
            if (!db.Yazarlar.Any())
            {
                foreach (var item in fData.Yazarlar)
                {
                    db.Yazarlar.Add(item);
                }
                db.SaveChanges();
            }

            if (!db.Kitaplar.Any())
            {
                var yazarlar = db.Yazarlar.ToList();
                Random rnd = new Random();
                foreach (var item in fData.Kitaplar)
                {
                    item.YazarID = yazarlar[rnd.Next(0, yazarlar.Count)].YazarID;
                    db.Kitaplar.Add(item);
                }
                db.SaveChanges();
                
            }

            if (!db.Uyeler.Any())
            {
                foreach (var item in fData.Uyeler)
                {
                    db.Uyeler.Add(item);
                }
                db.SaveChanges();
            }

        }
    }
}
