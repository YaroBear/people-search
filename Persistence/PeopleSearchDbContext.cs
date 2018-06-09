using Microsoft.EntityFrameworkCore;
using PeopleSearch.Models;

namespace PeopleSearch.Persistence
{
    public class PeopleSearchDbContext : DbContext
    {
        public PeopleSearchDbContext(DbContextOptions<PeopleSearchDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }
    }
}