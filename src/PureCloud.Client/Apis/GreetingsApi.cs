using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class GreetingsApi : IGreetingsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public GreetingsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task DeleteGreetingAsync(string greetingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(greetingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/greetings/{UriHelper.ParameterToString(greetingId)}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<Greeting> GetGreetingAsync(string greetingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(greetingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/greetings/{UriHelper.ParameterToString(greetingId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Greeting>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GreetingMediaInfo> GetGreetingMediaAsync(string greetingId, string formatId = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(greetingId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(formatId))
        {
            parameters.Add("formatId", UriHelper.ParameterToString(formatId));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/greetings/{UriHelper.ParameterToString(greetingId)}/media", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GreetingMediaInfo>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainEntityListing> GetGreetingsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/greetings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> GetGreetingsDefaultsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/greetings/defaults", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GreetingListing> GetGroupGreetingsAsync(string groupId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/groups/{UriHelper.ParameterToString(groupId)}/greetings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GreetingListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> GetGroupGreetingsDefaultsAsync(string groupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/groups/{UriHelper.ParameterToString(groupId)}/greetings/defaults", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DomainEntityListing> GetUserGreetingsAsync(string userId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/users/{UriHelper.ParameterToString(userId)}/greetings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DomainEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> GetUserGreetingsDefaultsAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/users/{UriHelper.ParameterToString(userId)}/greetings/defaults", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Greeting> CreateGreetingAsync(Greeting body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/greetings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Greeting>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Greeting> CreateGroupGreetingAsync(string groupId, Greeting body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/groups/{UriHelper.ParameterToString(groupId)}/greetings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Greeting>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Greeting> CreateUserGreetingAsync(string userId, Greeting body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/users/{UriHelper.ParameterToString(userId)}/greetings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Greeting>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Greeting> UpdateGreetingAsync(string greetingId, Greeting body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(greetingId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/greetings/{UriHelper.ParameterToString(greetingId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Greeting>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> UpdateGreetingsDefaultsAsync(DefaultGreetingList body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/greetings/defaults", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> UpdateGroupGreetingsDefaultsAsync(string groupId, DefaultGreetingList body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/groups/{UriHelper.ParameterToString(groupId)}/greetings/defaults", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DefaultGreetingList> UpdateUserGreetingsDefaultsAsync(string userId, DefaultGreetingList body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/users/{UriHelper.ParameterToString(userId)}/greetings/defaults", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DefaultGreetingList>(_options.JsonSerializerOptions, cancellationToken);
    }

}
