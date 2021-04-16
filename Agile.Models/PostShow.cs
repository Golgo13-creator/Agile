using Agile.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Models
{
    public class PostShow
    {
        [Required]
        [MinLength(1, ErrorMessage ="Title is too short.")]
        [MaxLength(120, ErrorMessage ="Title is too long")]
        public string Title { get; set; }
        [MaxLength (5000)]
        public string Description { get; set; }
        public ShowGenre Genre { get; set; }
    }
}
