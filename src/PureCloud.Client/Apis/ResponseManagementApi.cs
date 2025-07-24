using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class ResponseManagementApi : IResponseManagementApiV2
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ResponseManagementApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    // Libraries
    public async Task<SimpleLibraryEntityListing> GetResponseManagementLibrariesAsync(int? pageNumber = null, int? pageSize = null, string messagingTemplateFilter = null, string libraryPrefix = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(messagingTemplateFilter))
        {
            parameters.Add("messagingTemplateFilter", UriHelper.ParameterToString(messagingTemplateFilter));
        }

        if (!string.IsNullOrEmpty(libraryPrefix))
        {
            parameters.Add("libraryPrefix", UriHelper.ParameterToString(libraryPrefix));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/responsemanagement/libraries", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SimpleLibraryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Library> GetResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(libraryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/responsemanagement/libraries/{libraryId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Library>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Library> CreateResponseManagementLibraryAsync(Library body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/responsemanagement/libraries", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Library>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Library> UpdateResponseManagementLibraryAsync(string libraryId, Library body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(libraryId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/responsemanagement/libraries/{libraryId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Library>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteResponseManagementLibraryAsync(string libraryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(libraryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/responsemanagement/libraries/{libraryId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<SimpleLibraryEntityListing> CreateResponseManagementLibrariesBulkAsync(LibraryBatchRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/responsemanagement/libraries/bulk", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SimpleLibraryEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Responses
    public async Task<SimpleResponseEntityListing> GetResponseManagementResponsesAsync(string libraryId, int? pageNumber = null, int? pageSize = null, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(libraryId);

        var parameters = new NameValueCollection();

        parameters.Add("libraryId", UriHelper.ParameterToString(libraryId));

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/responsemanagement/responses", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SimpleResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Response> GetResponseManagementResponseAsync(string responseId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/responsemanagement/responses/{responseId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Response>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Response> CreateResponseManagementResponseAsync(Response body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/responsemanagement/responses", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Response>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Response> UpdateResponseManagementResponseAsync(string responseId, Response body, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/responsemanagement/responses/{responseId}", parameters);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Response>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteResponseManagementResponseAsync(string responseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/responsemanagement/responses/{responseId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<SimpleResponseQueryResults> QueryResponseManagementResponsesAsync(ResponseQueryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/responsemanagement/responses/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SimpleResponseQueryResults>(_options.JsonSerializerOptions, cancellationToken);
    }

    // Response Assets
    public async Task<ResponseAsset> GetResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseAssetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/responsemanagement/responseassets/{responseAssetId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseAsset>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseAsset> UpdateResponseManagementResponseAssetAsync(string responseAssetId, ResponseAssetRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseAssetId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/responsemanagement/responseassets/{responseAssetId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseAsset>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteResponseManagementResponseAssetAsync(string responseAssetId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(responseAssetId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/responsemanagement/responseassets/{responseAssetId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public async Task<ResponseAssetSearchResults> SearchResponseManagementResponseAssetsAsync(ResponseAssetSearchRequest body, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (expand != null && expand.Count > 0)
        {
            parameters.Add("expand", string.Join(",", expand.Select(UriHelper.ParameterToString)));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/responsemanagement/responseassets/search", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseAssetSearchResults>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CreateResponseAssetResponse> UploadResponseManagementResponseAssetAsync(CreateResponseAssetRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/responsemanagement/responseassets/uploads", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CreateResponseAssetResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ResponseAssetStatus> GetResponseManagementResponseAssetStatusAsync(string statusId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(statusId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/responsemanagement/responseassets/status/{statusId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ResponseAssetStatus>(_options.JsonSerializerOptions, cancellationToken);
    }
}
