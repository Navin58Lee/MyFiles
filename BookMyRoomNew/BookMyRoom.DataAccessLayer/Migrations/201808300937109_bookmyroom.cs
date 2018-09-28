namespace BookMyRoom.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookmyroom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        bookingId = c.Int(nullable: false, identity: true),
                        bookingDate = c.DateTime(nullable: false),
                        checkinDate = c.DateTime(nullable: false),
                        checkoutDate = c.DateTime(nullable: false),
                        bookingAmount = c.Int(nullable: false),
                        discountAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bookingId);
            
            CreateTable(
                "dbo.CityDetails",
                c => new
                    {
                        cityId = c.Int(nullable: false, identity: true),
                        cityName = c.String(),
                    })
                .PrimaryKey(t => t.cityId);
            
            CreateTable(
                "dbo.HotelCityMappings",
                c => new
                    {
                        mappingId = c.Int(nullable: false, identity: true),
                        hotelId = c.Int(nullable: false),
                        cityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mappingId)
                .ForeignKey("dbo.CityDetails", t => t.cityId, cascadeDelete: true)
                .ForeignKey("dbo.HotelDetails", t => t.hotelId, cascadeDelete: true)
                .Index(t => t.hotelId)
                .Index(t => t.cityId);
            
            CreateTable(
                "dbo.HotelDetails",
                c => new
                    {
                        hotelId = c.Int(nullable: false, identity: true),
                        hotelName = c.String(),
                        hotelAdd = c.String(),
                        totalRoom = c.Int(nullable: false),
                        hotelRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.hotelId);
            
            CreateTable(
                "dbo.RoomBookingDetails",
                c => new
                    {
                        roomBookingId = c.Int(nullable: false, identity: true),
                        roomId = c.Int(nullable: false),
                        bookingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.roomBookingId)
                .ForeignKey("dbo.Bookings", t => t.bookingId, cascadeDelete: true)
                .ForeignKey("dbo.RoomDetails", t => t.roomId, cascadeDelete: true)
                .Index(t => t.roomId)
                .Index(t => t.bookingId);
            
            CreateTable(
                "dbo.RoomDetails",
                c => new
                    {
                        roomId = c.Int(nullable: false, identity: true),
                        roomType = c.String(),
                        hotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.roomId)
                .ForeignKey("dbo.HotelDetails", t => t.hotelId, cascadeDelete: true)
                .Index(t => t.hotelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomBookingDetails", "roomId", "dbo.RoomDetails");
            DropForeignKey("dbo.RoomDetails", "hotelId", "dbo.HotelDetails");
            DropForeignKey("dbo.RoomBookingDetails", "bookingId", "dbo.Bookings");
            DropForeignKey("dbo.HotelCityMappings", "hotelId", "dbo.HotelDetails");
            DropForeignKey("dbo.HotelCityMappings", "cityId", "dbo.CityDetails");
            DropIndex("dbo.RoomDetails", new[] { "hotelId" });
            DropIndex("dbo.RoomBookingDetails", new[] { "bookingId" });
            DropIndex("dbo.RoomBookingDetails", new[] { "roomId" });
            DropIndex("dbo.HotelCityMappings", new[] { "cityId" });
            DropIndex("dbo.HotelCityMappings", new[] { "hotelId" });
            DropTable("dbo.RoomDetails");
            DropTable("dbo.RoomBookingDetails");
            DropTable("dbo.HotelDetails");
            DropTable("dbo.HotelCityMappings");
            DropTable("dbo.CityDetails");
            DropTable("dbo.Bookings");
        }
    }
}
