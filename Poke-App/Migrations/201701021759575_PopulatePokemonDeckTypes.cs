namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePokemonDeckTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Owners", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Owners", "Name", c => c.String());
        }
    }
}
