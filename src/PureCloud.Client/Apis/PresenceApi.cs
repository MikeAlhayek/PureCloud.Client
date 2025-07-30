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
    public async Task<bool> DeletePresenceDefinitionAsync(string definitionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);

        var uri = UriHelper.GetUri($"api/v2/presence/definitions/{Uri.EscapeDataString(definitionId)}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeletePresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var uri = UriHelper.GetUri($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use DeletePresenceDefinitionAsync instead")]
    public async Task<bool> DeletePresenceDefinitionLegacyAsync(string presenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(presenceId);

        var uri = UriHelper.GetUri($"api/v2/presencedefinitions/{Uri.EscapeDataString(presenceId)}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> GetPresenceDefinitionAsync(string definitionId, string localeCode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", UriHelper.ParameterToString(localeCode));
        }

        var uri = UriHelper.GetUri($"api/v2/presence/definitions/{Uri.EscapeDataString(definitionId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinitionEntityListing> GetPresenceDefinitionsAsync(string deactivated = null, IEnumerable<string> divisionIds = null, string localeCode = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(deactivated))
        {
            parameters.Add("deactivated", UriHelper.ParameterToString(deactivated));
        }
        if (divisionIds != null)
        {
            foreach (var divisionId in divisionIds)
            {
                parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
            }
        }
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", UriHelper.ParameterToString(localeCode));
        }

        var uri = UriHelper.GetUri("api/v2/presence/definitions", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinitionEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/presence/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> GetPresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var uri = UriHelper.GetUri($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SourceEntityListing> GetPresenceSourcesAsync(string deactivated = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(deactivated))
        {
            parameters.Add("deactivated", UriHelper.ParameterToString(deactivated));
        }

        var uri = UriHelper.GetUri("api/v2/presence/sources", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SourceEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPrimarySource> GetUserPrimarySourceAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"api/v2/presence/users/{Uri.EscapeDataString(userId)}/primarysource", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPrimarySource>(_options, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use GetPresenceDefinitionAsync instead")]
    public async Task<OrganizationPresence> GetPresenceDefinitionLegacyAsync(string presenceId, string localeCode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(presenceId);

        var parameters = new NameValueCollection();
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", UriHelper.ParameterToString(localeCode));
        }

        var uri = UriHelper.GetUri($"api/v2/presencedefinitions/{Uri.EscapeDataString(presenceId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use GetPresenceDefinitionsAsync instead")]
    public async Task<OrganizationPresenceEntityListing> GetPresenceDefinitionsLegacyAsync(int? pageNumber = null, int? pageSize = null, string deleted = null, string localeCode = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }
        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }
        if (!string.IsNullOrEmpty(deleted))
        {
            parameters.Add("deleted", UriHelper.ParameterToString(deleted));
        }
        if (!string.IsNullOrEmpty(localeCode))
        {
            parameters.Add("localeCode", UriHelper.ParameterToString(localeCode));
        }

        var uri = UriHelper.GetUri("api/v2/presencedefinitions", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<SystemPresence>> GetSystemPresencesAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/systempresences", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<SystemPresence>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> GetUserPresenceAsync(string userId, string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var uri = UriHelper.GetUri($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/{Uri.EscapeDataString(sourceId)}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> GetUserPresencePurecloudAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var uri = UriHelper.GetUri($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/purecloud", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<UcUserPresence>> GetUsersPresenceBulkAsync(string sourceId, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var parameters = new NameValueCollection();
        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        var uri = UriHelper.GetUri($"api/v2/users/presences/{Uri.EscapeDataString(sourceId)}/bulk", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<UcUserPresence>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<UcUserPresence>> GetUsersPresencesPurecloudBulkAsync(IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();
        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("id", UriHelper.ParameterToString(id));
            }
        }

        var uri = UriHelper.GetUri("api/v2/users/presences/purecloud/bulk", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<UcUserPresence>>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> UpdateUserPresenceAsync(string userId, string sourceId, UserPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/{Uri.EscapeDataString(sourceId)}", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> UpdateUserPresencePurecloudAsync(string userId, UserPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/purecloud", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/presence/definitions", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> CreatePresenceSourceAsync(Source body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/presence/sources", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use CreatePresenceDefinitionAsync instead")]
    public async Task<OrganizationPresence> CreatePresenceDefinitionLegacyAsync(OrganizationPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/presencedefinitions", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> UpdatePresenceDefinitionAsync(string definitionId, OrganizationPresenceDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/presence/definitions/{Uri.EscapeDataString(definitionId)}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/presence/settings", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> UpdatePresenceSourceAsync(string sourceId, Source body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPrimarySource> UpdateUserPrimarySourceAsync(string userId, UserPrimarySource body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/presence/users/{Uri.EscapeDataString(userId)}/primarysource", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPrimarySource>(_options, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use UpdatePresenceDefinitionAsync instead")]
    public async Task<OrganizationPresence> UpdatePresenceDefinitionLegacyAsync(string presenceId, OrganizationPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(presenceId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/presencedefinitions/{Uri.EscapeDataString(presenceId)}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<UserPresence>> UpdateUsersPresencesBulkAsync(IEnumerable<MutableUserPresence> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/users/presences/bulk", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<UserPresence>>(_options, cancellationToken);
    }
}
