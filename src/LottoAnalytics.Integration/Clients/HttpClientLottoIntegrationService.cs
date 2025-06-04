using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WB.LottoAnalytics.Integration.Clients
{
    internal class HttpClientLottoIntegrationService : ILottoIntegrationService
    {
        private readonly HttpClient _httpClient;

        public HttpClientLottoIntegrationService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

    }
}
