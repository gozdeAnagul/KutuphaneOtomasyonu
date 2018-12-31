namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiraDetaylar",
                c => new
                    {
                        KiraDetayId = c.Int(nullable: false, identity: true),
                        KiraID = c.Int(nullable: false),
                        KiralananGun = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.KiraDetayId)
                .ForeignKey("dbo.Kiralananlar", t => t.KiraID, cascadeDelete: true)
                .Index(t => t.KiraID);
            
            CreateTable(
                "dbo.Kiralananlar",
                c => new
                    {
                        KiraID = c.Int(nullable: false, identity: true),
                        UyeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KiraID)
                .ForeignKey("dbo.Uyeler", t => t.UyeID, cascadeDelete: true)
                .Index(t => t.UyeID);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapID = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 50),
                        YazarID = c.Int(nullable: false),
                        Stok = c.Short(nullable: false),
                        Kiralanan_KiraID = c.Int(),
                    })
                .PrimaryKey(t => t.KitapID)
                .ForeignKey("dbo.Yazarlar", t => t.YazarID, cascadeDelete: true)
                .ForeignKey("dbo.Kiralananlar", t => t.Kiralanan_KiraID)
                .Index(t => t.YazarID)
                .Index(t => t.Kiralanan_KiraID);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarID = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(nullable: false, maxLength: 20),
                        YazarSoyadi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.YazarID);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeID = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false, maxLength: 20),
                        UyeSoyadi = c.String(nullable: false, maxLength: 20),
                        UyeTCKN = c.String(nullable: false, maxLength: 11),
                        UyeTelefon = c.String(maxLength: 11),
                        UyeEMail = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.UyeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiraDetaylar", "KiraID", "dbo.Kiralananlar");
            DropForeignKey("dbo.Kiralananlar", "UyeID", "dbo.Uyeler");
            DropForeignKey("dbo.Kitaplar", "Kiralanan_KiraID", "dbo.Kiralananlar");
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "Kiralanan_KiraID" });
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            DropIndex("dbo.Kiralananlar", new[] { "UyeID" });
            DropIndex("dbo.KiraDetaylar", new[] { "KiraID" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kiralananlar");
            DropTable("dbo.KiraDetaylar");
        }
    }
}
