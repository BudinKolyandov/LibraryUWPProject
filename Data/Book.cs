using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Author { get; set; }

        [Required]
        [MaxLength(50)]
        public string Place { get; set; }

        public bool Given { get; set; }

        [MaxLength(50)]
        public string GivenTo { get; set; }

    }
}
