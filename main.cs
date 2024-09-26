public class UrlShortenerService : IUrlShortenerService
{
    private static readonly char[] _chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    private Dictionary<string, string> UrlDict { get; set; } = [];

    private static string GenerateShortCode()
    {
        return string.Create(5, _chars, (shortCode, charsState)
            => Random.Shared.GetItems(charsState, shortCode));
    }