namespace CosmeticStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cosmetic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addcosmetics",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        CosmeticName = c.String(),
                        Company = c.String(),
                        Category = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.Addusers",
                c => new
                    {
                        uid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.uid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addusers");
            DropTable("dbo.Addcosmetics");
        }
    }
}
