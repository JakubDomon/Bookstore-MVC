using Bookstore_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_MVC.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
