namespace WB.LottoAnalytics.Integration.Models
{
    public sealed record ValidationErrorResponse
    {
        public int Code { get; init; }
        public string Message { get; init; }
    }
}
