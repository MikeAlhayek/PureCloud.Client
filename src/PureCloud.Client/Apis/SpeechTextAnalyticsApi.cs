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
public sealed class SpeechTextAnalyticsApi : ISpeechTextAnalyticsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public SpeechTextAnalyticsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<ConversationMetrics> GetSpeechTextAnalyticsConversationAsync(string conversationId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(conversationId);

        var uri = UriHelper.GetUri($"/api/v2/speechandtextanalytics/conversations/{conversationId}", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ConversationMetrics>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StaCategory> CreateSpeechTextAnalyticsCategoryAsync(CategoryRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("/api/v2/speechandtextanalytics/categories", null);

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<StaCategory>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<Program> UpdateSpeechTextAnalyticsProgramAsync(string programId, ProgramRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(programId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"/api/v2/speechandtextanalytics/programs/{programId}", null);

        var response = await _httpClient.PutAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Program>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(categoryId);

        var uri = UriHelper.GetUri($"/api/v2/speechandtextanalytics/categories/{categoryId}", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}
