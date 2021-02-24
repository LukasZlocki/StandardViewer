using System.ComponentModel.DataAnnotations;

namespace StandardViewer.Services.Dtos
{
    public class DocumentReadDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(10)]
        [Display(Name = "Numer produktu")]
        public string ProductNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Numer instrukcji")]
        public string DocumentName { get; set; }
    }
}