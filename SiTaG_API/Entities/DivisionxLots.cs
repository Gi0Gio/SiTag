using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class DivisionxLots
    {
        public int Id { get; set; }
        public int Division_Id { get; set; }
        public int Lot_Id { get; set; }
        // Foreing Key
        [ForeignKey("Division_Id")]
        public required Divisions Division { get; set; }
        [ForeignKey("Lot_Id")]
        public required Lots Lot { get; set; }
    }
}
