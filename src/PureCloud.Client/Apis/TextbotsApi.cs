using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class TextbotsApi : ITextbotsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public TextbotsApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = parameters.Count > 0 
            ? UriHelper.GetUri("api/v2/textbots/bots/search", parameters)
            : "api/v2/textbots/bots/search";

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BotSearchResponseEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TextBotFlowTurnResponse> CreateTextbotsBotflowsSessionTurnsAsync(string sessionId, TextBotFlowTurnRequest turnRequest, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(sessionId);

        ArgumentNullException.ThrowIfNull(turnRequest);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = $"api/v2/textbots/botflows/sessions/{Uri.EscapeDataString(sessionId)}/turns";

        var response = await client.PostAsJsonAsync(uri, turnRequest, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TextBotFlowTurnResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TextBotFlowLaunchResponse> CreateTextbotsBotflowsSessionsAsync(TextBotFlowLaunchRequest launchRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(launchRequest);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/textbots/botflows/sessions";

        var response = await client.PostAsJsonAsync(uri, launchRequest, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TextBotFlowLaunchResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PostTextResponse> CreateTextbotsBotsExecuteAsync(PostTextRequest postTextRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(postTextRequest);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = "api/v2/textbots/bots/execute";

        var response = await client.PostAsJsonAsync(uri, postTextRequest, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PostTextResponse>(_options.JsonSerializerOptions, cancellationToken);
    }
}