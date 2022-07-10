using gitApp.Models;
using Microsoft.EntityFrameworkCore;

namespace gitApp.Controllers
{
    public class EmpsDbContextcs : DbContext
    {
        public EmpsDbContextcs(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Emp> Emp { get; set; }
    }
}
