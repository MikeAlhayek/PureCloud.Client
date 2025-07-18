using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class InfrastructureAsCodeApi : IInfrastructureAsCodeApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public InfrastructureAsCodeApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<AcceleratorSpecification> GetInfrastructureAsCodeAcceleratorAsync(string acceleratorId, string preferredLanguage = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(acceleratorId);

        var parameters = new NameValueCollection();

        if (!string.IsNullOrEmpty(preferredLanguage))
        {
            parameters.Add("preferredLanguage", UriHelper.ParameterToString(preferredLanguage));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/infrastructureascode/accelerators/{acceleratorId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AcceleratorSpecification>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AcceleratorList> GetInfrastructureAsCodeAcceleratorsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string origin = null, string type = null, string classification = null, string tags = null, CancellationToken cancellationToken = default)
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

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(name))
        {
            parameters.Add("name", UriHelper.ParameterToString(name));
        }

        if (!string.IsNullOrEmpty(description))
        {
            parameters.Add("description", UriHelper.ParameterToString(description));
        }

        if (!string.IsNullOrEmpty(origin))
        {
            parameters.Add("origin", UriHelper.ParameterToString(origin));
        }

        if (!string.IsNullOrEmpty(type))
        {
            parameters.Add("type", UriHelper.ParameterToString(type));
        }

        if (!string.IsNullOrEmpty(classification))
        {
            parameters.Add("classification", UriHelper.ParameterToString(classification));
        }

        if (!string.IsNullOrEmpty(tags))
        {
            parameters.Add("tags", UriHelper.ParameterToString(tags));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var uri = UriHelper.GetUri("api/v2/infrastructureascode/accelerators", parameters);

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AcceleratorList>(
            _options.JsonSerializerOptions,
            cancellationToken);
    }

    public async Task<InfrastructureascodeJob> GetInfrastructureAsCodeJobAsync(
        string jobId,
        bool? details = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(jobId);

        var parameters = new NameValueCollection();

        if (details.HasValue)
        {
            parameters.Add("details", UriHelper.ParameterToString(details.Value));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        var uri = UriHelper.GetUri($"api/v2/infrastructureascode/jobs/{jobId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InfrastructureascodeJob>(
            _options.JsonSerializerOptions,
            cancellationToken);
    }

    public async Task<InfrastructureascodeJob> GetInfrastructureAsCodeJobsAsync(int? maxResults = null, bool? includeErrors = null, string sortBy = null, string sortOrder = null, string acceleratorId = null, string submittedBy = null, string status = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (maxResults.HasValue)
        {
            parameters.Add("maxResults", UriHelper.ParameterToString(maxResults.Value));
        }

        if (includeErrors.HasValue)
        {
            parameters.Add("includeErrors", UriHelper.ParameterToString(includeErrors.Value));
        }

        if (!string.IsNullOrEmpty(sortBy))
        {
            parameters.Add("sortBy", UriHelper.ParameterToString(sortBy));
        }

        if (!string.IsNullOrEmpty(sortOrder))
        {
            parameters.Add("sortOrder", UriHelper.ParameterToString(sortOrder));
        }

        if (!string.IsNullOrEmpty(acceleratorId))
        {
            parameters.Add("acceleratorId", UriHelper.ParameterToString(acceleratorId));
        }

        if (!string.IsNullOrEmpty(submittedBy))
        {
            parameters.Add("submittedBy", UriHelper.ParameterToString(submittedBy));
        }

        if (!string.IsNullOrEmpty(status))
        {
            parameters.Add("status", UriHelper.ParameterToString(status));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/infrastructureascode/jobs", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InfrastructureascodeJob>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<InfrastructureascodeJob> CreateInfrastructureAsCodeJobsAsync(AcceleratorInput body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/infrastructureascode/jobs", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<InfrastructureascodeJob>(_options.JsonSerializerOptions, cancellationToken);
    }
}
