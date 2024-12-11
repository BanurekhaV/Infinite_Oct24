namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColaddedtoAuthors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "PublisherName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "PublisherName");
        }
    }
}
