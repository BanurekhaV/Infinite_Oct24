namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.tblBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Price = c.Double(nullable: false),
                        YearPublished = c.DateTime(nullable: false),
                        Author_AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorId)
                .Index(t => t.Author_AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBooks", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.tblBooks", new[] { "Author_AuthorId" });
            DropTable("dbo.tblBooks");
            DropTable("dbo.Authors");
        }
    }
}
