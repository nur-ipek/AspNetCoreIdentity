using AspNetCoreIdentity.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Models.Context
{
    public class AppDbContext: IdentityDbContext<AppUser, AppRole, string> // 3. parametrede ise bu yapılanmanın primary key (Id) kolonlarının “string” tipte değerlerle tutulacağını ifade etmiş oluyoruz
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext) { }
    }

}

