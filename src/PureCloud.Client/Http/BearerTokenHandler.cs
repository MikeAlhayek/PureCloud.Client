using System.Net;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.Http;

public sealed class BearerTokenHandler : DelegatingHandler
{
    private static readonly MediaTypeWithQualityHeaderValue _jsonHeader = new("application/json");

    private readonly ITokenService _tokenService;
    private readonly ILogger _logger;

    public BearerTokenHandler(
        ITokenService tokenService,
        ILogger<BearerTokenHandler> logger)
    {
        _tokenService = tokenService;
        _logger = logger;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Accept.Add(_jsonHeader);

        var accessToken = await _tokenService.GetAccessTokenAsync();

        if (!string.IsNullOrEmpty(accessToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        var response = await base.SendAsync(request, cancellationToken);

        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            // Refresh token
            var newToken = await _tokenService.RefreshTokenAsync();

            if (!string.IsNullOrEmpty(newToken))
            {
                // Clone the request (HttpRequestMessage can't be reused directly)
                var newRequest = await CloneHttpRequestMessageAsync(request);

                newRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", newToken);

                // Retry the request once
                response = await base.SendAsync(newRequest, cancellationToken);
            }
            else
            {
                throw new UnauthorizedAccessException("Access token refresh failed. User re-authentication may be required.");
            }
        }
        else if ((int)response.StatusCode >= 400)
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken);

            _logger.LogError("Failed to call PureCloud API. {Content}", body);
        }

        return response;
    }

    private static async Task<HttpRequestMessage> CloneHttpRequestMessageAsync(HttpRequestMessage request)
    {
        var clone = new HttpRequestMessage(request.Method, request.RequestUri)
        {
            Content = request.Content == null
            ? null
            : await CloneHttpContentAsync(request.Content),
            Version = request.Version
        };

        foreach (var header in request.Headers)
        {
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        foreach (var prop in request.Options)
        {
            clone.Options.TryAdd(prop.Key, prop.Value);
        }

        return clone;
    }

    private static async Task<HttpContent> CloneHttpContentAsync(HttpContent content)
    {
        var stream = new MemoryStream();
        await content.CopyToAsync(stream);
        stream.Seek(0, SeekOrigin.Begin);

        var clone = new StreamContent(stream);
        foreach (var header in content.Headers)
        {
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        return clone;
    }
}
