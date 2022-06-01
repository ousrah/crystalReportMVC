namespace WebApplication17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ECRIVAIN", "téléphone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ECRIVAIN", "téléphone", c => c.String(maxLength: 30));
        }
    }
}
