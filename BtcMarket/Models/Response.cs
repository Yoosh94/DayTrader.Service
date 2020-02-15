using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BtcMarket.Models
{
    public class Response
    {
        public HttpResponseHeaders Headers { get; set; }
        public string Content { get; set; }
    }
}
