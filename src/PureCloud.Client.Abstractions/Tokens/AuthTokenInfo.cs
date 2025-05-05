namespace PureCloud.Client.Tokens;

/// <summary>
/// Contains information about the access token from the authorization code OAuth flow
/// </summary>

public sealed class AuthTokenInfo
{
    ///<Summary>
    /// Access Token
    ///</Summary>
    public string AccessToken { get; set; }

    ///<Summary>
    /// Refresh Token
    ///</Summary>
    public string RefreshToken { get; set; }

    ///<Summary>
    /// Token Type
    ///</Summary>
    public string TokenType { get; set; }

    ///<Summary>
    /// Token Expires In
    ///</Summary>
    public int? ExpiresIn { get; set; }

    ///<Summary>
    /// Error
    ///</Summary>
    public string Error { get; set; }
}
