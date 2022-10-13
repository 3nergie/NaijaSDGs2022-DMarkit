using DMarkitApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Services
{
    public interface ITradeRepository : IDisposable
    {
        Task<IEnumerable<Trade>> GetTradesAsync();
        Task<bool> TradeExistsAsync(Guid tradeId);
        Task<Trade> GetTradeAsync(Guid tradeId);

    }
}
