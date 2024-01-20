using Microsoft.AspNetCore.Identity;

namespace Model
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }
    }
}