using DMarkitApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Entities
{
    public class Trade
    {
        public Guid TradeId { get; set; }
        public string NameSeller { get; set; }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public bool IsActive { get; set; }
        public TradePairEnum CurrencyPair { get; set; }

    }
}
