using DMarkitApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Services
{
    public interface IAccountRepository : IDisposable
    {
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task<bool> AccountExistsAsync(Guid accountId);
        Task<Account> GetAccountAsync(Guid accountId);

        Task<bool> SaveChangesAsync();
        void AddAccount(Account account);
    }
}
