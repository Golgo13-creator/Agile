using Agile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Models
{
    public class MovieDetail
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public GenreType Genre { get; set; }
        public double AverageRating { get; set; }
    }
}
