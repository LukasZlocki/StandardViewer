using System.ComponentModel.DataAnnotations;

namespace StandardViewer.Data.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string ProductNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string DocumentName { get; set; }
    }
}