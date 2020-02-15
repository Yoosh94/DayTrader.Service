using BtcMarket.Models;
using System.Threading.Tasks;

namespace BtcMarket
{
    public interface IApiClient
    {
        Task<Response> Get(string path, string queryString= "");
    }
}