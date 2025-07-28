namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsAuthorizationResponse
/// </summary>
public sealed class WebDeploymentsAuthorizationResponse
{
    /// <summary>
    /// Refresh token used to issue a new JWT.
    /// </summary>
    /// <value>Refresh token used to issue a new JWT.</value>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Gets or Sets Jwt
    /// </summary>
    /// <value>Gets or Sets Jwt</value>
    public string Jwt { get; set; }
}
