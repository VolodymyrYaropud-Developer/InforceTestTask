using Microsoft.EntityFrameworkCore;

namespace InforceTestTask.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique(); 
            
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<URL>()
                .Property(u => u.FullURL)
                .IsRequired()
                .HasMaxLength(2048);

            modelBuilder.Entity<URL>()
                .Property(u => u.ShortURL)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<URL>()
                .HasOne(u => u.CreatedByUser)
                .WithMany(u => u.Uries)
                .HasForeignKey(u => u.CreatedByUserId)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<URL> URLs { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
