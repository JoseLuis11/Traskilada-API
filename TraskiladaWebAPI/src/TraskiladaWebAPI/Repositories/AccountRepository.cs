using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraskiladaWebAPI.Models;

namespace TraskiladaWebAPI.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> ValidateCredentials(Account account);
    }

    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(DbSet<Account> dbSet) : base(dbSet)
        {
        }

        public async Task<Account> ValidateCredentials(Account account) =>
            await SingleAsync(x => x.Email == account.Email && x.Password == account.Password, CancellationToken.None);
    }
}
