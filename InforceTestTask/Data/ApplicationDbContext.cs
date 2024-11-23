using Microsoft.EntityFrameworkCore;

namespace InforceTestTask.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }



        public DbSet<URL> URLs { get; set; }
    }
}
