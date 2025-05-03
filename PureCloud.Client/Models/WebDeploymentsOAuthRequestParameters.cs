using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsOAuthRequestParameters
/// </summary>

public partial class WebDeploymentsOAuthRequestParameters : IEquatable<WebDeploymentsOAuthRequestParameters>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsOAuthRequestParameters" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentsOAuthRequestParameters() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsOAuthRequestParameters" /> class.
    /// </summary>
    /// <param name="Code">The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest (required).</param>
    /// <param name="RedirectUri">Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest (required).</param>
    /// <param name="Nonce">Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
    /// <param name="MaxAge">Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest.</param>
    /// <param name="CodeVerifier">Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636.</param>
    /// <param name="Iss">Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207.</param>
    public WebDeploymentsOAuthRequestParameters(string Code = null, string RedirectUri = null, string Nonce = null, int? MaxAge = null, string CodeVerifier = null, string Iss = null)
    {
        this.Code = Code;
        this.RedirectUri = RedirectUri;
        this.Nonce = Nonce;
        this.MaxAge = MaxAge;
        this.CodeVerifier = CodeVerifier;
        this.Iss = Iss;

    }



    /// <summary>
    /// The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
    /// </summary>
    /// <value>The authorization code to be sent to the authentication server during the token request.  Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
    /// </summary>
    /// <value>Redirect URI sent in the \&quot;Authentication Request\&quot;Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
    [JsonPropertyName("redirectUri")]
    public string RedirectUri { get; set; }



    /// <summary>
    /// Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
    /// </summary>
    /// <value>Required if provided in the \&quot;Authentication Request\&quot;. Otherwise should be empty.String value used to associate a Client session with an ID Token, and to mitigate replay attacks. The value is passed through unmodified from the Authentication Request to the ID Token. Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
    [JsonPropertyName("nonce")]
    public string Nonce { get; set; }



    /// <summary>
    /// Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest
    /// </summary>
    /// <value>Required if provided in the  \&quot;Authentication Request\&quot;. Otherwise should be empty.Specifies the allowable elapsed time in seconds since the last time the End-User was actively authenticated.Refer to https://openid.net/specs/openid-connect-core-1_0.html#AuthRequest</value>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }



    /// <summary>
    /// Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636
    /// </summary>
    /// <value>Required if authorizing using Proof Key for Code Exchange (PKCE). Otherwise should be empty.Random URL-safe string with a minimum length of 43 characters generated at start of authorization flow to mitigate the threat of having the authorization code intercepted. Refer to https://datatracker.ietf.org/doc/html/rfc7636</value>
    [JsonPropertyName("codeVerifier")]
    public string CodeVerifier { get; set; }



    /// <summary>
    /// Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207
    /// </summary>
    /// <value>Optional parameter. Set it if authorization server discovery metadata authorization_response_iss_parameter_supported is enabled. Refer to https://datatracker.ietf.org/doc/html/rfc9207</value>
    [JsonPropertyName("iss")]
    public string Iss { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentsOAuthRequestParameters {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
        sb.Append("  Nonce: ").Append(Nonce).Append("\n");
        sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
        sb.Append("  CodeVerifier: ").Append(CodeVerifier).Append("\n");
        sb.Append("  Iss: ").Append(Iss).Append("\n");
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
        return Equals(obj as WebDeploymentsOAuthRequestParameters);
    }

    /// <summary>
    /// Returns true if WebDeploymentsOAuthRequestParameters instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentsOAuthRequestParameters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentsOAuthRequestParameters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                RedirectUri == other.RedirectUri ||
                RedirectUri != null &&
                RedirectUri.Equals(other.RedirectUri)
            ) &&
            (
                Nonce == other.Nonce ||
                Nonce != null &&
                Nonce.Equals(other.Nonce)
            ) &&
            (
                MaxAge == other.MaxAge ||
                MaxAge != null &&
                MaxAge.Equals(other.MaxAge)
            ) &&
            (
                CodeVerifier == other.CodeVerifier ||
                CodeVerifier != null &&
                CodeVerifier.Equals(other.CodeVerifier)
            ) &&
            (
                Iss == other.Iss ||
                Iss != null &&
                Iss.Equals(other.Iss)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (RedirectUri != null)
            {
                hash = hash * 59 + RedirectUri.GetHashCode();
            }

            if (Nonce != null)
            {
                hash = hash * 59 + Nonce.GetHashCode();
            }

            if (MaxAge != null)
            {
                hash = hash * 59 + MaxAge.GetHashCode();
            }

            if (CodeVerifier != null)
            {
                hash = hash * 59 + CodeVerifier.GetHashCode();
            }

            if (Iss != null)
            {
                hash = hash * 59 + Iss.GetHashCode();
            }

            return hash;
        }
    }
}
