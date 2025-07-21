using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class WebChatApi : IWebChatApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public WebChatApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    // get methods

    public async Task<WebChatSettings> GetSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/webchat/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebChatSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    // put methods

    public async Task<WebChatSettings> UpdateSettingsAsync(WebChatSettings body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync("api/v2/webchat/settings", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WebChatSettings>(_options.JsonSerializerOptions, cancellationToken);
    }

    // post methods

    public async Task<CreateWebChatConversationResponse> CreateGuestConversationAsync(CreateWebChatConversationRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/webchat/guest/conversations", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CreateWebChatConversationResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    // delete methods

    public async Task<bool> DeleteSettingsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/webchat/settings", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }
}