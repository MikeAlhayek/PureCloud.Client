using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsRefreshJWTRequest
/// </summary>

public partial class WebDeploymentsRefreshJWTRequest : IEquatable<WebDeploymentsRefreshJWTRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsRefreshJWTRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentsRefreshJWTRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsRefreshJWTRequest" /> class.
    /// </summary>
    /// <param name="RefreshToken">Refresh token used to issue a new JWT. (required).</param>
    /// <param name="DeploymentId">The WebDeployment ID (required).</param>
    public WebDeploymentsRefreshJWTRequest(string RefreshToken = null, string DeploymentId = null)
    {
        this.RefreshToken = RefreshToken;
        this.DeploymentId = DeploymentId;

    }



    /// <summary>
    /// Refresh token used to issue a new JWT.
    /// </summary>
    /// <value>Refresh token used to issue a new JWT.</value>
    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; }



    /// <summary>
    /// The WebDeployment ID
    /// </summary>
    /// <value>The WebDeployment ID</value>
    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentsRefreshJWTRequest {\n");

        sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
        sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
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
        return Equals(obj as WebDeploymentsRefreshJWTRequest);
    }

    /// <summary>
    /// Returns true if WebDeploymentsRefreshJWTRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentsRefreshJWTRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentsRefreshJWTRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RefreshToken == other.RefreshToken ||
                RefreshToken != null &&
                RefreshToken.Equals(other.RefreshToken)
            ) &&
            (
                DeploymentId == other.DeploymentId ||
                DeploymentId != null &&
                DeploymentId.Equals(other.DeploymentId)
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
            if (RefreshToken != null)
            {
                hash = hash * 59 + RefreshToken.GetHashCode();
            }

            if (DeploymentId != null)
            {
                hash = hash * 59 + DeploymentId.GetHashCode();
            }

            return hash;
        }
    }
}
