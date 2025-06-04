namespace WB.LottoAnalytics.Integration.Models
{
    public sealed record UnauthorizedErrorResponse
    {
        public string Type { get; init; }
        public string Title { get; init; }
        public int Status { get; init; }
        public string Detail { get; init; }
        public string Instance { get; init; }
    }
}
