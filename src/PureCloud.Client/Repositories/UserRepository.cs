using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public UserRepository(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<User> CreateAsync(CreateUser user, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users", user, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> UpdateAsync(string userId, UpdateUser user, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/users/{userId}", user, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> DeleteAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/users/{userId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> GetAsync(string userId, UserSearchContext context = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/users/{userId}";

        if (context is not null)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();

            if (context.Expands is not null && context.Expands.Count > 0)
            {
                foreach (var expand in context.Expands)
                {
                    queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
                }

                if (!string.IsNullOrEmpty(context.IntegrationPresenceSource))
                {
                    queryParameters.Add(new KeyValuePair<string, string>("integrationPresenceSource", UriHelper.ParameterToString(context.IntegrationPresenceSource)));
                }

                if (!string.IsNullOrEmpty(context.State))
                {
                    queryParameters.Add(new KeyValuePair<string, string>("state", UriHelper.ParameterToString(context.State)));
                }

                uri = QueryHelpers.AddQueryString(uri, queryParameters);
            }
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SearchResult<User>> SearchAsync(UserSearchRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/users/search", request, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SearchResult<User>>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<User> GetMeAsync(IEnumerable<string> expands = null, string integrationPresenceSource = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/users/me";

        var queryParameters = new List<KeyValuePair<string, string>>();

        if (expands is not null)
        {
            foreach (var expand in expands)
            {
                queryParameters.Add(new KeyValuePair<string, string>("expand", UriHelper.ParameterToString(expand)));
            }
        }

        if (!string.IsNullOrEmpty(integrationPresenceSource))
        {
            queryParameters.Add(new KeyValuePair<string, string>("integrationPresenceSource", UriHelper.ParameterToString(integrationPresenceSource)));
        }

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<User>(_options.JsonSerializerOptions, cancellationToken);
    }
}
