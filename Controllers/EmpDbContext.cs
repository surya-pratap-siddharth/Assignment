using gitApp.Models;
using Microsoft.EntityFrameworkCore;

namespace gitApp.Controllers
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Emp> Emp { get; set; }
    }
}
