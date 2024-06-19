namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReplyInComplaintDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Complaints", "Reply", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Complaints", "Reply");
        }
    }
}
