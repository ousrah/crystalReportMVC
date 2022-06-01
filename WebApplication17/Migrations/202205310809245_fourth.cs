namespace WebApplication17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OUVRAGE", "NUMTHEME", "dbo.THEME");
            DropIndex("dbo.OUVRAGE", new[] { "NUMTHEME" });
            CreateTable(
                "dbo.TYPEOUVR",
                c => new
                    {
                        NUMTYPEOUVR = c.Int(nullable: false),
                        LIBTYPEOUVR = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NUMTYPEOUVR);
            
            AddColumn("dbo.OUVRAGE", "NUMTYPEOUVR", c => c.Int());
            CreateIndex("dbo.OUVRAGE", "NUMTYPEOUVR");
            AddForeignKey("dbo.OUVRAGE", "NUMTYPEOUVR", "dbo.TYPEOUVR", "NUMTYPEOUVR");
            DropColumn("dbo.OUVRAGE", "NUMTHEME");
            DropTable("dbo.THEME");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.THEME",
                c => new
                    {
                        NUMTHEME = c.Int(nullable: false),
                        LIBTHEME = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NUMTHEME);
            
            AddColumn("dbo.OUVRAGE", "NUMTHEME", c => c.Int());
            DropForeignKey("dbo.OUVRAGE", "NUMTYPEOUVR", "dbo.TYPEOUVR");
            DropIndex("dbo.OUVRAGE", new[] { "NUMTYPEOUVR" });
            DropColumn("dbo.OUVRAGE", "NUMTYPEOUVR");
            DropTable("dbo.TYPEOUVR");
            CreateIndex("dbo.OUVRAGE", "NUMTHEME");
            AddForeignKey("dbo.OUVRAGE", "NUMTHEME", "dbo.THEME", "NUMTHEME");
        }
    }
}
