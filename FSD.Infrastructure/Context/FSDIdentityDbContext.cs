using FSD.Infrastructure.Context.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FSD.Infrastructure.Context
{
    public class FSDIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public FSDIdentityDbContext(DbContextOptions<FSDIdentityDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
