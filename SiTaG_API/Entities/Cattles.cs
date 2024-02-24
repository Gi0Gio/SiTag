using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Cattles
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Cattle_Name { get; set; }
    }
}
