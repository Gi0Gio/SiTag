using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Births
    {
        public int Id { get; set; }
        public required int Id_Animal { get; set; }
        public DateTime? Expected_Birth_Date { get; set; }
        public required DateTime Birth_Date { get; set; }
        public required DateTime Service_Date { get; set; }
        public required int Id_Birth_Service { get; set; }
        public decimal? Birth_Weight { get; set; }

        // Foreing Key
        [ForeignKey("Id_Animal")]
        public required Animals Animal { get; set; }
        [ForeignKey("Id_Birth_Service")]
        public required BirthServices BirthService { get; set; }

    }
}
