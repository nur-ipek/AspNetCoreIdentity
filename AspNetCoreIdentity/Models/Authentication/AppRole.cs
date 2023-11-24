using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Models.Authentication
{
    public class AppRole: IdentityRole
    {
        public DateTime CreatedDate { get; set; }
    }
}
