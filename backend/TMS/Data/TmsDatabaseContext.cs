using Microsoft.EntityFrameworkCore;
using TMS.Models.Domain;

namespace TMS.Data
{
    public class TmsDatabaseContext : DbContext
    {
        public TmsDatabaseContext(DbContextOptions options): base(options) {}

        public DbSet<Department> Departments { get; set; }
    }
}
