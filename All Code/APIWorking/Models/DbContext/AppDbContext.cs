namespace APIWorking.Models.DbContext
{
    using APIWorking.Models;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<UserModel> Users { get; set; }
    }
}
