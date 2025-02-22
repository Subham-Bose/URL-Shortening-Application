using System.Text;
using System.Text.Json;
using URLShorteningService.Services.Interface;

namespace URLShorteningService.Services.Implementation;

public class UrlShortener : IUrlShortener
{
    private static readonly char[] _chars = "123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private Dictionary<string, string> UrlDict { get; set; } = [];

    private static string GenerateShortUrl()
    {
        return string.Create(5, _chars, (shortCode, charsState) => Random.Shared.GetItems(charsState, shortCode));
    }

    public string ShortenUrl(string actualUrl)
    {
        foreach (var pair in UrlDict)
        {
            if (pair.Value == actualUrl) return pair.Key;
        }

        string shortenUrl;
        while (true)
        {
            shortenUrl = GenerateShortUrl();
            if (UrlDict.TryAdd(shortenUrl, actualUrl)) break;
        }

        return shortenUrl;
    }

    public string? GetLongUrl(string shortCode)
    {
        if (UrlDict.TryGetValue(shortCode, out string? longUrl))
        {
            return longUrl;
        }

        return default;
    }
}
