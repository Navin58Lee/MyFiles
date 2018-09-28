namespace Dummy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class example : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Examples",
                c => new
                    {
                        eid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        checkIn = c.DateTime(nullable: false),
                        checkOut = c.DateTime(nullable: false),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Examples");
        }
    }
}
