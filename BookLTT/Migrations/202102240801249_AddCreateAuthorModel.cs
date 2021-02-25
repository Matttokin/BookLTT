namespace BookLTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreateAuthorModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
