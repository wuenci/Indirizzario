namespace Indirizzario.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRegion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Address", "Regione", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Address", "Regione");
        }
    }
}
