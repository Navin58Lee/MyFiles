namespace RoomAllocation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Room : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RID = c.Int(nullable: false),
                        BlockName = c.String(),
                        FloorNumber = c.String(),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uid = c.Int(nullable: false, identity: true),
                        MID = c.String(),
                        Name = c.String(),
                        TrackName = c.String(),
                    })
                .PrimaryKey(t => t.Uid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
        }
    }
}
