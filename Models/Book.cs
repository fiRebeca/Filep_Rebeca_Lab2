using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Filep_Rebeca_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string? Title { get; set; }
        public string? AuthorID { get; set; }
        public Author? Author { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } 
    }
}
