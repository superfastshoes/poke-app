namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedOwnersModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Owners", "Description");
            DropColumn("dbo.Owners", "CardType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Owners", "CardType", c => c.String());
            AddColumn("dbo.Owners", "Description", c => c.String());
        }
    }
}
