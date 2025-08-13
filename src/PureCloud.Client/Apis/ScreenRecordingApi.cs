using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class ScreenRecordingApi : IScreenRecordingApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public ScreenRecordingApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<SignedData> CreateScreenrecordingTokenAsync(ScreenRecordingUserAuthenticatedInfo body = null, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsJsonAsync("api/v2/screenrecording/token", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SignedData>(_options, cancellationToken);
    }
}