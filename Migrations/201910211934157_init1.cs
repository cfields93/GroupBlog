namespace GroupBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Body", c => c.String());
            AlterColumn("dbo.Blogs", "Title", c => c.String());
        }
    }
}
