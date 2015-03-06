namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondDataMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Type", c => c.String());
            DropColumn("dbo.Services", "File");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "File", c => c.String());
            DropColumn("dbo.Services", "Type");
        }
    }
}
