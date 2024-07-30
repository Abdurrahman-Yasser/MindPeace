using Microsoft.EntityFrameworkCore;
using MindPeaceV2.Data.Models;

namespace MindPeaceV2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
    }
}
