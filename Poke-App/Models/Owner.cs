using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poke_App.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public DateTime? Birthdate { get; set; }
        public bool HasPokemonDeck { get; set; }

        // Navigation Property. Useful when you want to load an object and its related object from the database.
        public PokemonDeck PokemonDeck { get; set; }
        // Foreign Key
        public int PokemonDeckId { get; set; }
    }
}