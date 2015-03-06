namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VictimServicesAttendances",
                c => new
                    {
                        VictimServicesAttendanceId = c.Int(nullable: false, identity: true),
                        YesNoNA = c.String(),
                    })
                .PrimaryKey(t => t.VictimServicesAttendanceId);
            
            AddColumn("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", c => c.Int());
            CreateIndex("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId");
            AddForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances", "VictimServicesAttendanceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendance_VictimServicesAttendanceId" });
            DropColumn("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId");
            DropTable("dbo.VictimServicesAttendances");
        }
    }
}
