using Microsoft.EntityFrameworkCore;
using EllaManka.EndpointService.Models;

namespace EllaManka.EndpointService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }
    }
}
