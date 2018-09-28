namespace EventsDropdown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _event : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        eventId = c.Int(nullable: false, identity: true),
                        eventName = c.String(),
                        participantName = c.String(),
                    })
                .PrimaryKey(t => t.eventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
