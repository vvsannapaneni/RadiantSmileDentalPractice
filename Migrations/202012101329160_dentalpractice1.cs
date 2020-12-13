namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dentalpractice1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Email", c => c.String());
            AddColumn("dbo.Patients", "MedicalHistory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "MedicalHistory");
            DropColumn("dbo.Patients", "Email");
        }
    }
}
