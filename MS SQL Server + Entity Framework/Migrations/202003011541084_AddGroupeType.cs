namespace MS_SQL_Server___Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Songs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Songs", "Name", c => c.Int(nullable: false));
        }
    }
}
