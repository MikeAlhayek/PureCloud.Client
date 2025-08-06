using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class KnowledgeApi : IKnowledgeApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public KnowledgeApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/knowledge/knowledgebases", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SalesforceSourceResponse> UpdateKnowledgeKnowledgebaseSourcesSalesforceSourceAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}", null);

        var response = await client.PutAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SalesforceSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(coreLanguage))
        {
            parameters.Add("coreLanguage", UriHelper.ParameterToString(coreLanguage));
        }

        if (published.HasValue)
        {
            parameters.Add("published", UriHelper.ParameterToString(published.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/knowledge/knowledgebases", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBaseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponseListing> GetKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(parentId))
        {
            parameters.Add("parentId", UriHelper.ParameterToString(parentId));
        }

        if (isRoot.HasValue)
        {
            parameters.Add("isRoot", UriHelper.ParameterToString(isRoot.Value));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (includeDocumentCount.HasValue)
        {
            parameters.Add("includeDocumentCount", UriHelper.ParameterToString(includeDocumentCount.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> CreateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/categories", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> UpdateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, IEnumerable<string> documentId = null, IEnumerable<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, IEnumerable<string> labelIds = null, IEnumerable<string> expand = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", UriHelper.ParameterToString(interval));
        }

        if (documentId != null)
        {
            foreach (var id in documentId)
            {
                parameters.Add("documentId", UriHelper.ParameterToString(id));
            }
        }

        if (categoryId != null)
        {
            foreach (var id in categoryId)
            {
                parameters.Add("categoryId", UriHelper.ParameterToString(id));
            }
        }

        if (includeSubcategories.HasValue)
        {
            parameters.Add("includeSubcategories", UriHelper.ParameterToString(includeSubcategories.Value));
        }

        if (includeDrafts.HasValue)
        {
            parameters.Add("includeDrafts", UriHelper.ParameterToString(includeDrafts.Value));
        }

        if (labelIds != null)
        {
            foreach (var id in labelIds)
            {
                parameters.Add("labelIds", UriHelper.ParameterToString(id));
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (externalIds != null)
        {
            foreach (var id in externalIds)
            {
                parameters.Add("externalIds", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, IEnumerable<string> expand = null, string state = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> CreateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> UpdateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<LabelListing> GetKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (includeDocumentCount.HasValue)
        {
            parameters.Add("includeDocumentCount", UriHelper.ParameterToString(includeDocumentCount.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/labels", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LabelListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LabelResponse> CreateKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/labels", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LabelResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(labelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/labels/{Uri.EscapeDataString(labelId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(importJobId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/import/jobs/{Uri.EscapeDataString(importJobId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeImportJobResponse> CreateKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/import/jobs", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeSearchResponse> CreateKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/search", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestDocumentResponseListing> GetKnowledgeGuestSessionDocumentsAsync(string sessionId, IEnumerable<string> categoryId = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var parameters = new NameValueCollection();

        if (categoryId != null)
        {
            foreach (var id in categoryId)
            {
                parameters.Add("categoryId", UriHelper.ParameterToString(id));
            }
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }
}
