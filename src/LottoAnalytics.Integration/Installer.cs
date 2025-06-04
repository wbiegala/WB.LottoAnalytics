using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WB.LottoAnalytics.Integration.Clients;

namespace WB.LottoAnalytics.Integration
{
    public static class Installer
    {
        public static IServiceCollection AddLottoIntegration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var config = configuration
                .GetSection(LottoIntegrationConfiguration.SectionName)
                .Get<LottoIntegrationConfiguration>();

            services.AddHttpClient<ILottoIntegrationService, HttpClientLottoIntegrationService>(client =>
            {
                client.BaseAddress = new Uri(config!.BaseUrl);
                client.DefaultRequestHeaders.Add(LottoIntegrationConfiguration.HeaderAuthName, config.ApiKey);
            });

            return services;
        }
    }
}
