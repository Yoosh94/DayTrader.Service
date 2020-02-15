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
    public class MarketController : ControllerBase
    {
        private readonly IApiClient _client;
        public MarketController(IApiClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<string> Ticker()
        {
            var response = await _client.Get("/v3/markets/BTC-AUD/ticker");
            return response.Content;
        }
    }
}