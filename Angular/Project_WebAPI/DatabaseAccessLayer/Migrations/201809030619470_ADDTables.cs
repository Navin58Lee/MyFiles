namespace DatabaseAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booking",
                c => new
                    {
                        bookingId = c.Int(nullable: false, identity: true),
                        bookingDate = c.DateTime(nullable: false),
                        checkInDate = c.DateTime(nullable: false),
                        checkOutDate = c.DateTime(nullable: false),
                        bookingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        discountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                "dbo.HotelCityMapping",
                c => new
                    {
                        mapId = c.Int(nullable: false, identity: true),
                        hotelId = c.Int(nullable: false),
                        cityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mapId)
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
                        hotelAddress = c.String(),
                        totalRooms = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.hotelId);
            
            CreateTable(
                "dbo.RoomBookingDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        roomId = c.Int(nullable: false),
                        bookingId = c.Int(nullable: false),
                        Uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booking", t => t.bookingId, cascadeDelete: true)
                .ForeignKey("dbo.RoomDetails", t => t.roomId, cascadeDelete: true)
                .ForeignKey("dbo.UserDetails", t => t.Uid, cascadeDelete: true)
                .Index(t => t.roomId)
                .Index(t => t.bookingId)
                .Index(t => t.Uid);
            
            CreateTable(
                "dbo.RoomDetails",
                c => new
                    {
                        roomId = c.Int(nullable: false, identity: true),
                        roomNumber = c.Int(nullable: false),
                        roomType = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        starRating = c.Int(nullable: false),
                        imageUrl = c.String(),
                        hotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.roomId)
                .ForeignKey("dbo.HotelDetails", t => t.hotelId, cascadeDelete: true)
                .Index(t => t.hotelId);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Uid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(maxLength: 40),
                        Password = c.String(),
                        UserName = c.String(maxLength: 450),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Mobile_no = c.String(),
                        RewardPoints = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Uid)
                .Index(t => t.Email, unique: true)
                .Index(t => t.UserName, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomBookingDetails", "Uid", "dbo.UserDetails");
            DropForeignKey("dbo.RoomBookingDetails", "roomId", "dbo.RoomDetails");
            DropForeignKey("dbo.RoomDetails", "hotelId", "dbo.HotelDetails");
            DropForeignKey("dbo.RoomBookingDetails", "bookingId", "dbo.Booking");
            DropForeignKey("dbo.HotelCityMapping", "hotelId", "dbo.HotelDetails");
            DropForeignKey("dbo.HotelCityMapping", "cityId", "dbo.CityDetails");
            DropIndex("dbo.UserDetails", new[] { "UserName" });
            DropIndex("dbo.UserDetails", new[] { "Email" });
            DropIndex("dbo.RoomDetails", new[] { "hotelId" });
            DropIndex("dbo.RoomBookingDetails", new[] { "Uid" });
            DropIndex("dbo.RoomBookingDetails", new[] { "bookingId" });
            DropIndex("dbo.RoomBookingDetails", new[] { "roomId" });
            DropIndex("dbo.HotelCityMapping", new[] { "cityId" });
            DropIndex("dbo.HotelCityMapping", new[] { "hotelId" });
            DropTable("dbo.UserDetails");
            DropTable("dbo.RoomDetails");
            DropTable("dbo.RoomBookingDetails");
            DropTable("dbo.HotelDetails");
            DropTable("dbo.HotelCityMapping");
            DropTable("dbo.CityDetails");
            DropTable("dbo.Booking");
        }
    }
}
