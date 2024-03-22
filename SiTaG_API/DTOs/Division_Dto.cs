namespace SiTaG_API.DTOs
{
    public class ReadDivisionDto
    {
        public int Id { get; set; }
        public string Division_Name { get; set; }
    }
    public class CreateDivisionDto
    {
        public string Division_Name { get; set; }
    }
    public class UpdateDivisionDto
    {
        public string Division_Name { get; set; }
    }
}
