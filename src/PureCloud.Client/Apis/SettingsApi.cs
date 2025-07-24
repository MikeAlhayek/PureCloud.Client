using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class SettingsApi : ISettingsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public SettingsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<EmailSettings> GetEmailsSettingsAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/emails/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailSettings> UpdateEmailsSettingsAsync(EmailSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/emails/settings", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailThreadingSettings> GetEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/emails/settings/threading", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailThreadingSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EmailThreadingSettings> UpdateEmailsSettingsThreadingAsync(EmailThreadingSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/emails/settings/threading", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmailThreadingSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/emails/settings/threading", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataAsync(CancellationToken cancellationToken = default)
    {
        var uri = UriHelper.GetUri("api/v2/settings/executiondata", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExecutionDataGlobalSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ExecutionDataGlobalSettingsResponse> UpdateSettingsExecutiondataAsync(ExecutionDataSettingsRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri("api/v2/settings/executiondata", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ExecutionDataGlobalSettingsResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = UriHelper.GetUri($"api/v2/users/agentui/agents/autoanswer/{agentId}/settings", null);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AutoAnswerSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AutoAnswerSettings> UpdateUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = UriHelper.GetUri($"api/v2/users/agentui/agents/autoanswer/{agentId}/settings", null);

        var response = await _httpClient.PatchAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AutoAnswerSettings>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(agentId);

        var uri = UriHelper.GetUri($"api/v2/users/agentui/agents/autoanswer/{agentId}/settings", null);

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}