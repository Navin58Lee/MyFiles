namespace RoomAllocation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Allocate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Allocates",
                c => new
                    {
                        Aid = c.Int(nullable: false, identity: true),
                        Uid = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Aid)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
                .Index(t => t.Uid, unique: true)
                .Index(t => t.RoomId, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Allocates", "Uid", "dbo.Users");
            DropForeignKey("dbo.Allocates", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Allocates", new[] { "RoomId" });
            DropIndex("dbo.Allocates", new[] { "Uid" });
            DropTable("dbo.Allocates");
        }
    }
}
