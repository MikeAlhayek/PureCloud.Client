using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class SCIMApi : ISCIMApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public SCIMApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    
    public async Task<ScimUserListResponse> GetScimUsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (startIndex.HasValue)
        {
            parameters.Add("startIndex", startIndex.Value.ToString());
        }

        if (count.HasValue)
        {
            parameters.Add("count", count.Value.ToString());
        }

        if (attributes?.Any() == true)
        {
            parameters.Add("attributes", string.Join(",", attributes));
        }

        if (excludedAttributes?.Any() == true)
        {
            parameters.Add("excludedAttributes", string.Join(",", excludedAttributes));
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", filter);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/scim/users", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimUserListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    
    public async Task<ScimV2User> GetScimUserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (attributes?.Any() == true)
        {
            parameters.Add("attributes", string.Join(",", attributes));
        }

        if (excludedAttributes?.Any() == true)
        {
            parameters.Add("excludedAttributes", string.Join(",", excludedAttributes));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/scim/users/{userId}", parameters);

        var request = new HttpRequestMessage(HttpMethod.Get, uri);

        if (!string.IsNullOrEmpty(ifNoneMatch))
        {
            request.Headers.Add("If-None-Match", ifNoneMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2User>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    
    public async Task<ScimV2User> CreateScimUserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("/api/v2/scim/users", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2User>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    
    public async Task<ScimV2User> UpdateScimUserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Put, $"/api/v2/scim/users/{userId}")
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2User>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    
    public async Task DeleteScimUserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Delete, $"/api/v2/scim/users/{userId}");

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}
