using System.ComponentModel.DataAnnotations;

namespace SiTaG_API.DTOs
{
    public class CreateProductDto
    {
        [Required]
        public string? Product_Name { get; set; }
        [Required]
        public string? Product_Description { get; set; }
        [Required]
        public decimal Product_Price { get; set; }
        [Required]
        public int Id_Product_Type { get; set; }
        public string? Product_Image { get; set; }
    }
    public class ReadProductDto
    {
        public int Id { get; set; }
        public string? Product_Name { get; set; }
        public string? Product_Description { get; set; }
        public decimal Product_Price { get; set; }
        public int Id_Product_Type { get; set; }
        public string? Product_Image { get; set; }
        // Depending on your needs, you might include related entity data here as well
        // For example, the product type name from the ProductTypes entity
        public string? ProductType_Name { get; set; }
    }
    public class UpdateProductDto
    {
        public string? Product_Name { get; set; }
        public string? Product_Description { get; set; }
        public decimal? Product_Price { get; set; }
        // Id_Product_Type is not included here assuming product type cannot be changed after creation.
        // If product type changes are allowed, include it as a nullable field.
        public string? Product_Image { get; set; }
    }
}
