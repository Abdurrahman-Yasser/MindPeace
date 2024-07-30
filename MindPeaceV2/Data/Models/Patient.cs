using System.ComponentModel.DataAnnotations;

namespace MindPeaceV2.Data.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? PhotoURL { get; set; }
        public string? Biography { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        [Required]
        public int DepressionSeverity { get; set; }
        public string? Symptoms { get; set; }
        public string? Medications { get; set; }
    }
}
