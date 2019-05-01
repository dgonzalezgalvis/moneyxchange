namespace MoneyXchange.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exchanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        currency = c.String(),
                        factor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exchanges");
        }
    }
}
