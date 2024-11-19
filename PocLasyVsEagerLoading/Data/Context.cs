using Microsoft.EntityFrameworkCore;
using PocLasyVsEagerLoading.Models;

namespace PocLasyVsEagerLoading.Data
{
    public class Context:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
    }
}
