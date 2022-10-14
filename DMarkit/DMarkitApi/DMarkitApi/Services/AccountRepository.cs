using DMarkitApi.DbContexts;
using DMarkitApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Services
{
    public class AccountRepository : IAccountRepository, IDisposable
    {
        private readonly DmarketApiContext _context;

        public AccountRepository(DmarketApiContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

     
        //Getting the list of Accounts
        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        //To check if Account exist
        public async Task<bool> AccountExistsAsync(Guid accountId)
        {
            return await _context.Accounts.AnyAsync(a => a.Id == accountId);
        }


        //Get one Account
        public async Task<Account> GetAccountAsync(Guid accountId)
        {
            if(accountId == Guid.Empty)
            {
                throw new ArgumentException(nameof(accountId));
            }
            return await _context.Accounts
                .FirstOrDefaultAsync(a => a.Id == accountId);
        }

        //To save Account
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        //Add Account
        public void AddAccount(Account account)
        {
            if(account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _context.Accounts.Add(account);

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            
            }
        }
    }
}
