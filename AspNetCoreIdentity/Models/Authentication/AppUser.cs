using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Models.Authentication
{
    public class AppUser: IdentityUser
    {
        public string Hometown { get; set; }
        public bool Gender { get; set; }
    }
}
