using System.Collections.Specialized;
using System.Net.Http.Json;
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
    public async Task<bool> DeleteScimUserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Delete, $"api/v2/scim/users/{Uri.EscapeDataString(userId)}");

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteScimV2UserAsync(string userId, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Delete, $"api/v2/scim/v2/users/{Uri.EscapeDataString(userId)}");

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<ScimV2Group> GetScimGroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var parameters = new NameValueCollection();

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scim/groups/{Uri.EscapeDataString(groupId)}", parameters);

        var request = new HttpRequestMessage(HttpMethod.Get, uri);

        if (!string.IsNullOrEmpty(ifNoneMatch))
        {
            request.Headers.Add("If-None-Match", ifNoneMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimGroupListResponse> GetScimGroupsAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (startIndex.HasValue)
        {
            parameters.Add("startIndex", UriHelper.ParameterToString(startIndex.Value));
        }

        if (count.HasValue)
        {
            parameters.Add("count", UriHelper.ParameterToString(count.Value));
        }

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", UriHelper.ParameterToString(filter));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/groups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimGroupListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimConfigResourceType> GetScimResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(resourceType);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/scim/resourcetypes/{Uri.EscapeDataString(resourceType)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimConfigResourceType>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimConfigResourceTypesListResponse> GetScimResourcetypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/scim/resourcetypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimConfigResourceTypesListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2SchemaDefinition> GetScimSchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/scim/schemas/{Uri.EscapeDataString(schemaId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2SchemaDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2SchemaListResponse> GetScimSchemasAsync(string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", UriHelper.ParameterToString(filter));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/schemas", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2SchemaListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimServiceProviderConfig> GetScimServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Get, "api/v2/scim/serviceproviderconfig");

        if (!string.IsNullOrEmpty(ifNoneMatch))
        {
            request.Headers.Add("If-None-Match", ifNoneMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimServiceProviderConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> GetScimUserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scim/users/{Uri.EscapeDataString(userId)}", parameters);

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
    public async Task<ScimUserListResponse> GetScimUsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (startIndex.HasValue)
        {
            parameters.Add("startIndex", UriHelper.ParameterToString(startIndex.Value));
        }

        if (count.HasValue)
        {
            parameters.Add("count", UriHelper.ParameterToString(count.Value));
        }

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", UriHelper.ParameterToString(filter));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/users", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimUserListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2Group> GetScimV2GroupAsync(string groupId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var parameters = new NameValueCollection();

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scim/v2/groups/{Uri.EscapeDataString(groupId)}", parameters);

        var request = new HttpRequestMessage(HttpMethod.Get, uri);

        if (!string.IsNullOrEmpty(ifNoneMatch))
        {
            request.Headers.Add("If-None-Match", ifNoneMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimGroupListResponse> GetScimV2GroupsAsync(string filter, int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(filter);

        var parameters = new NameValueCollection();

        parameters.Add("filter", UriHelper.ParameterToString(filter));

        if (startIndex.HasValue)
        {
            parameters.Add("startIndex", UriHelper.ParameterToString(startIndex.Value));
        }

        if (count.HasValue)
        {
            parameters.Add("count", UriHelper.ParameterToString(count.Value));
        }

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/v2/groups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimGroupListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimConfigResourceType> GetScimV2ResourcetypeAsync(string resourceType, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(resourceType);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/scim/v2/resourcetypes/{Uri.EscapeDataString(resourceType)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimConfigResourceType>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/scim/v2/resourcetypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimConfigResourceTypesListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2SchemaDefinition> GetScimV2SchemaAsync(string schemaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(schemaId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/scim/v2/schemas/{Uri.EscapeDataString(schemaId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2SchemaDefinition>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2SchemaListResponse> GetScimV2SchemasAsync(string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", UriHelper.ParameterToString(filter));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/v2/schemas", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2SchemaListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync(string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Get, "api/v2/scim/v2/serviceproviderconfig");

        if (!string.IsNullOrEmpty(ifNoneMatch))
        {
            request.Headers.Add("If-None-Match", ifNoneMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimServiceProviderConfig>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> GetScimV2UserAsync(string userId, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        var parameters = new NameValueCollection();

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/scim/v2/users/{Uri.EscapeDataString(userId)}", parameters);

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
    public async Task<ScimUserListResponse> GetScimV2UsersAsync(int? startIndex = null, int? count = null, IEnumerable<string> attributes = null, IEnumerable<string> excludedAttributes = null, string filter = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (startIndex.HasValue)
        {
            parameters.Add("startIndex", UriHelper.ParameterToString(startIndex.Value));
        }

        if (count.HasValue)
        {
            parameters.Add("count", UriHelper.ParameterToString(count.Value));
        }

        if (attributes != null)
        {
            foreach (var value in attributes)
            {
                parameters.Add("attributes", UriHelper.ParameterToString(value));
            }
        }

        if (excludedAttributes != null)
        {
            foreach (var value in excludedAttributes)
            {
                parameters.Add("excludedAttributes", UriHelper.ParameterToString(value));
            }
        }

        if (!string.IsNullOrEmpty(filter))
        {
            parameters.Add("filter", UriHelper.ParameterToString(filter));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/scim/v2/users", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimUserListResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2Group> UpdateScimGroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Patch, $"api/v2/scim/groups/{Uri.EscapeDataString(groupId)}")
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> UpdateScimUserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Patch, $"api/v2/scim/users/{Uri.EscapeDataString(userId)}")
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
    public async Task<ScimV2Group> UpdateScimV2GroupAsync(string groupId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Patch, $"api/v2/scim/v2/groups/{Uri.EscapeDataString(groupId)}")
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> UpdateScimV2UserAsync(string userId, ScimV2PatchRequest body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Patch, $"api/v2/scim/v2/users/{Uri.EscapeDataString(userId)}")
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
    public async Task<ScimV2User> CreateScimUserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/scim/users", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2User>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> CreateScimV2UserAsync(ScimV2CreateUser body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/scim/v2/users", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2User>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2Group> ReplaceScimGroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Put, $"api/v2/scim/groups/{Uri.EscapeDataString(groupId)}")
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> ReplaceScimUserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Put, $"api/v2/scim/users/{Uri.EscapeDataString(userId)}")
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
    public async Task<ScimV2Group> ReplaceScimV2GroupAsync(string groupId, ScimV2Group body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Put, $"api/v2/scim/v2/groups/{Uri.EscapeDataString(groupId)}")
        {
            Content = JsonContent.Create(body, options: _options.JsonSerializerOptions)
        };

        if (!string.IsNullOrEmpty(ifMatch))
        {
            request.Headers.Add("If-Match", ifMatch);
        }

        var response = await client.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ScimV2Group>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ScimV2User> ReplaceScimV2UserAsync(string userId, ScimV2User body, string ifMatch = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(userId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var request = new HttpRequestMessage(HttpMethod.Put, $"api/v2/scim/v2/users/{Uri.EscapeDataString(userId)}")
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
}
