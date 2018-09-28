namespace CosmeticStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class favorit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        fid = c.Int(nullable: false, identity: true),
                        cid = c.Int(nullable: false),
                        uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.fid)
                .ForeignKey("dbo.Addcosmetics", t => t.cid, cascadeDelete: true)
                .ForeignKey("dbo.Addusers", t => t.uid, cascadeDelete: true)
                .Index(t => t.cid)
                .Index(t => t.uid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "uid", "dbo.Addusers");
            DropForeignKey("dbo.Favorites", "cid", "dbo.Addcosmetics");
            DropIndex("dbo.Favorites", new[] { "uid" });
            DropIndex("dbo.Favorites", new[] { "cid" });
            DropTable("dbo.Favorites");
        }
    }
}
