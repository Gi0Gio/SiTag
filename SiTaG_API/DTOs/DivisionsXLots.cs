namespace SiTaG_API.DTOs
{
        public class ReadDivisionsXLotsDto
        {
            public int Id { get; set; }
            public string Division_Name { get; set; }
            public string Lot_Name { get; set; }
        }
        public class CreateDivisionsXLotsDto
        {
            public int Division_Id { get; set; }
            public int Lot_Id { get; set; }
        }
        public class UpdateDivisionsXLotsDto
        {
            public int Division_Id { get; set; }
            public int Lot_Id { get; set; }
        }
}
