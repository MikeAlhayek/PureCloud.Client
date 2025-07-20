using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class WidgetsApi : IWidgetsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public WidgetsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    [Obsolete]
    public async Task<WidgetDeploymentEntityListing> GetWidgetDeploymentsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync("api/v2/widgets/deployments", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeploymentEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete]
    public async Task<WidgetDeployment> GetWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/widgets/deployments/{deploymentId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete]
    public async Task<WidgetDeployment> CreateWidgetDeploymentAsync(WidgetDeployment deployment, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/widgets/deployments", deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete]
    public async Task<WidgetDeployment> UpdateWidgetDeploymentAsync(string deploymentId, WidgetDeployment deployment, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/widgets/deployments/{deploymentId}", deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    [Obsolete]
    public async Task DeleteWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/widgets/deployments/{deploymentId}", cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}