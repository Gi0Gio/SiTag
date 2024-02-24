using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Lots
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Lot_Name { get; set; }
        public required decimal Lot_Area { get; set; }

    }
}
