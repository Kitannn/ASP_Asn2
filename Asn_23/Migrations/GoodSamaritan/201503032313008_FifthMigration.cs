namespace Asn_23.Migrations.GoodSamaritan
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbuserRelationships", "Relationship", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AbuserRelationships", "Relationship", c => c.String(maxLength: 50));
        }
    }
}
