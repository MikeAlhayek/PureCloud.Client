using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class GeneralDataProtectionRegulationApi : IGeneralDataProtectionRegulationApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public GeneralDataProtectionRegulationApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<GDPRRequest> GetGdprRequestAsync(string requestId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(requestId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/gdpr/requests/{UriHelper.ParameterToString(requestId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GDPRRequest>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GDPRRequestEntityListing> GetGdprRequestsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
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

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gdpr/requests", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GDPRRequestEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GDPRSubjectEntityListing> GetGdprSubjectsAsync(string searchType, string searchValue, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(searchType);

        ArgumentException.ThrowIfNullOrEmpty(searchValue);

        var parameters = new NameValueCollection();

        if (searchType != null)
        {
            parameters.Add("searchType", UriHelper.ParameterToString(searchType));
        }

        if (searchValue != null)
        {
            parameters.Add("searchValue", UriHelper.ParameterToString(searchValue));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gdpr/subjects", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GDPRSubjectEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<GDPRRequest> CreateGdprRequestsAsync(GDPRRequest body, bool? deleteConfirmed = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (deleteConfirmed.HasValue)
        {
            parameters.Add("deleteConfirmed", UriHelper.ParameterToString(deleteConfirmed.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/gdpr/requests", parameters);

        var response = await client.PostAsJsonAsync(uri, body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<GDPRRequest>(_options.JsonSerializerOptions, cancellationToken);
    }

}
