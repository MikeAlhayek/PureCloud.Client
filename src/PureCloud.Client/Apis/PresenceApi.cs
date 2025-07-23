using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class PresenceApi : IPresenceApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public PresenceApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> GetPresenceDefinitionAsync(string definitionId, string localeCode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", localeCode);
        }

        var uri = UriHelper.GetUri($"/api/v2/presence/definitions/{definitionId}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinitionEntityListing> GetPresenceDefinitionsAsync(string deactivated = null, IEnumerable<string> divisionId = null, string localeCode = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(deactivated))
        {
            parameters.Add("deactivated", deactivated);
        }
        if (divisionId != null)
        {
            foreach (var id in divisionId)
            {
                parameters.Add("divisionId", id);
            }
        }
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", localeCode);
        }

        var uri = UriHelper.GetUri("/api/v2/presence/definitions", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinitionEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("/api/v2/presence/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> GetUserPresenceAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"/api/v2/users/{userId}/presences/purecloud", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/presence/definitions", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/presence/settings", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> UpdateUserPresenceAsync(string userId, UserPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/users/{userId}/presences/purecloud", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }
}