using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; private set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name length will be between 1 and 50 symbols")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        public Cover Cover { get; set; }
        [Range(1, 6000, ErrorMessage = "Number of pages is incorrect")]
        public int Pages { get; set; }
    }
}