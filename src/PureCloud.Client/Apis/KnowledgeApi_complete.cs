using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Web;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class KnowledgeApiComplete : IKnowledgeApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public KnowledgeApiComplete(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    #region Helper Methods

    private static string BuildQueryString(params (string name, object value)[] parameters)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        
        foreach (var (name, value) in parameters)
        {
            if (value != null)
            {
                switch (value)
                {
                    case IEnumerable<string> list:
                        foreach (var item in list)
                            query.Add(name, item);
                        break;
                    case IEnumerable<object> enumList:
                        foreach (var item in enumList)
                            query.Add(name, item.ToString());
                        break;
                    default:
                        query.Add(name, value.ToString());
                        break;
                }
            }
        }
        
        return query.ToString();
    }

    #endregion

    #region Core Knowledge Base Operations

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
    public async Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/knowledge/knowledgebases", body, _options.JsonSerializerOptions, cancellationToken);

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
    public async Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBase>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryString = BuildQueryString(
            ("before", before),
            ("after", after),
            ("limit", limit),
            ("pageSize", pageSize),
            ("name", name),
            ("coreLanguage", coreLanguage),
            ("published", published),
            ("sortBy", sortBy),
            ("sortOrder", sortOrder)
        );

        var uri = "api/v2/knowledge/knowledgebases";
        if (!string.IsNullOrEmpty(queryString))
            uri += $"?{queryString}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeBaseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    #endregion

    #region Document Operations

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, List<string> expand = null, string state = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryString = BuildQueryString(
            ("expand", expand),
            ("state", state)
        );

        var uri = $"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}";
        if (!string.IsNullOrEmpty(queryString))
            uri += $"?{queryString}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, bool? includeSubcategories = null, bool? includeDrafts = null, List<string> categories = null, string title = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryString = BuildQueryString(
            ("before", before),
            ("after", after),
            ("pageSize", pageSize),
            ("includeSubcategories", includeSubcategories),
            ("includeDrafts", includeDrafts),
            ("categories", categories),
            ("title", title),
            ("sortBy", sortBy),
            ("sortOrder", sortOrder)
        );

        var uri = $"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents";
        if (!string.IsNullOrEmpty(queryString))
            uri += $"?{queryString}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponseListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(documentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/{documentId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    #endregion

    #region Export Operations

    /// <inheritdoc />
    public async Task<KnowledgeExportJobResponse> GetKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(exportJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeExportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeExportJobResponse> PostKnowledgeKnowledgebaseExportJobsAsync(string knowledgeBaseId, KnowledgeExportJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeExportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(exportJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/export/jobs/{exportJobId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    #endregion

    #region Import Operations

    /// <inheritdoc />
    public async Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(importJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseImportJobsAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeImportJobResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(importJobId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/import/jobs/{importJobId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    #endregion

    #region Training Operations

    /// <inheritdoc />
    public async Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);
        ArgumentException.ThrowIfNullOrEmpty(trainingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeTraining>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, KnowledgeTraining.StatusEnum? knowledgeTrainingState = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryString = BuildQueryString(
            ("before", before),
            ("after", after),
            ("limit", limit),
            ("pageSize", pageSize),
            ("knowledgeTrainingState", knowledgeTrainingState)
        );

        var uri = $"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings";
        if (!string.IsNullOrEmpty(queryString))
            uri += $"?{queryString}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TrainingListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings", new object(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeTraining>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);
        ArgumentException.ThrowIfNullOrEmpty(trainingId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/trainings/{trainingId}/promote", new object(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeTraining>(_options.JsonSerializerOptions, cancellationToken);
    }

    #endregion

    #region Search Operations

    /// <inheritdoc />
    public async Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/search", body ?? new KnowledgeSearchRequest(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeSearchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocumentSearch> PostKnowledgeKnowledgebaseDocumentsSearchAsync(string knowledgeBaseId, KnowledgeDocumentSearchRequest body = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/documents/search", body ?? new KnowledgeDocumentSearchRequest(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocumentSearch>(_options.JsonSerializerOptions, cancellationToken);
    }

    #endregion

    #region Language Document Operations

    /// <inheritdoc />
    public async Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null, string sortBy = null, string sortOrder = null, List<string> documentIds = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var queryString = BuildQueryString(
            ("before", before),
            ("after", after),
            ("limit", limit),
            ("pageSize", pageSize),
            ("categories", categories),
            ("title", title),
            ("sortBy", sortBy),
            ("sortOrder", sortOrder),
            ("documentIds", documentIds)
        );

        var uri = $"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents";
        if (!string.IsNullOrEmpty(queryString))
            uri += $"?{queryString}";

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DocumentListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(documentId);
        ArgumentException.ThrowIfNullOrEmpty(knowledgeBaseId);
        ArgumentException.ThrowIfNullOrEmpty(languageCode);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/knowledge/knowledgebases/{knowledgeBaseId}/languages/{languageCode}/documents/{documentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<KnowledgeDocument>(_options.JsonSerializerOptions, cancellationToken);
    }

    #endregion
}