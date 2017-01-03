namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPokemonDeckModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PokemonDecks", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PokemonDecks", "Name");
        }
    }
}
