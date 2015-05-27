namespace ZooKeeper.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zookeepers", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zookeepers", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
