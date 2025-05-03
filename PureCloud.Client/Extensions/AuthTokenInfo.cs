using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Extensions;

/// <summary>
/// Contains information about the access token from the authorization code OAuth flow
/// </summary>

public partial class AuthTokenInfo : IEquatable<AuthTokenInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthTokenInfo" /> class.
    /// </summary>
    public AuthTokenInfo()
    {

    }

    ///<Summary>
    /// Access Token
    ///</Summary>
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    ///<Summary>
    /// Refresh Token
    ///</Summary>
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }

    ///<Summary>
    /// Token Type
    ///</Summary>
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    ///<Summary>
    /// Token Expires In
    ///</Summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }

    ///<Summary>
    /// Error
    ///</Summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }



    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuthTokenInfo {\n");
        sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
        sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
        sb.Append("  TokenType: ").Append(TokenType).Append("\n");
        sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");

        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as AuthTokenInfo);
    }

    /// <summary>
    /// Returns true if AuthTokenInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of AuthTokenInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthTokenInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return
            (
                AccessToken == other.AccessToken ||
                AccessToken != null &&
                AccessToken.Equals(other.AccessToken)
            ) &&
            (
                RefreshToken == other.RefreshToken ||
                RefreshToken != null &&
                RefreshToken.Equals(other.RefreshToken)
            ) &&
            (
                TokenType == other.TokenType ||
                TokenType != null &&
                TokenType.Equals(other.TokenType)
            ) &&
            (
                ExpiresIn == other.ExpiresIn ||
                ExpiresIn != null &&
                ExpiresIn.Equals(other.ExpiresIn)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)

            if (AccessToken != null)
            {
                hash = hash * 59 + AccessToken.GetHashCode();
            }

            if (RefreshToken != null)
            {
                hash = hash * 59 + RefreshToken.GetHashCode();
            }

            if (TokenType != null)
            {
                hash = hash * 59 + TokenType.GetHashCode();
            }

            if (ExpiresIn != null)
            {
                hash = hash * 59 + ExpiresIn.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
