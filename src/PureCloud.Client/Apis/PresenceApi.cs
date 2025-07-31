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
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public PresenceApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<bool> DeletePresenceDefinitionAsync(string definitionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/presence/definitions/{Uri.EscapeDataString(definitionId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeletePresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use DeletePresenceDefinitionAsync instead")]
    public async Task<bool> DeletePresenceDefinitionLegacyAsync(string presenceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(presenceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/presencedefinitions/{Uri.EscapeDataString(presenceId)}", cancellationToken);

        return response.IsSuccessStatusCode;
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinitionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> GetPresenceSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/presence/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> GetPresenceSourceAsync(string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SourceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPrimarySource> GetUserPrimarySourceAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/presence/users/{Uri.EscapeDataString(userId)}/primarysource", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPrimarySource>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options.JsonSerializerOptions, cancellationToken);
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SystemPresence[]> GetSystemPresencesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/systempresences", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SystemPresence[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> GetUserPresenceAsync(string userId, string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/{Uri.EscapeDataString(sourceId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> GetUserPresencePurecloudAsync(string userId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/purecloud", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UcUserPresence[]> GetUsersPresenceBulkAsync(string sourceId, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UcUserPresence[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UcUserPresence[]> GetUsersPresencesPurecloudBulkAsync(IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UcUserPresence[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> UpdateUserPresenceAsync(string userId, string sourceId, UserPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/{Uri.EscapeDataString(sourceId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence> UpdateUserPresencePurecloudAsync(string userId, UserPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/users/{Uri.EscapeDataString(userId)}/presences/purecloud", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> CreatePresenceDefinitionAsync(OrganizationPresenceDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/presence/definitions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> CreatePresenceSourceAsync(Source body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/presence/sources", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use CreatePresenceDefinitionAsync instead")]
    public async Task<OrganizationPresence> CreatePresenceDefinitionLegacyAsync(OrganizationPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/presencedefinitions", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrganizationPresenceDefinition> UpdatePresenceDefinitionAsync(string definitionId, OrganizationPresenceDefinition body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(definitionId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/presence/definitions/{Uri.EscapeDataString(definitionId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresenceDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PresenceSettings> UpdatePresenceSettingsAsync(PresenceSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/presence/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PresenceSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Source> UpdatePresenceSourceAsync(string sourceId, Source body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sourceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/presence/sources/{Uri.EscapeDataString(sourceId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Source>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPrimarySource> UpdateUserPrimarySourceAsync(string userId, UserPrimarySource body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/presence/users/{Uri.EscapeDataString(userId)}/primarysource", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPrimarySource>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete("Apps should migrate to use UpdatePresenceDefinitionAsync instead")]
    public async Task<OrganizationPresence> UpdatePresenceDefinitionLegacyAsync(string presenceId, OrganizationPresence body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(presenceId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/presencedefinitions/{Uri.EscapeDataString(presenceId)}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OrganizationPresence>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserPresence[]> UpdateUsersPresencesBulkAsync(IEnumerable<MutableUserPresence> body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/users/presences/bulk", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserPresence[]>(_options.JsonSerializerOptions, cancellationToken);
    }
}
