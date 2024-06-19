namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInScheduleDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "Status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "Status", c => c.String());
        }
    }
}
