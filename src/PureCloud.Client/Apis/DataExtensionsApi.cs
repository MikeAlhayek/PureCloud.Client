using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class DataExtensionsApi : IDataExtensionsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public DataExtensionsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<Coretype> GetDataextensionsCoretypeAsync(string coretypeName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(coretypeName);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/dataextensions/coretypes/{coretypeName}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<Coretype>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CoretypeListing> GetDataextensionsCoretypesAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/dataextensions/coretypes", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CoretypeListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<SchemaQuantityLimits> GetDataextensionsLimitsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/dataextensions/limits", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<SchemaQuantityLimits>(_options.JsonSerializerOptions, cancellationToken);
    }

}
