namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsOAuthExchangeRequest
/// </summary>
public sealed class WebDeploymentsOAuthExchangeRequest
{
    /// <summary>
    /// The WebDeployment ID
    /// </summary>
    /// <value>The WebDeployment ID</value>
    public string DeploymentId { get; set; }

    /// <summary>
    /// A Customer journey context.
    /// </summary>
    /// <value>A Customer journey context.</value>
    public WebDeploymentsJourneyContext JourneyContext { get; set; }

    /// <summary>
    /// Oauth
    /// </summary>
    /// <value>Oauth</value>
    public WebDeploymentsOAuthRequestParameters Oauth { get; set; }
}
