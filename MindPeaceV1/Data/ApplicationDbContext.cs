using BlazorIdentityV2.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorIdentityV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Prop> Props { get; set; }

        public override void AddRange(IEnumerable<object> entities)
        {
            base.AddRange(entities);
        }
    }
}
