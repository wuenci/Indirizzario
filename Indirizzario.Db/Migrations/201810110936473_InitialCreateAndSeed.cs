namespace Indirizzario.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateAndSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(maxLength: 150),
                        Postcode = c.String(nullable: false, maxLength: 10),
                        Town = c.String(nullable: false, maxLength: 150),
                        State = c.String(),
                        Country = c.String(nullable: false, maxLength: 150),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "PersonId", "dbo.Person");
            DropIndex("dbo.Address", new[] { "PersonId" });
            DropTable("dbo.Person");
            DropTable("dbo.Address");
        }
    }
}
