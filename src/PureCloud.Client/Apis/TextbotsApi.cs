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
public sealed class TextbotsApi : ITextbotsApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public TextbotsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<BotSearchResponseEntityListing> GetTextbotsBotsSearchAsync(IEnumerable<string> botType = null, string botName = null, IEnumerable<string> botId = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (botType != null)
        {
            foreach (var item in botType)
            {
                parameters.Add("botType", UriHelper.ParameterToString(item));
            }
        }

        if (!string.IsNullOrEmpty(botName))
        {
            parameters.Add("botName", UriHelper.ParameterToString(botName));
        }

        if (botId != null)
        {
            foreach (var item in botId)
            {
                parameters.Add("botId", UriHelper.ParameterToString(item));
            }
        }

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        var uri = parameters.Count > 0 
            ? UriHelper.GetUri("api/v2/textbots/bots/search", parameters)
            : "api/v2/textbots/bots/search";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotSearchResponseEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TextBotFlowTurnResponse> CreateTextbotsBotflowsSessionTurnsAsync(string sessionId, TextBotFlowTurnRequest turnRequest, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        ArgumentNullException.ThrowIfNull(turnRequest);

        var uri = $"api/v2/textbots/botflows/sessions/{Uri.EscapeDataString(sessionId)}/turns";

        var response = await _httpClient.PostAsJsonAsync(uri, turnRequest, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TextBotFlowTurnResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TextBotFlowLaunchResponse> CreateTextbotsBotflowsSessionsAsync(TextBotFlowLaunchRequest launchRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(launchRequest);

        var uri = "api/v2/textbots/botflows/sessions";

        var response = await _httpClient.PostAsJsonAsync(uri, launchRequest, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TextBotFlowLaunchResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PostTextResponse> CreateTextbotsBotsExecuteAsync(PostTextRequest postTextRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(postTextRequest);

        var uri = "api/v2/textbots/bots/execute";

        var response = await _httpClient.PostAsJsonAsync(uri, postTextRequest, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PostTextResponse>(_options, cancellationToken);
    }
}