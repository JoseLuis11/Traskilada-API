using Microsoft.EntityFrameworkCore;
using TraskiladaWebAPI.Models;
using TraskiladaWebAPI.Repositories;

namespace TraskiladaWebAPI.Context
{
    public class TraskiladaContext : DbContext
    {
        //private IGenericRepository<Person> _personRepository;
        private IAccountRepository _accountRepository; 

        public TraskiladaContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        // public IGenericRepository<Person> PersonRepository =>
        //     _personRepository ?? (_personRepository = new GenericRepository<Person>(Persons));

        public IAccountRepository AccountRepository => _accountRepository ?? (_accountRepository = new AccountRepository(Accounts));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}