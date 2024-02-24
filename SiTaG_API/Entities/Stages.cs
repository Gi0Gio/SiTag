using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Stages
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public required string Stage_Name { get; set; }
    }
}