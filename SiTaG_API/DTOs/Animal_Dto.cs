using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace SiTaG_API.DTOs
{
        public class AnimalCreateDto
        {
            [StringLength(5)]
            public required string Identifier { get; set; }
            [StringLength(50)]
            public required string Name { get; set; }
            [Required]
            public int sex { get; set; }
            [Required]
            public int Id_Race { get; set; }
            public string? Description { get; set; }
            [Required]
            public DateTime DateOfBirth { get; set; }
            [Required]
            public decimal CurrentWeight { get; set; }
            public int? Id_Mother { get; set; }
            public int? Id_Father { get; set; }
            [Required]
            public int Id_status { get; set; }
            [StringLength(50)]
            public required string Color { get; set; }
            [Required]
            public int Id_Stage { get; set; }
            [Required]
            public int Id_Health_Status { get; set; }

        }
        public class ReadAnimalDto
        {
            public int Id { get; set; }
            public required string Identifier { get; set; }
            public string? Name { get; set; }
            public int Sex { get; set; }
            public int Id_Race { get; set; }
            public string? Description { get; set; }
            public DateTime DateOfBirth { get; set; }
            public decimal CurrentWeight { get; set; }
            public int? Id_Mother { get; set; }
            public int? Id_Father { get; set; }
            public int Id_status { get; set; }
            public required string Color { get; set; }
            public DateTime LastUpdate { get; set; }
            public int Id_Stage { get; set; }
            public int Id_Health_Status { get; set; }
        }
        public class AnimalUpdateDto
        {
            public string? Name { get; set; }
            public string? Description { get; set; }
            public decimal? CurrentWeight { get; set; }
            public string? Color { get; set; }
    }

}

