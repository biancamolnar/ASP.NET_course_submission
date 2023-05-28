using Microsoft.AspNetCore.Identity;

namespace Bmerketo.Models.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}
