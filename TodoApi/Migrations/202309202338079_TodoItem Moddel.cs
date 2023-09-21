﻿namespace TodoApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TodoItemModdel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarea = c.String(),
                        Completo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoItems");
        }
    }
}
