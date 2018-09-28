namespace ProjectDemoLatest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Booking_Id = c.Int(nullable: false, identity: true),
                        Booking_Date = c.DateTime(nullable: false),
                        CheckIn_Date = c.DateTime(nullable: false),
                        Checkout_Date = c.DateTime(nullable: false),
                        Booking_Amount = c.Int(nullable: false),
                        Discount_Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Booking_Id);
            
            CreateTable(
                "dbo.City_Details",
                c => new
                    {
                        City_Id = c.Int(nullable: false, identity: true),
                        City_Name = c.String(),
                    })
                .PrimaryKey(t => t.City_Id);
            
            CreateTable(
                "dbo.Hotel_City_Mapping",
                c => new
                    {
                        Mapping_Id = c.Int(nullable: false, identity: true),
                        Hot_Id = c.Int(nullable: false),
                        City_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Mapping_Id)
                .ForeignKey("dbo.City_Details", t => t.City_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hotel_Details", t => t.Hot_Id, cascadeDelete: true)
                .Index(t => t.Hot_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Hotel_Details",
                c => new
                    {
                        Hot_Id = c.Int(nullable: false, identity: true),
                        Hot_Name = c.String(),
                        Hot_Add = c.String(),
                        Total_Room = c.Int(nullable: false),
                        Hotel_Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Hot_Id);
            
            CreateTable(
                "dbo.Room_Booking_Details",
                c => new
                    {
                        RoomBooking_Id = c.Int(nullable: false, identity: true),
                        Room_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomBooking_Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id, cascadeDelete: true)
                .ForeignKey("dbo.Room_Details", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Room_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.Room_Details",
                c => new
                    {
                        Room_Id = c.Int(nullable: false, identity: true),
                        Room_Type = c.String(),
                        Hot_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Room_Id)
                .ForeignKey("dbo.Hotel_Details", t => t.Hot_Id, cascadeDelete: true)
                .Index(t => t.Hot_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Room_Booking_Details", "Room_Id", "dbo.Room_Details");
            DropForeignKey("dbo.Room_Details", "Hot_Id", "dbo.Hotel_Details");
            DropForeignKey("dbo.Room_Booking_Details", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.Hotel_City_Mapping", "Hot_Id", "dbo.Hotel_Details");
            DropForeignKey("dbo.Hotel_City_Mapping", "City_Id", "dbo.City_Details");
            DropIndex("dbo.Room_Details", new[] { "Hot_Id" });
            DropIndex("dbo.Room_Booking_Details", new[] { "Booking_Id" });
            DropIndex("dbo.Room_Booking_Details", new[] { "Room_Id" });
            DropIndex("dbo.Hotel_City_Mapping", new[] { "City_Id" });
            DropIndex("dbo.Hotel_City_Mapping", new[] { "Hot_Id" });
            DropTable("dbo.Room_Details");
            DropTable("dbo.Room_Booking_Details");
            DropTable("dbo.Hotel_Details");
            DropTable("dbo.Hotel_City_Mapping");
            DropTable("dbo.City_Details");
            DropTable("dbo.Bookings");
        }
    }
}
