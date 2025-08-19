using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
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

    /// <summary>
    /// List Widget deployments
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeploymentEntityListing</returns>
    [Obsolete]
    public async Task<WidgetDeploymentEntityListing> GetWidgetDeploymentsAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/widgets/deployments", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeploymentEntityListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Get a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    public async Task<WidgetDeployment> GetWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/widgets/deployments/{Uri.EscapeDataString(deploymentId)}", null);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Create Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deployment">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    public async Task<WidgetDeployment> CreateWidgetDeploymentAsync(WidgetDeployment deployment, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(deployment);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri("api/v2/widgets/deployments", null);

        var response = await client.PostAsJsonAsync(uri, deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Update a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="deployment">Deployment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WidgetDeployment</returns>
    [Obsolete]
    public async Task<WidgetDeployment> UpdateWidgetDeploymentAsync(string deploymentId, WidgetDeployment deployment, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);
        ArgumentNullException.ThrowIfNull(deployment);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/widgets/deployments/{Uri.EscapeDataString(deploymentId)}", null);

        var response = await client.PutAsJsonAsync(uri, deployment, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<WidgetDeployment>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <summary>
    /// Delete a Widget deployment
    /// </summary>
    /// <remarks>
    /// This endpoint is deprecated. Please see the article https://help.mypurecloud.com/articles/deprecation-removal-of-acd-web-chat-version-2/. 
    /// </remarks>
    /// <param name="deploymentId">Widget Config Id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task&lt;bool&gt;</returns>
    [Obsolete]
    public async Task<bool> DeleteWidgetDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(deploymentId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var uri = UriHelper.GetUri($"api/v2/widgets/deployments/{Uri.EscapeDataString(deploymentId)}", null);

        var response = await client.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }
}
