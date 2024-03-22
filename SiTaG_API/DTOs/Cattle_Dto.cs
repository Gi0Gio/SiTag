namespace SiTaG_API.DTOs
{
    public class ReadCattleDto
    {
        public int Id { get; set; }
        public string Cattle_Name { get; set; }
    }
    public class CreateCattleDto
    {
        public required string Cattle_Name { get; set; }
    }
    public class UpdateCattleDto
    {
        public required string Cattle_Name { get; set; }
    }
}
