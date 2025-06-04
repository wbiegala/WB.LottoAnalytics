namespace WB.LottoAnalytics.Integration.Models.Informations
{
    public static class GetNextDraw
    {
        public const string Path = "api/open/v1/lotteries/info/next-draw";

        public sealed record Request
        {
            public string GameType { get; init; }
        }

        public sealed record Response
        {
            public string GameType { get; init; }
            public decimal ClosestPrizeValue { get; init; }
            public DateTime NextDrawDate { get; init; }
            public string PlaySitePath { get; init; }
        }
    }
}
