namespace WB.LottoAnalytics.Integration.Models.Informations
{
    public static class GetGameDetails
    {
        public const string Path = "api/open/v1/lotteries/info";

        public sealed record Request
        {
            public string GameType { get; init; }
        }

        public sealed record Response
        {
            public string GameType { get; init; }
            public DateTime NextDrawDate { get; init; }
            public double ClosestPrizeValue { get; init; }
            public string Draws { get; init; }
            public string CouponPrice { get; init; }
            public string ClosestPrizePoolType { get; init; }
        }
    }
}
