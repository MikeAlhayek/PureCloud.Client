using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Exceptions;
using PureCloud.Client.Models.Settings;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.Services;

public class TokenService : ITokenService
{
    private readonly static JsonSerializerOptions _serializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
    };

    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudOptions _options;
    private readonly ITokenStore _tokenStore;

    // TODO, instead of using httpClientFactory, use OpenIddict library for authentication.
    public TokenService(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudOptions> options,
        ITokenStore tokenStore)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
        _tokenStore = tokenStore;
    }

    public async ValueTask<string> GetAccessTokenAsync()
    {
        var accessToken = await _tokenStore.GetAsync(TokenType.AccessToken);

        if (string.IsNullOrEmpty(accessToken))
        {
            if (string.IsNullOrWhiteSpace(_options.ClientId) || string.IsNullOrWhiteSpace(_options.ClientSecret))
            {
                throw new OAuthConfigurationException();
            }

            // get a new token;
            var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudAuthClientName);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Encoding.GetEncoding("ISO-8859-1")
            var byteArray = Encoding.ASCII.GetBytes($"{_options.ClientId}:{_options.ClientSecret}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            // Accept JSON responses
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var data = new Dictionary<string, string>();

            if (_options.Scopes is not null && _options.Scopes.Count > 0)
            {
                data.Add("scope", string.Join(' ', _options.Scopes));
            }

            if (!string.IsNullOrEmpty(_options.AuthorizationCode))
            {
                data.Add("grant_type", "authorization_code");
                data.Add("code", _options.AuthorizationCode);
            }
            else
            {
                data.Add("grant_type", "client_credentials");
            }

            if (!string.IsNullOrEmpty(_options.RedirectUri))
            {
                data.Add("redirect_uri", _options.RedirectUri);
            }

            var response = await client.PostAsync("/oauth/token", new FormUrlEncodedContent(data));

            if (!response.IsSuccessStatusCode)
            {
                await _tokenStore.RemoveAsync(TokenType.AccessToken);

                var errorContent = await response.Content.ReadAsStringAsync();

                throw new OAuthException($"Token request failed with status code {response.StatusCode}. Response: {errorContent}");
            }

            var responseContent = await response.Content.ReadFromJsonAsync<AuthTokenInfo>(_serializerOptions);

            accessToken = responseContent?.AccessToken;

            await _tokenStore.SetAsync(TokenType.AccessToken, accessToken);
        }

        return accessToken;
    }

    public async ValueTask<string> GetRefreshTokenAsync()
        => (await _tokenStore.GetAsync(TokenType.RefreshToken));

    public async ValueTask<string> RefreshTokenAsync()
    {
        var refreshToken = await GetRefreshTokenAsync();

        if (!string.IsNullOrEmpty(refreshToken))
        {
            // get a new token;
            var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudAuthClientName);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Encoding.GetEncoding("ISO-8859-1")
            var byteArray = Encoding.ASCII.GetBytes($"{_options.ClientId}:{_options.ClientSecret}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            // Accept JSON responses
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var data = new Dictionary<string, string>()
            {
                {"grant_type", "refresh_token" },
                {"refresh_token", refreshToken },
            };

            if (_options.Scopes is not null && _options.Scopes.Count > 0)
            {
                data.Add("scope", string.Join(' ', _options.Scopes));
            }

            if (!string.IsNullOrEmpty(_options.AuthorizationCode))
            {
                data.Add("code", _options.AuthorizationCode);
            }

            if (!string.IsNullOrEmpty(_options.RedirectUri))
            {
                data.Add("redirect_uri", _options.RedirectUri);
            }

            var response = await client.PostAsync("/oauth/token", new FormUrlEncodedContent(data));

            if (!response.IsSuccessStatusCode)
            {
                await _tokenStore.RemoveAsync(TokenType.RefreshToken);

                var errorContent = await response.Content.ReadAsStringAsync();

                throw new OAuthException($"Refresh token request failed with status code {response.StatusCode}. Response: {errorContent}");
            }

            var responseContent = await response.Content.ReadFromJsonAsync<AuthTokenInfo>(_serializerOptions);

            if (!string.IsNullOrEmpty(responseContent?.AccessToken))
            {
                await _tokenStore.SetAsync(TokenType.AccessToken, responseContent.AccessToken);

                if (!string.IsNullOrEmpty(responseContent?.RefreshToken))
                {
                    await _tokenStore.SetAsync(TokenType.RefreshToken, responseContent.RefreshToken);
                }

                return responseContent.AccessToken;
            }
        }

        return null;
    }
}
