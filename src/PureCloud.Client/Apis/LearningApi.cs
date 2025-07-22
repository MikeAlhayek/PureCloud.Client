using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class LearningApi : ILearningApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public LearningApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<LearningAssignment> GetLearningAssignmentAsync(string assignmentId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var parameters = new NameValueCollection();

        if (expand?.Any() == true)
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/assignments/{assignmentId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LearningModule> GetLearningModuleAsync(string moduleId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        var parameters = new NameValueCollection();

        if (expand?.Any() == true)
        {
            parameters.Add("expand", string.Join(",", expand));
        }

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/learning/modules/{moduleId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LearningAssignment> CreateLearningAssignmentAsync(LearningAssignmentCreate body, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync($"api/v2/learning/assignments", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningAssignment>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<LearningModule> UpdateLearningModuleAsync(string moduleId, LearningModuleRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(moduleId);

        ArgumentNullException.ThrowIfNull(body);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/learning/modules/{moduleId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<LearningModule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task DeleteLearningAssignmentAsync(string assignmentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(assignmentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/learning/assignments/{assignmentId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}
