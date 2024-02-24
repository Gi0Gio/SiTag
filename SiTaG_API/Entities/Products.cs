using System.ComponentModel.DataAnnotations.Schema;
namespace SiTaG_API.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public required string Product_Name { get; set; }
        public required string Product_Description { get; set; }
        public required decimal Product_Price { get; set; }
        public required int Id_Product_Type { get; set; }
        [Column(TypeName = "text")]
        public string? Product_Image { get; set; }
        // Foreing Key
        [ForeignKey("Id_Product_Type")]
        public required ProductTypes ProductType { get; set; }
    }
}