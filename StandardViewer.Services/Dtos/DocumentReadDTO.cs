using System.ComponentModel.DataAnnotations;

namespace StandardViewer.Services.Dtos
{
    public class DocumentReadDTO
    {
        [Required]
        [MaxLength(10)]
        public string ProductNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string DocumentName { get; set; }
    }
}