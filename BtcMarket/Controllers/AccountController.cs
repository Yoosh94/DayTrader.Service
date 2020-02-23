using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BtcMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IApiClient client;

        public AccountController(IApiClient client)
        {
            this.client = client;
        }

        [HttpGet]
        [Route("{asset}")]
        public async Task<string> get(string asset)
        {
            var response = await client.Get("/v3/accounts/me/transactions",$"assetName={asset}");
            return response.Content;
        }
    }
}