namespace WB.LottoAnalytics.Integration.Models.Informations
{
    public static class GetJackpot
    {
        public const string Path = "api/open/v1/lotteries/info/game-jackpot";

        public sealed record Request
        {
            public string GameType { get; init; }
        }

        public sealed record Response
        {
            public decimal JackpotValue { get; init; }
            public decimal JackpotPlusValue { get; init; }
            public DateTime ClosestDraw { get; init; }
        }
    }
}
