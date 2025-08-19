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

    /// <summary>
    /// Get the current system date/time
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of ServerDate</returns>
    public async Task<ServerDate> GetDateAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api/v2/date", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ServerDate>(_options, cancellationToken);
    }

    /// <summary>
    /// Get public ip address ranges for Genesys Cloud
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of IpAddressRangeListing</returns>
    public async Task<IpAddressRangeListing> GetIprangesAsync(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api/v2/ipranges", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IpAddressRangeListing>(_options, cancellationToken);
    }

    /// <summary>
    /// Get time zones list
    /// </summary>
    /// <param name="pageSize">Page size (optional, default to 25)</param>
    /// <param name="pageNumber">Page number (optional, default to 1)</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of TimeZoneEntityListing</returns>
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

        uri = UriHelper.GetUri("/api/v2/timezones", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TimeZoneEntityListing>(_options, cancellationToken);
    }

    /// <summary>
    /// Returns the information about an X509 PEM encoded certificate or certificate chain.
    /// </summary>
    /// <param name="body">Certificate</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation</param>
    /// <returns>Task of ParsedCertificate</returns>
    public async Task<ParsedCertificate> CreateCertificateDetailsAsync(Certificate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var response = await _httpClient.PostAsJsonAsync("/api/v2/certificate/details", body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ParsedCertificate>(_options, cancellationToken);
    }
}
