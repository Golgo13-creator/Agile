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
        public string Title { get; set; }
        public string Description { get; set; }
        public GenreType Genre { get; set; }
        [ForeignKey]
        public double AverageRating { get; set; }
        public virtual List<Rating> Ratings { get; set; }
    }
}
