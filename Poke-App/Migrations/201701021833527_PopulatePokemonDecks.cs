namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePokemonDecks : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PokemonDecks", "Pokemons", c => c.Int(nullable: false));
            AlterColumn("dbo.PokemonDecks", "Trainers", c => c.Int(nullable: false));
            AlterColumn("dbo.PokemonDecks", "Energies", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PokemonDecks", "Energies", c => c.Short(nullable: false));
            AlterColumn("dbo.PokemonDecks", "Trainers", c => c.Short(nullable: false));
            AlterColumn("dbo.PokemonDecks", "Pokemons", c => c.Short(nullable: false));
        }
    }
}
