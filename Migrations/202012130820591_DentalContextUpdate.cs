namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DentalContextUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DentalServices",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        Period = c.Int(nullable: false),
                        Fee = c.Double(nullable: false),
                        NhsFee = c.Double(nullable: false),
                        PrivateFee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.PracticeStaffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StaffName = c.String(),
                        Specialization = c.Int(nullable: false),
                        SpecializationDesc = c.String(),
                        Status = c.Int(nullable: false),
                        StatusDescription = c.String(),
                        ApplyLeave = c.Boolean(nullable: false),
                        LeaveFrom = c.DateTime(),
                        LeaveTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.StaffStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        UsserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UsserId);
            
            AddColumn("dbo.Patients", "GpName", c => c.String());
            AddColumn("dbo.Patients", "GpAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "GpAddress");
            DropColumn("dbo.Patients", "GpName");
            DropTable("dbo.UserLogins");
            DropTable("dbo.StaffStatus");
            DropTable("dbo.PracticeStaffs");
            DropTable("dbo.DentalServices");
        }
    }
}
