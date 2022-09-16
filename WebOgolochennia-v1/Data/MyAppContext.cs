using Microsoft.EntityFrameworkCore;
using WebOgolochennia_v1.Data.Entities;

namespace WebOgolochennia_v1.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options) { }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
    
}
