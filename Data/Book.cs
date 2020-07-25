using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Author { get; set; }

        [MaxLength(50)]
        public string Place { get; set; }

        public bool Given { get; set; } = false;

        [MaxLength(50)]
        public string GivenTo { get; set; }
    }
}
