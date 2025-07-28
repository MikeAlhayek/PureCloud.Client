using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsOAuthExchangeRequest
/// </summary>

public sealed class WebDeploymentsOAuthExchangeRequest : IEquatable<WebDeploymentsOAuthExchangeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsOAuthExchangeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentsOAuthExchangeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsOAuthExchangeRequest" /> class.
    /// </summary>
    /// <param name="DeploymentId">The WebDeployment ID (required).</param>
    /// <param name="JourneyContext">A Customer journey context..</param>
    /// <param name="Oauth">Oauth.</param>
    public WebDeploymentsOAuthExchangeRequest(string DeploymentId = null, WebDeploymentsJourneyContext JourneyContext = null, WebDeploymentsOAuthRequestParameters Oauth = null)
    {
        this.DeploymentId = DeploymentId;
        this.JourneyContext = JourneyContext;
        this.Oauth = Oauth;

    }



    /// <summary>
    /// The WebDeployment ID
    /// </summary>
    /// <value>The WebDeployment ID</value>
    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }



    /// <summary>
    /// A Customer journey context.
    /// </summary>
    /// <value>A Customer journey context.</value>
    [JsonPropertyName("journeyContext")]
    public WebDeploymentsJourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Gets or Sets Oauth
    /// </summary>
    [JsonPropertyName("oauth")]
    public WebDeploymentsOAuthRequestParameters Oauth { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentsOAuthExchangeRequest {\n");

        sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
        sb.Append("  Oauth: ").Append(Oauth).Append("\n");
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
        return Equals(obj as WebDeploymentsOAuthExchangeRequest);
    }

    /// <summary>
    /// Returns true if WebDeploymentsOAuthExchangeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentsOAuthExchangeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentsOAuthExchangeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DeploymentId == other.DeploymentId ||
                DeploymentId != null &&
                DeploymentId.Equals(other.DeploymentId)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
            ) &&
            (
                Oauth == other.Oauth ||
                Oauth != null &&
                Oauth.Equals(other.Oauth)
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
            if (DeploymentId != null)
            {
                hash = hash * 59 + DeploymentId.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
            }

            if (Oauth != null)
            {
                hash = hash * 59 + Oauth.GetHashCode();
            }

            return hash;
        }
    }
}
