using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Data
{
    public enum GenreType { Horror = 1, Drama, Comedy, SciFi, Action }
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public GenreType Genre { get; set; }
      //  [ForeignKey()] //adjustment needed
        public double AverageRating { get; set; }
      //  public virtual List<Rating> Ratings { get; set; }
    }
}
