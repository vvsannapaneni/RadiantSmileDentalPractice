namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patient1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "LastVisitedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "LastVisitedDate"); 
        }
    }
}
