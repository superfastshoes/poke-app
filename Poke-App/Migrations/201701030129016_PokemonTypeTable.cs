namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PokemonTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pokemons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        HitPoints = c.String(),
                        Stage = c.String(),
                        AttackDetails = c.String(),
                        Weakness = c.String(),
                        Resistance = c.String(),
                        Retreat = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pokemons");
        }
    }
}
