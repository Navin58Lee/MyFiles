namespace ProjectDemoLatest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.User_Id);
            
            AddColumn("dbo.Room_Booking_Details", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Room_Booking_Details", "User_Id");
            AddForeignKey("dbo.Room_Booking_Details", "User_Id", "dbo.UserDetails", "User_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Room_Booking_Details", "User_Id", "dbo.UserDetails");
            DropIndex("dbo.Room_Booking_Details", new[] { "User_Id" });
            DropColumn("dbo.Room_Booking_Details", "User_Id");
            DropTable("dbo.UserDetails");
        }
    }
}
