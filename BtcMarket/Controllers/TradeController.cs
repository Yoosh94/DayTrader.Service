using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BtcMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly IApiClient client;

        public TradeController(IApiClient client)
        {
            this.client = client;
        }

        [HttpGet]
        [Route("{marketId}")]
        public async Task<string> Get(string marketId)
        {
            var response = await client.Get("/v3/trades",$"marketId={marketId.ToUpper()}");
            return response.Content;
        }
    }
}