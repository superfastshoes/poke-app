namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActuallyPopulatePokemonDecks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PokemonDecks (Pokemons, Trainers, Energies) VALUES (20, 20, 20)");
            Sql("INSERT INTO PokemonDecks (Pokemons, Trainers, Energies) VALUES (15, 25, 20)");
            Sql("INSERT INTO PokemonDecks (Pokemons, Trainers, Energies) VALUES (15, 30, 15)");
            Sql("INSERT INTO PokemonDecks (Pokemons, Trainers, Energies) VALUES (20, 30, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
