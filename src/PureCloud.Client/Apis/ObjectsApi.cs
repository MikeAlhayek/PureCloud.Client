using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class ObjectsApi : IObjectsApi
{
    private readonly HttpClient _httpClient;
    private readonly PureCloudJsonSerializerOptions _options;

    public ObjectsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<AuthzDivision> GetAuthorizationDivisionAsync(string divisionId, bool? objectCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();

        if (objectCount.HasValue)
        {
            parameters.Add("objectCount", UriHelper.ParameterToString(objectCount.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/authorization/divisions/{Uri.EscapeDataString(divisionId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, bool? objectCount = null, IEnumerable<string> id = null, string name = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(nextPage))
        {
            parameters.Add("nextPage", UriHelper.ParameterToString(nextPage));
        }

        if (!string.IsNullOrEmpty(previousPage))
        {
            parameters.Add("previousPage", UriHelper.ParameterToString(previousPage));
        }

        if (objectCount.HasValue)
        {
            parameters.Add("objectCount", UriHelper.ParameterToString(objectCount.Value));
        }

        if (id != null)
        {
            foreach (var item in id)
            {
                parameters.Add("id", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var uri = UriHelper.GetUri("api/v2/authorization/divisions", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AuthzDivision> CreateAuthorizationDivisionAsync(AuthzDivision body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/authorization/divisions", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AuthzDivision> UpdateAuthorizationDivisionAsync(string divisionId, AuthzDivision body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/authorization/divisions/{Uri.EscapeDataString(divisionId)}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteAuthorizationDivisionAsync(string divisionId, bool? force = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        var parameters = new NameValueCollection();

        if (force.HasValue)
        {
            parameters.Add("force", UriHelper.ParameterToString(force.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/authorization/divisions/{Uri.EscapeDataString(divisionId)}", parameters);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<AuthzDivisionEntityListing> GetAuthorizationDivisionsDeletedAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default)
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

        var uri = UriHelper.GetUri("api/v2/authorization/divisions/deleted", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivisionEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AuthzDivision> GetAuthorizationDivisionsHomeAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/authorization/divisions/home", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AuthzDivision>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<int?> GetAuthorizationDivisionsLimitAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("api/v2/authorization/divisions/limit", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<int?>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task CreateAuthorizationDivisionObjectsAsync(string divisionId, string objectType, IEnumerable<string> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(divisionId);

        ArgumentException.ThrowIfNullOrEmpty(objectType);

        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/authorization/divisions/{Uri.EscapeDataString(divisionId)}/objects/{Uri.EscapeDataString(objectType)}", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}