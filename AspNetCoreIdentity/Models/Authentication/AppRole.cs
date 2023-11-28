using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Models.Authentication
{
    public class AppRole: IdentityRole<int>
    {
        public DateTime CreatedDate { get; set; }
    }
}
