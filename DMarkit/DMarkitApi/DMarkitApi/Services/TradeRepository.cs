using DMarkitApi.DbContexts;
using DMarkitApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Services
{
    public class TradeRepository : ITradeRepository, IDisposable
    {
        private readonly DmarketApiContext _context;

        public TradeRepository(DmarketApiContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        //Getting the list of Trades
        public async Task<IEnumerable<Trade>> GetTradesAsync()
        {
            return await _context.Trades.ToListAsync();
        }

       

        //To check if Trade exist
        public async Task<bool> TradeExistsAsync(Guid tradeId)
        {
            return await _context.Trades.AnyAsync(a => a.TradeId == tradeId);
        }

        //Get one Trade
        public async Task<Trade> GetTradeAsync(Guid tradeId)
        {
            if (tradeId == Guid.Empty)
            {
                throw new ArgumentException(nameof(tradeId));
            }
            return await _context.Trades
                .FirstOrDefaultAsync(a => a.TradeId == tradeId);
        }

        //To save Trade
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }


        //Add Trade
        public void AddTrade(Trade trade)
        {
            if (trade == null)
            {
                throw new ArgumentNullException(nameof(trade));
            }

            _context.Trades.Add(trade);

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
