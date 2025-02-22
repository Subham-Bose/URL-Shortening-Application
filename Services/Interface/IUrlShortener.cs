namespace URLShorteningService.Services.Interface;

public interface IUrlShortener
{
    string ShortenUrl(string actualUrl);
    string? GetLongUrl(string shortCode);
}
