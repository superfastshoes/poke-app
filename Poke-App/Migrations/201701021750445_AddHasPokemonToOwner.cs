namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHasPokemonToOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Owners", "HasPokemonDeck", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Owners", "HasPokemonDeck");
        }
    }
}
