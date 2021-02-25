namespace BookLTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetOptiontalColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "DateDeath", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "DateDeath", c => c.DateTime(nullable: false));
        }
    }
}
