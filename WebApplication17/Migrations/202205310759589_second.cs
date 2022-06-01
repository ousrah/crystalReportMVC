namespace WebApplication17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CLASSIFICATION", "photo", c => c.String(maxLength: 150));
            AddColumn("dbo.ECRIVAIN", "email", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ECRIVAIN", "email");
            DropColumn("dbo.CLASSIFICATION", "photo");
        }
    }
}
