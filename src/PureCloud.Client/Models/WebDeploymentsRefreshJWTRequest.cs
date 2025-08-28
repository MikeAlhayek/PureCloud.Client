namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsRefreshJWTRequest
/// </summary>
public sealed class WebDeploymentsRefreshJWTRequest
{
    /// <summary>
    /// Refresh token used to issue a new JWT.
    /// </summary>
    /// <value>Refresh token used to issue a new JWT.</value>
    public string RefreshToken { get; set; }

    /// <summary>
    /// The WebDeployment ID
    /// </summary>
    /// <value>The WebDeployment ID</value>
    public string DeploymentId { get; set; }
}
