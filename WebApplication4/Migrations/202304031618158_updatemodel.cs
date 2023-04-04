namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Usuarios", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "Email" });
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false));
        }
    }
}
