namespace Dummy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Examples", "checkIn");
            DropColumn("dbo.Examples", "checkOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Examples", "checkOut", c => c.DateTime(nullable: false));
            AddColumn("dbo.Examples", "checkIn", c => c.DateTime(nullable: false));
        }
    }
}
