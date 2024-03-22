namespace SiTaG_API.DTOs
{
    public class ReadBirthDto
    {
        public int Id { get; set; }
        public int Id_Animal { get; set; }
        public DateTime? Expected_Birth_Date { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Service_Date { get; set; }
        public int Id_Birth_Service { get; set; }
        public decimal? Birth_Weight { get; set; }
    }
    public class CreateBirthDto
    {
        public int Id_Animal { get; set; }
        public DateTime? Expected_Birth_Date { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Service_Date { get; set; }
        public int Id_Birth_Service { get; set; }
        public decimal? Birth_Weight { get; set; }
    }
    public class UpdateBirthDto
    {
        public int Id_Animal { get; set; }
        public DateTime? Expected_Birth_Date { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Service_Date { get; set; }
        public int Id_Birth_Service { get; set; }
        public decimal? Birth_Weight { get; set; }
    }
}
