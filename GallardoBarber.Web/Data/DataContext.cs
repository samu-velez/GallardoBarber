using GallardoBarber.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GallardoBarber.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
        
