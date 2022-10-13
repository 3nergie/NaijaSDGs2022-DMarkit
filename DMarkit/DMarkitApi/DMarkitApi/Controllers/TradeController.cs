using DMarkitApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Controllers
{
    [ApiController]
    [Route("api/trades")]
    public class TradeController : ControllerBase
    {
        private readonly ITradeRepository _tradeRepository;

        public TradeController(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository ??
                throw new ArgumentNullException(nameof(tradeRepository));
        }

        //To get all Trades
        [HttpGet]
        public async Task<IActionResult> GetAllTrades()
        {
            var Trades = await _tradeRepository.GetTradesAsync();
            return Ok(Trades);
        }



        // To get one Account
        [HttpGet("{tradeId}")]
        public async Task<IActionResult> GetTrade(Guid tradeId)
        {
            var tradeFromRepo = await _tradeRepository.GetTradeAsync(tradeId);

            if (tradeFromRepo == null)
            {
                return NotFound();
            }

            return Ok(tradeFromRepo);
        }
    }
}
