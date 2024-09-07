namespace LibraryManagementSystem.Models
{
    public class Reader
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Role { get; set; } = "User";
        public ICollection<Book> books { get; set; }
    }
}
