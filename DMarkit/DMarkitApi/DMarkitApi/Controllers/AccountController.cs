using DMarkitApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMarkitApi.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository ??
                throw new ArgumentNullException(nameof(accountRepository));
        }


        // To get one Account
        [HttpGet()]
        public async Task <IActionResult> GetAccount(Guid accountId)
        {
            var accountFromRepo = await _accountRepository.GetAccountAsync(accountId);

            if(accountFromRepo == null)
            {
                return NotFound();
            }

            return Ok(accountFromRepo);
        }

     
      
    }
}
