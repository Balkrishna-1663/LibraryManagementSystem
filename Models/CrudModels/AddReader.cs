using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Models.CrudModels
{
    public class AddReader
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IdentityRole Role { get; set; } 
    }
}
