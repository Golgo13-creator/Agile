using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{
    public enum ShowGenre { Horror=1, Drama, Comedy, 
        SciFi, Action, Anime, 
        Crime, Docuseries, 
        International, K_dramas, Kids,
        LGBTQ, Mysteries, Reality,
        Romance, Science, Spanish,
        Stand_Up, Teen, Thriller}
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public ShowGenre Genre { get; set; }

        public double Rating { get; set; }
    }
}
