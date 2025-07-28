using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Represents a collection of functions to interact with the WebDeployments API endpoints
/// </summary>
public interface IWebDeploymentsApi
{
    /// <summary>
    /// Delete all versions of a configuration
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful, false otherwise</returns>
    Task<bool> DeleteWebdeploymentsConfigurationAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful, false otherwise</returns>
    Task<bool> DeleteWebdeploymentsDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a cobrowse session
    /// </summary>
    /// <param name="deploymentId">WebMessaging deployment ID</param>
    /// <param name="sessionId">Cobrowse session id or join code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful, false otherwise</returns>
    Task<bool> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Invalidate JWT
    /// </summary>
    /// <param name="xJourneySessionId">The Customer's journey sessionId. (optional)</param>
    /// <param name="xJourneySessionType">The Customer's journey session type. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful, false otherwise</returns>
    Task<bool> DeleteWebdeploymentsTokenRevokeAsync(string xJourneySessionId = null, string xJourneySessionType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a configuration version
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="versionId">The version of the configuration to get</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersion</returns>
    Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionAsync(string configurationId, string versionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the versions of a configuration
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
    Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationVersionsAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the configuration draft
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersion</returns>
    Task<WebDeploymentConfigurationVersion> GetWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// View configuration drafts
    /// </summary>
    /// <param name="showOnlyPublished">Filter by published status. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersionEntityListing</returns>
    Task<WebDeploymentConfigurationVersionEntityListing> GetWebdeploymentsConfigurationsAsync(bool? showOnlyPublished = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeployment</returns>
    Task<WebDeployment> GetWebdeploymentsDeploymentAsync(string deploymentId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a cobrowse session
    /// </summary>
    /// <param name="deploymentId">WebMessaging deployment ID</param>
    /// <param name="sessionId">Cobrowse session id or join code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>CobrowseWebMessagingSession</returns>
    Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get active configuration for a given deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="type">Get active configuration on a deployment (optional)</param>
    /// <param name="expand">Expand instructions for the return value (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentActiveConfigurationOnDeployment</returns>
    Task<WebDeploymentActiveConfigurationOnDeployment> GetWebdeploymentsDeploymentConfigurationsAsync(string deploymentId, string type = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a deployment identity resolution setting.
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionConfig</returns>
    Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get deployments
    /// </summary>
    /// <param name="expand">The specified entity attributes will be filled. Comma separated values expected. (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>ExpandableWebDeploymentEntityListing</returns>
    Task<ExpandableWebDeploymentEntityListing> GetWebdeploymentsDeploymentsAsync(IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish the configuration draft and create a new version
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersion</returns>
    Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationVersionsDraftPublishAsync(string configurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a configuration draft
    /// </summary>
    /// <param name="configurationVersion">Configuration version to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersion</returns>
    Task<WebDeploymentConfigurationVersion> CreateWebdeploymentsConfigurationsAsync(WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a deployment
    /// </summary>
    /// <param name="deployment">Deployment to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeployment</returns>
    Task<WebDeployment> CreateWebdeploymentsDeploymentsAsync(WebDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Exchange an oAuth code for a JWT signed with the WebDeployment's key
    /// </summary>
    /// <param name="body">OAuth exchange request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentsAuthorizationResponse</returns>
    Task<WebDeploymentsAuthorizationResponse> CreateWebdeploymentsTokenOauthcodegrantjwtexchangeAsync(WebDeploymentsOAuthExchangeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Refresh a JWT
    /// </summary>
    /// <param name="body">Refresh request (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SignedData</returns>
    Task<SignedData> CreateWebdeploymentsTokenRefreshAsync(WebDeploymentsRefreshJWTRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the configuration draft
    /// </summary>
    /// <param name="configurationId">The configuration version ID</param>
    /// <param name="configurationVersion">Configuration version to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeploymentConfigurationVersion</returns>
    Task<WebDeploymentConfigurationVersion> UpdateWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, WebDeploymentConfigurationVersion configurationVersion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a deployment
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="deployment">Deployment to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>WebDeployment</returns>
    Task<WebDeployment> UpdateWebdeploymentsDeploymentAsync(string deploymentId, WebDeployment deployment, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a deployment identity resolution setting.
    /// </summary>
    /// <param name="deploymentId">The deployment ID</param>
    /// <param name="body">Identity resolution configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IdentityResolutionConfig</returns>
    Task<IdentityResolutionConfig> UpdateWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);
}
