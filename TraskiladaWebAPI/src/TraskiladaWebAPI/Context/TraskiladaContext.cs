using Microsoft.EntityFrameworkCore;
using TraskiladaWebAPI.Repositories;

namespace TraskiladaWebAPI.Context
{
    public class TraskiladaContext : DbContext
    {
        // private IGenericRepository<Person> _personRepository;

        public TraskiladaContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        // public IGenericRepository<Person> PersonRepository =>
        //     _personRepository ?? (_personRepository = new GenericRepository<Person>(Persons));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}