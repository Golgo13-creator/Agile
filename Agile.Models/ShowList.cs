using Agile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Models
{
    public class ShowList
    {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ShowGenre Genre { get; set; }
        public double Rating { get; set; }
    }
}
