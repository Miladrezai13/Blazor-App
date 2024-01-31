using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace GameStore.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }=string.Empty;

        [Required]
        [StringLength(20)]
        public required string Genre { get; set; }

        [Range(1, 100)]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}