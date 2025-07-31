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
public sealed class OrganizationAuthorizationApi : IOrganizationAuthorizationApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public OrganizationAuthorizationApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<TrustEntityListing> GetTrusteesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustees", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> GetTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> CreateTrusteeAsync(TrustCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("api/v2/orgauthorization/trustees", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> UpdateTrusteeAsync(string trusteeOrgId, TrustUpdate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeAsync(string trusteeOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeClonedUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/clonedusers/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}/roles", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}/roles", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrusteesAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(ids);

        var parameters = new NameValueCollection();

        foreach (var id in ids)
        {
            parameters.Add("id", UriHelper.ParameterToString(id));
        }

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustees", parameters);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/clonedusers/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trustorGroupId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/groups/{Uri.EscapeDataString(trustorGroupId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.DeleteAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteTrustorsAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(ids);

        var parameters = new NameValueCollection();

        foreach (var id in ids)
        {
            parameters.Add("id", UriHelper.ParameterToString(id));
        }

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustors", parameters);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<TrustRequest> GetPairingAsync(string pairingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(pairingId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/pairings/{Uri.EscapeDataString(pairingId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustRequest>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ClonedUserEntityListing> GetTrusteeClonedUsersAsync(string trusteeOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/clonedusers", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ClonedUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroup> GetTrusteeGroupAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> GetTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}/roles", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroupEntityListing> GetTrusteeGroupsAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroupEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUser> GetTrusteeUserAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUser>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> GetTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}/roles", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUserEntityListing> GetTrusteeUsersAsync(string trusteeOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrusteeReferenceList> GetTrusteesCareAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/orgauthorization/trustees/care", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrusteeReferenceList>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> GetTrusteesDefaultAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/orgauthorization/trustees/default", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustorEntityListing> GetTrustorsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustors", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustorEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustor> GetTrustorAsync(string trustorOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustor>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ClonedUser> GetTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/clonedusers/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ClonedUser>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ClonedUserEntityListing> GetTrustorClonedUsersAsync(string trustorOrgId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/clonedusers", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ClonedUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroup> GetTrustorGroupAsync(string trustorOrgId, string trustorGroupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trustorGroupId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/groups/{Uri.EscapeDataString(trustorGroupId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroupEntityListing> GetTrustorGroupsAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/groups", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroupEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUser> GetTrustorUserAsync(string trustorOrgId, string trusteeUserId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);

        var response = await _httpClient.GetAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUser>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUserEntityListing> GetTrustorUsersAsync(string trustorOrgId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/users", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUserEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustRequest> CreatePairingAsync(TrustRequestCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("api/v2/orgauthorization/pairings", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustRequest>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroup> CreateTrusteeGroupAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUser> CreateTrusteeUserAsync(string trusteeOrgId, TrustMemberCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUser>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustEntityListing> CreateTrusteesAuditsAsync(TrusteeAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustees/audits", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustEntityListing> CreateTrusteesCareAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsync("api/v2/orgauthorization/trustees/care", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Trustee> CreateTrusteesDefaultAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsync("api/v2/orgauthorization/trustees/default", null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Trustee>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustorEntityListing> CreateTrustorAuditsAsync(TrustorAuditQueryRequest body, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        var uri = UriHelper.GetUri("api/v2/orgauthorization/trustor/audits", parameters);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustorEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> UpdateTrusteeGroupRoleDivisionsAsync(string trusteeOrgId, string trusteeGroupId, object body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}/roledivisions", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> UpdateTrusteeGroupRolesAsync(string trusteeOrgId, string trusteeGroupId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/groups/{Uri.EscapeDataString(trusteeGroupId)}/roles", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> UpdateTrusteeUserRoleDivisionsAsync(string trusteeOrgId, string trusteeUserId, object body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}/roledivisions", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UserAuthorization> UpdateTrusteeUserRolesAsync(string trusteeOrgId, string trusteeUserId, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trusteeOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustees/{Uri.EscapeDataString(trusteeOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}/roles", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserAuthorization>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ClonedUser> UpdateTrustorClonedUserAsync(string trustorOrgId, string trusteeUserId, ClonedUser body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/clonedusers/{Uri.EscapeDataString(trusteeUserId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ClonedUser>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustGroup> UpdateTrustorGroupAsync(string trustorOrgId, string trustorGroupId, TrustGroup body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trustorGroupId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/groups/{Uri.EscapeDataString(trustorGroupId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustGroup>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrustUser> UpdateTrustorUserAsync(string trustorOrgId, string trusteeUserId, TrustUser body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(trustorOrgId);
        ArgumentException.ThrowIfNullOrEmpty(trusteeUserId);
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PutAsJsonAsync($"api/v2/orgauthorization/trustors/{Uri.EscapeDataString(trustorOrgId)}/users/{Uri.EscapeDataString(trusteeUserId)}", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrustUser>(_options, cancellationToken);
    }
}
