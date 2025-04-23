using Microsoft.EntityFrameworkCore;

namespace WebSite.Data.EfCore
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<User> Users => Set<User>();
       


    }
}