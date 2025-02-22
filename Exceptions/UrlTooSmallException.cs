namespace URLShorteningService.Exceptions;

public class UrlTooSmallException : Exception
{
    public UrlTooSmallException() : base ("The url is already small") { }
}
