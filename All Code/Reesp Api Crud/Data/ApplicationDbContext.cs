using Microsoft.EntityFrameworkCore;
using Reesp_Api_Crud.Model;

namespace Reesp_Api_Crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }

        public DbSet<student> Students { get; set; }
        public DbSet<CusInfo> custInfo { get; set; }
    }   
}
