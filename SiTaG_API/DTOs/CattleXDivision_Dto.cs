namespace SiTaG_API.DTOs
{
    public class ReadCattleXDivision
    {
        public int Id { get; set; }
        public int Cattle_Id { get; set; }
        public int Division_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }
    public class CreateCattleXDivision
    {
        public int Cattle_Id { get; set; }
        public int Division_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }
    public class UpdateCattleXDivision
    {
        public int Cattle_Id { get; set; }
        public int Division_Id { get; set; }
        public DateOnly Start_Date { get; set; }
        public DateOnly? End_Date { get; set; }
    }
}
