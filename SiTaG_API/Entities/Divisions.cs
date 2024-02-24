using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Divisions
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Division_Name { get; set; }
    }
}
