using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class BirthServices
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Service_Name { get; set; }
    }
}