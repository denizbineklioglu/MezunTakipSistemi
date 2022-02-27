namespace MezunTakipSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        MezunOlduguBolum = c.String(),
                        Sifre = c.String(),
                        SifreTekrari = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        DogumYeri = c.String(),
                        Cinsiyet = c.String(),
                        Uyruk = c.String(),
                        MedeniDurum = c.String(),
                        CepNo = c.String(),
                        Adres = c.String(),
                        LinkedinAdresi = c.String(),
                    })
                .PrimaryKey(t => t.OgrenciID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ogrenci");
        }
    }
}
