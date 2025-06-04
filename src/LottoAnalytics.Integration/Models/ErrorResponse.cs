namespace WB.LottoAnalytics.Integration.Models
{
    public sealed record ErrorResponse
    {
        public int Code { get; init; }
        public string Message { get; init; }
        public string StackTrace { get; init; }
    }
}
