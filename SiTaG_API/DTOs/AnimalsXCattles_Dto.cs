namespace SiTaG_API.DTOs
{
    public class ReadAnimalsXCattlesDto
    {
        public int Id { get; set; }
        public int Animal_Id { get; set; }
        public int Cattle_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }

    public class CreateAnimalsXCattlesDto
    {
        public int Animal_Id { get; set; }
        public int Cattle_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }
    public class UpdateAnimalsXCattlesDto
    {
        public int Animal_Id { get; set; }
        public int Cattle_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }
}
