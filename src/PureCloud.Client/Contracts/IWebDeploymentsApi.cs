using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebDeploymentsApi
{
    Task DeleteWebdeploymentsConfigurationAsync(string configurationId, CancellationToken cancellationToken = default);

    Task DeleteWebdeploymentsDeploymentAsync(string deploymentId, CancellationToken cancellationToken = default);

    Task<object> DeleteWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    Task DeleteWebdeploymentsTokenRevokeAsync(string xJourneySessionId = null, string xJourneySessionType = null, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsConfigurationVersionAsync(string configurationId, string versionId, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsConfigurationVersionsAsync(string configurationId, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsConfigurationsAsync(bool? showOnlyPublished = null, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsDeploymentAsync(string deploymentId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<CobrowseWebMessagingSession> GetWebdeploymentsDeploymentCobrowseSessionIdAsync(string deploymentId, string sessionId, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsDeploymentConfigurationsAsync(string deploymentId, string type = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<IdentityResolutionConfig> GetWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, CancellationToken cancellationToken = default);

    Task<object> GetWebdeploymentsDeploymentsAsync(IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<object> CreateWebdeploymentsConfigurationVersionsDraftPublishAsync(string configurationId, CancellationToken cancellationToken = default);

    Task<object> CreateWebdeploymentsConfigurationsAsync(object configurationVersion, CancellationToken cancellationToken = default);

    Task<object> CreateWebdeploymentsDeploymentsAsync(object deployment, CancellationToken cancellationToken = default);

    Task<WebDeploymentsAuthorizationResponse> CreateWebdeploymentsTokenOauthcodegrantjwtexchangeAsync(WebDeploymentsOAuthExchangeRequest body, CancellationToken cancellationToken = default);

    Task<SignedData> CreateWebdeploymentsTokenRefreshAsync(WebDeploymentsRefreshJWTRequest body = null, CancellationToken cancellationToken = default);

    Task<object> UpdateWebdeploymentsConfigurationVersionsDraftAsync(string configurationId, object configurationVersion, CancellationToken cancellationToken = default);

    Task<object> UpdateWebdeploymentsDeploymentAsync(string deploymentId, object deployment, CancellationToken cancellationToken = default);

    Task<IdentityResolutionConfig> UpdateWebdeploymentsDeploymentIdentityresolutionAsync(string deploymentId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);
}