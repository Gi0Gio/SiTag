namespace SiTaG_API.DTOs
{
    public class ReadLotsDto
    {
        public int Id { get; set; }
        public string Lot_Name { get; set; }
        public decimal Lot_Area { get; set; }
    }
    public class CreateLotsDto
    {
        public string Lot_Name { get; set; }
        public decimal Lot_Area { get; set; }
    }
    public class UpdateLotsDto
    {
        public string Lot_Name { get; set; }
        public decimal Lot_Area { get; set; }
    }
}
