namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dentalpractice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "IsNhs", c => c.Boolean(nullable: false));
            AddColumn("dbo.Patients", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "DateOfBirth");
            DropColumn("dbo.Patients", "IsNhs");
        }
    }
}
