using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Animals
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(5)")]
        public required string Identifier{ get; set; }
        [Column(TypeName = "varchar(50)")]
        public  string? Name { get; set; }
        public required int Sex { get; set; }
        public required int Id_Race { get; set; }
        [Column(TypeName = "text")]
        public string? Description { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public decimal CurrentWeight { get; set; }
        public int? Id_Mother { get; set; }
        public int? Id_Father { get; set; }
        public required int Id_status { get; set; }
        [Column(TypeName = "varchar(50)")]
        public required string Color { get; set; }
        public DateTime LastUpdate { get; set; }
        public required int Id_Stage { get; set; }
        public required int Id_Health_Status { get; set; }

        // Foreing Key
        [ForeignKey("Id_Mother")]
        public Animals? Mother { get; set; }
        [ForeignKey("Id_Father")]
        public Animals? Father { get; set; }
        [ForeignKey("Id_Stage")]
        public required Stages Stage { get; set; }
        [ForeignKey("Id_Health_Status")]
        public required HealthStatuses HealthStatus { get; set; }
    }
}
