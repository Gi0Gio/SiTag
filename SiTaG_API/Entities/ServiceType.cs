using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Service { get; set; }
    }
}