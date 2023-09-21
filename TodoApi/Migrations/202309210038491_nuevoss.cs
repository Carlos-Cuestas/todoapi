namespace TodoApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevoss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "Responsable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TodoItems", "Responsable");
        }
    }
}
