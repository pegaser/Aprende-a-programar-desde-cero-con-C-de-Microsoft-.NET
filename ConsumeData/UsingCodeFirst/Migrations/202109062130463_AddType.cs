namespace UsingCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "Type");
        }
    }
}
