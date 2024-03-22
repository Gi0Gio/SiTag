using System.ComponentModel.DataAnnotations;

namespace SiTaG_API.DTOs
{
    public class ReadApplicationDto
    {
        [Required]
        public string? Application_Method { get; set; }
        
    }
}
