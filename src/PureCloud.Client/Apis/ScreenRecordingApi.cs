using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class ScreenRecordingApi : IScreenRecordingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public ScreenRecordingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<SignedData> CreateScreenrecordingTokenAsync(ScreenRecordingUserAuthenticatedInfo body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        
        var response = await client.PostAsJsonAsync("api/v2/screenrecording/token", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SignedData>(_options.JsonSerializerOptions, cancellationToken);
    }
}