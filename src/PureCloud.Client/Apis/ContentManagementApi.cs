using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using Document = PureCloud.Client.Models.Document;

namespace PureCloud.Client.Apis;

public class ContentManagementApi : IContentManagementApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ContentManagementApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<bool> DeleteContentmanagementDocumentIdAsync(string documentId, bool? overrideFlag = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId, nameof(documentId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var pathParams = new NameValueCollection
        {
            { "documentId", documentId }
        };

        var queryParams = new NameValueCollection();

        if (overrideFlag.HasValue)
        {
            queryParams["override"] = overrideFlag.Value.ToString().ToLowerInvariant();
        }

        var url = UriHelper.GetUri("api/v2/contentmanagement/documents/{documentId}", pathParams);

        if (queryParams.Count > 0)
        {
            url = UriHelper.GetUri(url, queryParams);
        }

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteContentmanagementShareAsync(string shareId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(shareId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var pathParams = new NameValueCollection { { "shareId", shareId } };

        var url = UriHelper.GetUri("api/v2/contentmanagement/shares/{shareId}", pathParams);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteContentmanagementStatusAsync(string statusId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(statusId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var pathParams = new NameValueCollection { { "statusId", statusId } };

        var url = UriHelper.GetUri("api/v2/contentmanagement/status/{statusId}", pathParams);

        var response = await client.DeleteAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteContentmanagementDocumentAsync(string documentId, bool? overrideFlag = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (overrideFlag.HasValue)
        {
            query["override"] = overrideFlag.Value.ToString().ToLowerInvariant();
        }

        var uri = UriHelper.GetUri($"api/v2/contentmanagement/documents/{documentId}", query);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        ArgumentException.ThrowIfNullOrEmpty(memberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        ArgumentException.ThrowIfNullOrEmpty(tagId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<Document> GetContentmanagementDocumentAsync(string documentId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                query.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/documents/{documentId}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Document>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DownloadResponse> GetContentmanagementDocumentContentAsync(string documentId, string disposition = null, string contentType = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (disposition != null)
        {
            query.Add("disposition", disposition);
        }

        if (contentType != null)
        {
            query.Add("contentType", contentType);
        }

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/documents/{documentId}/content", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DownloadResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DocumentEntityListing> GetContentmanagementDocumentsAsync(string workspaceId, string name = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection
        {
            { "workspaceId", workspaceId }
        };

        if (name != null)
        {
            query.Add("name", name);
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                query.Add("expand", item);
            }
        }

        if (pageSize.HasValue)
        {
            query.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            query.Add("pageNumber", pageNumber.Value.ToString());
        }

        if (sortBy != null)
        {
            query.Add("sortBy", sortBy);
        }

        if (sortOrder != null)
        {
            query.Add("sortOrder", sortOrder);
        }

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/documents", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QueryResults> GetContentmanagementQueryAsync(string queryPhrase, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(queryPhrase, nameof(queryPhrase));

        var queryParameters = new Dictionary<string, string>
        {
            { "queryPhrase", queryPhrase },
            { "pageSize", pageSize?.ToString() },
            { "pageNumber", pageNumber?.ToString() },
            { "sortBy", sortBy },
            { "sortOrder", sortOrder }
        };

        var queryParts = new List<string>();
        foreach (var kvp in queryParameters)
        {
            if (!string.IsNullOrEmpty(kvp.Value))
            {
                queryParts.Add($"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}");
            }
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/query{query}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryResults>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SecurityProfile> GetContentmanagementSecurityprofileAsync(string securityProfileId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(securityProfileId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/securityprofiles/{securityProfileId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SecurityProfile>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SecurityProfileEntityListing> GetContentmanagementSecurityprofilesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/securityprofiles", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SecurityProfileEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Share> GetContentmanagementShareAsync(string shareId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(shareId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                query.Add("expand", item);
            }
        }

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/shares/{shareId}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Share>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SharedResponse> GetContentmanagementSharedAsync(string sharedId, string disposition = null, string contentType = null, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sharedId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (disposition != null)
        {
            query.Add("disposition", disposition);
        }

        if (contentType != null)
        {
            query.Add("contentType", contentType);
        }

        if (expand != null)
        {
            query.Add("expand", expand);
        }

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/shared/{sharedId}", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SharedResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<ShareEntityListing> GetContentmanagementSharesAsync(string entityId = null, List<string> expand = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (entityId != null)
        {
            query.Add("entityId", entityId);
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                query.Add("expand", e);
            }
        }

        if (pageSize.HasValue)
        {
            query.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            query.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/shares", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ShareEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommandStatusEntityListing> GetContentmanagementStatusAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var query = new NameValueCollection();

        if (pageSize.HasValue)
        {
            query.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            query.Add("pageNumber", pageNumber.Value.ToString());
        }

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/status", query);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommandStatusEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommandStatus> GetContentmanagementStatusStatusIdAsync(string statusId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(statusId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/status/{statusId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommandStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Usage> GetContentmanagementUsageAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/usage", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Usage>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Workspace> GetContentmanagementWorkspaceAsync(string workspaceId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId, nameof(workspaceId));

        var queryParts = new List<string>();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(item)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}{query}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workspace>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<DocumentEntityListing> GetContentmanagementWorkspaceDocumentsAsync(string workspaceId, List<string> expand = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        var queryParts = new List<string>();

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        if (pageSize.HasValue)
        {
            queryParts.Add("pageSize=" + pageSize.Value);
        }

        if (pageNumber.HasValue)
        {
            queryParts.Add("pageNumber=" + pageNumber.Value);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            queryParts.Add("sortBy=" + Uri.EscapeDataString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            queryParts.Add("sortOrder=" + Uri.EscapeDataString(sortOrder));
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : "";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/documents{query}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkspaceMember> GetContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId, nameof(workspaceId));

        ArgumentException.ThrowIfNullOrEmpty(memberId, nameof(memberId));

        var queryParts = new List<string>();

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}{query}", null);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkspaceMember>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<WorkspaceMemberEntityListing> GetContentmanagementWorkspaceMembersAsync(string workspaceId, int? pageSize = null, int? pageNumber = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        var queryParts = new List<string>();

        if (pageSize.HasValue)
        {
            queryParts.Add($"pageSize={pageSize.Value}");
        }

        if (pageNumber.HasValue)
        {
            queryParts.Add($"pageNumber={pageNumber.Value}");
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/members{query}", null);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkspaceMemberEntityListing>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<TagValue> GetContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        ArgumentException.ThrowIfNullOrEmpty(tagId);

        var queryParts = new List<string>();

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}{query}", null);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TagValue>(_options.JsonSerializerOptions, cancellationToken)!;
    }

    public async Task<TagValueEntityListing> GetContentmanagementWorkspaceTagvaluesAsync(string workspaceId, string value = null, int? pageSize = null, int? pageNumber = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        var queryParts = new List<string>();
        if (value != null)
        {
            queryParts.Add("value=" + Uri.EscapeDataString(value));
        }

        if (pageSize.HasValue)
        {
            queryParts.Add("pageSize=" + pageSize.Value);
        }

        if (pageNumber.HasValue)
        {
            queryParts.Add("pageNumber=" + pageNumber.Value);
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add("expand=" + Uri.EscapeDataString(e));
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : "";

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues{query}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TagValueEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkspaceEntityListing> GetContentmanagementWorkspacesAsync(int? pageSize = null, int? pageNumber = null, List<string> access = null, List<string> expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParts = new List<string>();

        if (pageSize.HasValue)
        {
            queryParts.Add($"pageSize={pageSize.Value}");
        }

        if (pageNumber.HasValue)
        {
            queryParts.Add($"pageNumber={pageNumber.Value}");
        }

        if (access != null)
        {
            foreach (var a in access)
            {
                queryParts.Add($"access={Uri.EscapeDataString(a)}");
            }
        }

        if (expand != null)
        {
            foreach (var e in expand)
            {
                queryParts.Add($"expand={Uri.EscapeDataString(e)}");
            }
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var url = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces{query}", null);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkspaceEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Document> CreateContentmanagementDocumentAsync(string documentId, DocumentUpdate body, string expand = null, bool? _override = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId, nameof(documentId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParts = new List<string>();

        if (expand != null)
        {
            queryParts.Add($"expand={Uri.EscapeDataString(expand)}");
        }

        if (_override.HasValue)
        {
            queryParts.Add($"override={_override.Value.ToString().ToLower()}");
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/documents/{documentId}{query}", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Document>(_options.JsonSerializerOptions, cancellationToken);
    }


    public async Task<ReplaceResponse> CreateContentmanagementDocumentContentAsync(string documentId, ReplaceRequest body, bool? _override = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId, nameof(documentId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParts = new List<string>();

        if (_override.HasValue)
        {
            queryParts.Add($"override={_override.Value.ToString().ToLower()}");
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/documents/{documentId}/content{query}", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ReplaceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<QueryResults> CreateContentmanagementQueryAsync(QueryRequest body, string expand = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryParts = new List<string>();

        if (expand != null)
        {
            queryParts.Add($"expand={Uri.EscapeDataString(expand)}");
        }

        var query = queryParts.Count > 0 ? "?" + string.Join("&", queryParts) : string.Empty;

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/query{query}", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryResults>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CreateShareResponse> CreateContentmanagementSharesAsync(CreateShareRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/shares", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CreateShareResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TagValue> CreateContentmanagementWorkspaceTagvaluesAsync(string workspaceId, TagValue body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(workspaceId, nameof(workspaceId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TagValue>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Workspace> CreateContentmanagementWorkspacesAsync(WorkspaceCreate body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("/api/v2/contentmanagement/workspaces", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workspace>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<Workspace> UpdateContentmanagementWorkspaceAsync(string workspaceId, Workspace body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(workspaceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Workspace>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<WorkspaceMember> UpdateContentmanagementWorkspaceMemberAsync(string workspaceId, string memberId, WorkspaceMember body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        ArgumentException.ThrowIfNullOrEmpty(memberId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/members/{memberId}", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WorkspaceMember>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<TagValue> UpdateContentmanagementWorkspaceTagvalueAsync(string workspaceId, string tagId, TagValue body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(workspaceId);

        ArgumentException.ThrowIfNullOrEmpty(tagId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"/api/v2/contentmanagement/workspaces/{workspaceId}/tagvalues/{tagId}", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TagValue>(_options.JsonSerializerOptions, cancellationToken);
    }



}
