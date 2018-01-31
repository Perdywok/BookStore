using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Author
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public Book Books { get; set; }

    }
}