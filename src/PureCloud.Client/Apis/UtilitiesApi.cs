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
public sealed class UtilitiesApi : IUtilitiesApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public UtilitiesApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />

    public async Task<ServerDate> GetDateAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api/v2/date", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServerDate>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<IpAddressRangeListing> GetIprangesAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api/v2/ipranges", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressRangeListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<TimeZoneEntityListing> GetTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
            var parameters = new NameValueCollection();

            if (pageSize.HasValue)
            {
                parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
            }

            if (pageNumber.HasValue)
            {
                parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
            }

        var uri = UriHelper.GetUri("/api/v2/timezones", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeZoneEntityListing>(_options, cancellationToken);
    }

    /// <inheritdoc />

    public async Task<ParsedCertificate> CreateCertificateDetailsAsync(Certificate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("/api/v2/certificate/details", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ParsedCertificate>(_options, cancellationToken);
    }
}
