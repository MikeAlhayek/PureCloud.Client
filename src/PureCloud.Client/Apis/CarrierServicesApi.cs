using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class CarrierServicesApi : ICarrierServicesApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public CarrierServicesApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<EmergencyLocation> GetCarrierservicesIntegrationsEmergencylocationsMeAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(phoneNumber, nameof(phoneNumber));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection
        {
            { "phoneNumber", phoneNumber }
        };

        var url = UriHelper.GetUri("/api/v2/carrierservices/integrations/emergencylocations/me", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyLocation>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<EmergencyLocation> CreateCarrierservicesIntegrationsEmergencylocationsMeAsync(EmergencyLocation body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        var url = UriHelper.GetUri("/api/v2/carrierservices/integrations/emergencylocations/me", parameters);

        var response = await client.PostAsJsonAsync(url, body, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<EmergencyLocation>(_options.JsonSerializerOptions, cancellationToken);
    }

}
