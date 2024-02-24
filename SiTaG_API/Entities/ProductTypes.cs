using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Product_Type { get; set; }
    }
}