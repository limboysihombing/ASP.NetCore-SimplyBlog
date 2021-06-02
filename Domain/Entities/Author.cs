using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Domain.Entities
{
    public partial class Author
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Role { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        public List<Book> Book { get; set; }
    }
}
