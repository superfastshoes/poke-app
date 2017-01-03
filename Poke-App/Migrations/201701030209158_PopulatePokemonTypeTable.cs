namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePokemonTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Normal')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Fighting')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Rock')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Fire')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Posion')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Ghost')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Water')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Ground')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Dragon')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Electric')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Flying')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Dark')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Grass')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Psychic')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Steel')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Ice')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Bug')");
            Sql("INSERT INTO PokemonTypes (TypeOfPokemon) VALUES ('Fairy')");
        }
        
        public override void Down()
        {
        }
    }
}
