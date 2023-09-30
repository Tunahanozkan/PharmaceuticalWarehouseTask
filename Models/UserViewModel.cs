namespace PharmaceuticalWarehouse.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Password { get; set; }
        public int TcNo { set; get; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Insurance { get; set; }
        public string PhoneNumber { get; set; }
    }
}
