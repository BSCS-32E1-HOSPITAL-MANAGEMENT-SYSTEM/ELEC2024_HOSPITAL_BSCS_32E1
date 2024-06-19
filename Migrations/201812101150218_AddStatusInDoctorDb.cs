namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusInDoctorDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Status");
        }
    }
}
