using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContextcs : DbContext
    {
        public ApplicationDbContextcs(DbContextOptions<ApplicationDbContextcs> options) : base(options)
        {
              // contsrocture that gets DbContext   and send it to base class
              // with this things (these are for data base)
        }

        public DbSet<Category> Categories { get; set; }
    }

    
}
