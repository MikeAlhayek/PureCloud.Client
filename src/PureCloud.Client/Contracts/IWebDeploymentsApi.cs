using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebDeploymentsApi
{
    /// <summary>
    /// Delete all versions of a configuration
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteWebdeploymentsConfigurationAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteWebdeploymentsDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a cobrowse session
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="sessionId">The cobrowse session ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteWebdeploymentsDeploymentCobrowseSessionAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Invalidate JWT
    /// </summary>
    /// <param name="xJourneySessionId">The journey session ID</param>
    /// <param name="xJourneySessionType">The journey session type</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>True if the operation was successful</returns>
    Task<bool> DeleteWebdeploymentsTokenRevokeAsync(string xJourneySessionId = null, string xJourneySessionType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a configuration version
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="versionId">The version ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The configuration version</returns>
    Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionAsync(string configurationId, string versionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the versions for a configuration
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>List of configuration versions</returns>
    Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the configuration draft
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The draft configuration version</returns>
    Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get active configuration for a given deployment
    /// </summary>
    /// <param name="showOnlyPublished">Filter by published configurations</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>List of configuration versions</returns>
    Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync(bool? showOnlyPublished = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="expands">Expand deployment configuration</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The deployment</returns>
    Task<WebDeployment> GetWebdeploymentsDeploymentAsync(string deploymentId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a cobrowse session
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="sessionId">The cobrowse session ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The cobrowse session</returns>
    Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get active configuration for a given deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="type">Get active configuration on a deployment</param>
    /// <param name="expands">Expand deployment configuration</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The active deployment configuration</returns>
    Task<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsAsync(string deploymentId, string type = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an identity resolution config for a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The identity resolution configuration</returns>
    Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get deployments
    /// </summary>
    /// <param name="expands">Expand deployment configuration</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>List of deployments</returns>
    Task<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync(IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish the configuration draft and create a new version
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The published configuration version</returns>
    Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationVersionsDraftPublishAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a configuration version
    /// </summary>
    /// <param name="configurationVersion">The configuration version to create</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The created configuration version</returns>
    Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationsAsync(WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a deployment
    /// </summary>
    /// <param name="deployment">The deployment to create</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The created deployment</returns>
    Task<WebDeployment> CreateWebdeploymentsDeploymentsAsync(WebDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Exchange an oAuth code (obtained via Authorization Code Flow) for a JWT that can be used by webdeployments.
    /// </summary>
    /// <param name="body">The OAuth exchange request</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The authorization response</returns>
    Task<WebDeploymentsAuthorizationResponse> CreateWebdeploymentsTokenOauthcodegrantjwtexchangeAsync(WebDeploymentsOAuthExchangeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Refresh a JWT.
    /// </summary>
    /// <param name="body">The JWT refresh request</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The refreshed signed data</returns>
    Task<SignedData> CreateWebdeploymentsTokenRefreshAsync(WebDeploymentsRefreshJWTRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the configuration draft
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="configurationVersion">The configuration version to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The updated configuration version</returns>
    Task<WebDeploymentConfigurationVersion> UpdateWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="deployment">The deployment to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The updated deployment</returns>
    Task<WebDeployment> UpdateWebdeploymentsDeploymentAsync(string deploymentId, WebDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an identity resolution config for a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="body">The identity resolution configuration to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation</param>
    /// <returns>The updated identity resolution configuration</returns>
    Task<IdentityResolutionConfig> UpdateWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);
}
