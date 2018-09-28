namespace ProjectDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Hotel_Id = c.Int(nullable: false, identity: true),
                        Hotel_Name = c.String(),
                        City = c.String(),
                        Room_Type = c.String(),
                        Price = c.Int(nullable: false),
                        Check_In = c.DateTime(nullable: false),
                        Check_Out = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Hotel_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hotels");
        }
    }
}
