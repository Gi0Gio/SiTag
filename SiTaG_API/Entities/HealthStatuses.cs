using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class HealthStatuses
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public required string Health_Status { get; set; }
    }
}