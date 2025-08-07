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

    /// <inheritdoc />
    public async Task<GuestCategoryResponseListing> GetKnowledgeGuestSessionCategoriesAsync(string sessionId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

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

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GuestCategoryResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestDocumentResponse> GetKnowledgeGuestSessionDocumentAsync(string sessionId, string documentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> GetKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LabelResponse> GetKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(labelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/labels/{Uri.EscapeDataString(labelId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LabelResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentFeedbackResponseListing> GetKnowledgeKnowledgebaseDocumentFeedbackAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, bool? onlyCommented = null, string documentVersionId = null, string documentVariationId = null, string appType = null, string queryType = null, string userId = null, string queueId = null, string state = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

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

        if (onlyCommented.HasValue)
        {
            parameters.Add("onlyCommented", UriHelper.ParameterToString(onlyCommented.Value));
        }

        if (!string.IsNullOrEmpty(documentVersionId))
        {
            parameters.Add("documentVersionId", UriHelper.ParameterToString(documentVersionId));
        }

        if (!string.IsNullOrEmpty(documentVariationId))
        {
            parameters.Add("documentVariationId", UriHelper.ParameterToString(documentVariationId));
        }

        if (!string.IsNullOrEmpty(appType))
        {
            parameters.Add("appType", UriHelper.ParameterToString(appType));
        }

        if (!string.IsNullOrEmpty(queryType))
        {
            parameters.Add("queryType", UriHelper.ParameterToString(queryType));
        }

        if (!string.IsNullOrEmpty(userId))
        {
            parameters.Add("userId", UriHelper.ParameterToString(userId));
        }

        if (!string.IsNullOrEmpty(queueId))
        {
            parameters.Add("queueId", UriHelper.ParameterToString(queueId));
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", UriHelper.ParameterToString(state));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/feedback", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentFeedbackResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentFeedbackResponse> GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdAsync(string knowledgeBaseId, string documentId, string feedbackId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(feedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/feedback/{Uri.EscapeDataString(feedbackId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentFeedbackResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentVariationResponse> GetKnowledgeKnowledgebaseDocumentVariationAsync(string documentVariationId, string documentId, string knowledgeBaseId, string documentState = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentVariationId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(documentState))
        {
            parameters.Add("documentState", UriHelper.ParameterToString(documentState));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/variations/{Uri.EscapeDataString(documentVariationId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentVariationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentVariationResponseListing> GetKnowledgeKnowledgebaseDocumentVariationsAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, string documentState = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

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

        if (!string.IsNullOrEmpty(documentState))
        {
            parameters.Add("documentState", UriHelper.ParameterToString(documentState));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/variations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentVariationResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentVersion> GetKnowledgeKnowledgebaseDocumentVersionAsync(string knowledgeBaseId, string documentId, string versionId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/versions/{Uri.EscapeDataString(versionId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentVersion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentVersionVariation> GetKnowledgeKnowledgebaseDocumentVersionVariationAsync(string knowledgeBaseId, string documentId, string versionId, string variationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

        ArgumentException.ThrowIfNullOrEmpty(variationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/versions/{Uri.EscapeDataString(versionId)}/variations/{Uri.EscapeDataString(variationId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentVersionVariation>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentVersionVariationListing> GetKnowledgeKnowledgebaseDocumentVersionVariationsAsync(string knowledgeBaseId, string documentId, string versionId, string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(versionId);

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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/versions/{Uri.EscapeDataString(versionId)}/variations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentVersionVariationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentVersionListing> GetKnowledgeKnowledgebaseDocumentVersionsAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

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

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/versions", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentVersionListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeExportJobResponse> GetKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(exportJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/export/jobs/{Uri.EscapeDataString(exportJobId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeExportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryListing> GetKnowledgeKnowledgebaseLanguageCategoriesAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeExtendedCategory> GetKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeExtendedCategory>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentContentUpload> GetKnowledgeKnowledgebaseLanguageDocumentUploadAsync(string documentId, string knowledgeBaseId, string languageCode, string uploadId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(uploadId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/{Uri.EscapeDataString(documentId)}/uploads/{Uri.EscapeDataString(uploadId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentContentUpload>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null, string sortBy = null, string sortOrder = null, IEnumerable<string> documentIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(categories))
        {
            parameters.Add("categories", UriHelper.ParameterToString(categories));
        }

        if (!string.IsNullOrEmpty(title))
        {
            parameters.Add("title", UriHelper.ParameterToString(title));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (documentIds != null)
        {
            foreach (var id in documentIds)
            {
                parameters.Add("documentIds", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeImport> GetKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(importId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/imports/{Uri.EscapeDataString(importId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(trainingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/trainings/{Uri.EscapeDataString(trainingId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeTraining>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", UriHelper.ParameterToString(before));
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", UriHelper.ParameterToString(after));
        }

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", UriHelper.ParameterToString(limit));
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize));
        }

        if (!string.IsNullOrEmpty(knowledgeDocumentsState))
        {
            parameters.Add("knowledgeDocumentsState", UriHelper.ParameterToString(knowledgeDocumentsState));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/trainings", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrainingListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OperationListing> GetKnowledgeKnowledgebaseOperationsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, IEnumerable<string> userId = null, IEnumerable<string> type = null, IEnumerable<string> status = null, string interval = null, IEnumerable<string> sourceId = null, CancellationToken cancellationToken = default)
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

        if (userId != null)
        {
            foreach (var id in userId)
            {
                parameters.Add("userId", UriHelper.ParameterToString(id));
            }
        }

        if (type != null)
        {
            foreach (var item in type)
            {
                parameters.Add("type", UriHelper.ParameterToString(item));
            }
        }

        if (status != null)
        {
            foreach (var item in status)
            {
                parameters.Add("status", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", UriHelper.ParameterToString(interval));
        }

        if (sourceId != null)
        {
            foreach (var id in sourceId)
            {
                parameters.Add("sourceId", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/operations", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OperationListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OperationCreatorUserResponse> GetKnowledgeKnowledgebaseOperationsUsersQueryAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/operations/users/query", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OperationCreatorUserResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeParseJobResponse> GetKnowledgeKnowledgebaseParseJobAsync(string knowledgeBaseId, string parseJobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(parseJobId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/parse/jobs/{Uri.EscapeDataString(parseJobId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeParseJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<SourceBaseResponse>> GetKnowledgeKnowledgebaseSourcesAsync(string knowledgeBaseId, string type = null, IEnumerable<string> expand = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", UriHelper.ParameterToString(type));
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        if (ids != null)
        {
            foreach (var id in ids)
            {
                parameters.Add("ids", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/sources", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<SourceBaseResponse>>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SalesforceSourceResponse> GetKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/sources/salesforce/{Uri.EscapeDataString(sourceId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SalesforceSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ServiceNowSourceResponse> GetKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/sources/servicenow/{Uri.EscapeDataString(sourceId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceNowSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeSyncJobResponse> GetKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(syncJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/synchronize/jobs/{Uri.EscapeDataString(syncJobId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeSyncJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeIntegrationOptionsResponse> GetKnowledgeIntegrationOptionsAsync(string integrationId, IEnumerable<string> knowledgeBaseIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(integrationId);

        var parameters = new NameValueCollection();

        if (knowledgeBaseIds != null)
        {
            foreach (var id in knowledgeBaseIds)
            {
                parameters.Add("knowledgeBaseIds", UriHelper.ParameterToString(id));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/integrations/{Uri.EscapeDataString(integrationId)}/options", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeIntegrationOptionsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnansweredGroup> GetKnowledgeKnowledgebaseUnansweredGroupAsync(string knowledgeBaseId, string groupId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(groupId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(app))
        {
            parameters.Add("app", UriHelper.ParameterToString(app));
        }

        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }

        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/unanswered/groups/{Uri.EscapeDataString(groupId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnansweredGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnansweredPhraseGroup> GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroupAsync(string knowledgeBaseId, string groupId, string phraseGroupId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentException.ThrowIfNullOrEmpty(phraseGroupId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(app))
        {
            parameters.Add("app", UriHelper.ParameterToString(app));
        }

        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }

        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/unanswered/groups/{Uri.EscapeDataString(groupId)}/phrasegroups/{Uri.EscapeDataString(phraseGroupId)}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnansweredPhraseGroup>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnansweredGroups> GetKnowledgeKnowledgebaseUnansweredGroupsAsync(string knowledgeBaseId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(app))
        {
            parameters.Add("app", UriHelper.ParameterToString(app));
        }

        if (!string.IsNullOrEmpty(dateStart))
        {
            parameters.Add("dateStart", UriHelper.ParameterToString(dateStart));
        }

        if (!string.IsNullOrEmpty(dateEnd))
        {
            parameters.Add("dateEnd", UriHelper.ParameterToString(dateEnd));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/unanswered/groups", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnansweredGroups>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync(string knowledgeBaseId, string jobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/uploads/urls/jobs/{Uri.EscapeDataString(jobId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GetUploadSourceUrlJobStatusResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> PatchKnowledgeKnowledgebaseAsync(string knowledgeBaseId, KnowledgeBaseUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentFeedbackResponse> PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdAsync(string knowledgeBaseId, string documentId, string feedbackId, KnowledgeDocumentFeedbackUpdateRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(feedbackId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/feedback/{Uri.EscapeDataString(feedbackId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentFeedbackResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentVariationResponse> PatchKnowledgeKnowledgebaseDocumentVariationAsync(string documentVariationId, string documentId, string knowledgeBaseId, DocumentVariationRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentVariationId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/{Uri.EscapeDataString(documentId)}/variations/{Uri.EscapeDataString(documentVariationId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentVariationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeImportJobResponse> PatchKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, ImportStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(importJobId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/import/jobs/{Uri.EscapeDataString(importJobId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LabelResponse> PatchKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, LabelUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(labelId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/labels/{Uri.EscapeDataString(labelId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LabelResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeExtendedCategory> PatchKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeExtendedCategory>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocument> PatchKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentListing> PatchKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, IEnumerable<KnowledgeDocumentBulkRequest> body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeImport> PatchKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, ImportStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(importId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/imports/{Uri.EscapeDataString(importId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImport>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeSyncJobResponse> PatchKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, SyncStatusRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(syncJobId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/synchronize/jobs/{Uri.EscapeDataString(syncJobId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeSyncJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UnansweredPhraseGroupUpdateResponse> PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroupAsync(string knowledgeBaseId, string groupId, string phraseGroupId, UnansweredPhraseGroupPatchRequestBody body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(groupId);

        ArgumentException.ThrowIfNullOrEmpty(phraseGroupId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/unanswered/groups/{Uri.EscapeDataString(groupId)}/phrasegroups/{Uri.EscapeDataString(phraseGroupId)}", null);

        var response = await client.PatchAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UnansweredPhraseGroupUpdateResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync(UploadUrlRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/knowledge/documentuploads", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UploadUrlResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestDocumentFeedback> PostKnowledgeGuestSessionDocumentFeedbackAsync(string sessionId, string documentId, KnowledgeGuestDocumentFeedback body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents/{Uri.EscapeDataString(documentId)}/feedback", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentFeedback>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestAnswerDocumentsResponse> PostKnowledgeGuestSessionDocumentsAnswersAsync(string sessionId, KnowledgeDocumentsAnswerFilter body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents/answers", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestAnswerDocumentsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentGuestSearch> PostKnowledgeGuestSessionDocumentsSearchAsync(string sessionId, IEnumerable<string> expand = null, KnowledgeDocumentGuestSearchRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents/search", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentGuestSearch>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestDocumentSuggestion> PostKnowledgeGuestSessionDocumentsSearchSuggestionsAsync(string sessionId, KnowledgeGuestDocumentSuggestionRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{Uri.EscapeDataString(sessionId)}/documents/search/suggestions", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentSuggestion>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeGuestSession> PostKnowledgeGuestSessionsAsync(KnowledgeGuestSession body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/knowledge/guest/sessions", null);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestSession>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeCategory> DeleteKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/categories/{Uri.EscapeDataString(categoryId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeCategory>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/languages/{Uri.EscapeDataString(languageCode)}/documents/{Uri.EscapeDataString(documentId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentQueryResponse> PostKnowledgeKnowledgebaseDocumentsQueryAsync(string knowledgeBaseId, IEnumerable<string> expand = null, KnowledgeDocumentQuery body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", UriHelper.ParameterToString(item));
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{Uri.EscapeDataString(knowledgeBaseId)}/documents/query", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentQueryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}
