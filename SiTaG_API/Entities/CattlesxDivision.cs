using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class CattlesxDivision
    {
        public int Id { get; set; }
        public int Cattle_Id { get; set; }
        public int Division_Id { get; set; }
        // Foreing Key
        [ForeignKey("Cattle_Id")]
        public required Cattles Cattle { get; set; }
        [ForeignKey("Division_Id")]
        public required Divisions Division { get; set; }
    }
}
