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
    public async Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseDocumentVariationAsync(string knowledgeBaseId, string documentId, string documentVariationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentException.ThrowIfNullOrEmpty(documentVariationId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}/variations/{documentVariationId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(exportJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(importJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(labelId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/labels/{labelId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseLanguageCategoryAsync(string knowledgeBaseId, string languageCode, string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/categories/{categoryId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync(string knowledgeBaseId, string languageCode, string documentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        ArgumentException.ThrowIfNullOrEmpty(importId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/imports/{importId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseSourcesSalesforceAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseSourcesServicenowAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(syncJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/synchronize/jobs/{syncJobId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return true;
    }

    /// <inheritdoc />
    public async Task<GuestCategoryResponseListing> GetKnowledgeGuestSessionCategoriesAsync(string sessionId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(parentId))
        {
            parameters.Add("parentId", parentId);
        }

        if (isRoot.HasValue)
        {
            parameters.Add("isRoot", isRoot.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", expand);
        }

        if (includeDocumentCount.HasValue)
        {
            parameters.Add("includeDocumentCount", includeDocumentCount.Value.ToString().ToLower());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{sessionId}/categories", parameters);

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

        var response = await client.GetAsync($"api/v2/knowledge/guest/sessions/{sessionId}/documents/{documentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
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
                parameters.Add("categoryId", id);
            }
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/guest/sessions/{sessionId}/documents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeGuestDocumentResponseListing>(_options.JsonSerializerOptions, cancellationToken);
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
                parameters.Add("knowledgeBaseIds", id);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/integrations/{integrationId}/options", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeIntegrationOptionsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponseListing> GetKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(parentId))
        {
            parameters.Add("parentId", parentId);
        }

        if (isRoot.HasValue)
        {
            parameters.Add("isRoot", isRoot.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(expand))
        {
            parameters.Add("expand", expand);
        }

        if (includeDocumentCount.HasValue)
        {
            parameters.Add("includeDocumentCount", includeDocumentCount.Value.ToString().ToLower());
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> GetKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/knowledge/knowledgebases", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
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
                parameters.Add("expand", item);
            }
        }

        if (!string.IsNullOrEmpty(state))
        {
            parameters.Add("state", state);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, IEnumerable<string> documentId = null, IEnumerable<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, IEnumerable<string> labelIds = null, IEnumerable<string> expand = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(interval))
        {
            parameters.Add("interval", interval);
        }

        if (documentId != null)
        {
            foreach (var id in documentId)
            {
                parameters.Add("documentId", id);
            }
        }

        if (categoryId != null)
        {
            foreach (var id in categoryId)
            {
                parameters.Add("categoryId", id);
            }
        }

        if (includeSubcategories.HasValue)
        {
            parameters.Add("includeSubcategories", includeSubcategories.Value.ToString().ToLower());
        }

        if (includeDrafts.HasValue)
        {
            parameters.Add("includeDrafts", includeDrafts.Value.ToString().ToLower());
        }

        if (labelIds != null)
        {
            foreach (var id in labelIds)
            {
                parameters.Add("labelIds", id);
            }
        }

        if (expand != null)
        {
            foreach (var item in expand)
            {
                parameters.Add("expand", item);
            }
        }

        if (externalIds != null)
        {
            foreach (var id in externalIds)
            {
                parameters.Add("externalIds", id);
            }
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(before))
        {
            parameters.Add("before", before);
        }

        if (!string.IsNullOrEmpty(after))
        {
            parameters.Add("after", after);
        }

        if (!string.IsNullOrEmpty(limit))
        {
            parameters.Add("limit", limit);
        }

        if (!string.IsNullOrEmpty(pageSize))
        {
            parameters.Add("pageSize", pageSize);
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", name);
        }

        if (!string.IsNullOrEmpty(coreLanguage))
        {
            parameters.Add("coreLanguage", coreLanguage);
        }

        if (published.HasValue)
        {
            parameters.Add("published", published.Value.ToString().ToLower());
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", sortBy);
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", sortOrder);
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/knowledge/knowledgebases", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBaseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> CreateKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> CreateKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CategoryResponse> UpdateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/categories/{categoryId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CategoryResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> UpdateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(documentId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBase> UpdateKnowledgeKnowledgebaseAsync(string knowledgeBaseId, KnowledgeBaseUpdateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", body, _options.JsonSerializerOptions, cancellationToken);

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

        var response = await client.PutAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/salesforce/{sourceId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SalesforceSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ServiceNowSourceResponse> UpdateKnowledgeKnowledgebaseSourcesServicenowSourceAsync(string knowledgeBaseId, string sourceId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        ArgumentException.ThrowIfNullOrEmpty(sourceId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/sources/servicenow/{sourceId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServiceNowSourceResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}
