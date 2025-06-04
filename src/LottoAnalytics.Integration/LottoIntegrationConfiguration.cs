using System.Text;

namespace WB.LottoAnalytics.Integration
{
    public sealed record LottoIntegrationConfiguration
    {
        public const string SectionName = "LottoIntegration";
        public const string HeaderAuthName = "secret";

        public string BaseUrl { get; init; }
        public string ApiKey { get; init; }
    }
}
