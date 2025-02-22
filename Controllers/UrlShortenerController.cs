using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using URLShorteningService.Exceptions;
using URLShorteningService.Services.Implementation;
using URLShorteningService.Services.Interface;

namespace URLShorteningService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UrlShortenerController : ControllerBase
{
    private IUrlShortener _urlShortener;

    public UrlShortenerController(IUrlShortener urlShortener)
    {
        _urlShortener = urlShortener;
    }

    [HttpPost("/createshorturl")]
    public IActionResult ShortenUrl([FromBody]string url)
    {
        if (!Uri.TryCreate(url, UriKind.Absolute, out _))
        {
            return BadRequest("Not a valid url");
        }

        return Ok(_urlShortener.ShortenUrl(url));
    }

    [HttpGet("/{shortUrl}")]
    public IActionResult GetLongUrl(string shorturl)
    {
        var longurl = _urlShortener.GetLongUrl(shorturl);

        if (longurl is null)
        {
            return NotFound();
        }

        return Ok(longurl);
    }
}
