namespace BookLTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Discriminator");
        }
    }
}
