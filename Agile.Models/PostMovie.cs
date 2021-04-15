using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Models
{
    public class PostMovie
    {
        [Required]
        [MaxLength(120, ErrorMessage = "There are too many characters in this title field")]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string Description { get; set; }
        public GenreType Genre { get; set; }
        public double AverageRating { get; set; }
        // public virtual List<Rating> Ratings { get; set; }
    }
}
