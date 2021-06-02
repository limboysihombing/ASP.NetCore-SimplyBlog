using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }

    }
}