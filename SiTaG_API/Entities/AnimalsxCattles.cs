using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class AnimalsxCattles
    {
        public int Id { get; set; }
        public int Animal_Id { get; set; }
        public int Cattle_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }

        // Foreing Key
        [ForeignKey("Animal_Id")]
        public required Animals Animal { get; set; }
        [ForeignKey("Cattle_Id")]
        public required Cattles Cattle { get; set; }
    }
}
