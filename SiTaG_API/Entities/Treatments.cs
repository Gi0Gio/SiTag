using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Treatments
    {
        public int Id { get; set; }
        public required int Id_Animal { get; set; }
        public required int Id_ServiceType { get; set; }
        public required int Id_Product { get; set; }
        public required DateOnly Application_Date { get; set; }
        public required decimal Dose { get; set; }
        public required int Id_Application_Method { get; set; }
        [Column(TypeName = "text")]
        public string? Observations { get; set; }
        // Foreing Key
        [ForeignKey("Id_Animal")]
        public required Animals Animal { get; set; }
        [ForeignKey("Id_ServiceType")]
        public required ServiceType ServiceType { get; set; }
        [ForeignKey("Id_Product")]
        public required Products Product { get; set; }
        [ForeignKey("Id_Application_Method")]
        public required ApplicationMethods ApplicationMethod { get; set; }

    }
}
