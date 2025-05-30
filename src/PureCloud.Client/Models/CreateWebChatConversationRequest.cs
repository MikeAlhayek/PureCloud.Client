using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateWebChatConversationRequest
/// </summary>

public partial class CreateWebChatConversationRequest : IEquatable<CreateWebChatConversationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWebChatConversationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateWebChatConversationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWebChatConversationRequest" /> class.
    /// </summary>
    /// <param name="OrganizationId">The organization identifier. (required).</param>
    /// <param name="DeploymentId">The web chat Deployment ID which contains the appropriate settings for this chat conversation. (required).</param>
    /// <param name="RoutingTarget">The routing information to use for the new chat conversation. (required).</param>
    /// <param name="MemberInfo">The guest member info to use for the new chat conversation. (required).</param>
    /// <param name="MemberAuthToken">If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource..</param>
    /// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context)..</param>
    public CreateWebChatConversationRequest(string OrganizationId = null, string DeploymentId = null, WebChatRoutingTarget RoutingTarget = null, GuestMemberInfo MemberInfo = null, string MemberAuthToken = null, JourneyContext JourneyContext = null)
    {
        this.OrganizationId = OrganizationId;
        this.DeploymentId = DeploymentId;
        this.RoutingTarget = RoutingTarget;
        this.MemberInfo = MemberInfo;
        this.MemberAuthToken = MemberAuthToken;
        this.JourneyContext = JourneyContext;

    }



    /// <summary>
    /// The organization identifier.
    /// </summary>
    /// <value>The organization identifier.</value>
    [JsonPropertyName("organizationId")]
    public string OrganizationId { get; set; }



    /// <summary>
    /// The web chat Deployment ID which contains the appropriate settings for this chat conversation.
    /// </summary>
    /// <value>The web chat Deployment ID which contains the appropriate settings for this chat conversation.</value>
    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }



    /// <summary>
    /// The routing information to use for the new chat conversation.
    /// </summary>
    /// <value>The routing information to use for the new chat conversation.</value>
    [JsonPropertyName("routingTarget")]
    public WebChatRoutingTarget RoutingTarget { get; set; }



    /// <summary>
    /// The guest member info to use for the new chat conversation.
    /// </summary>
    /// <value>The guest member info to use for the new chat conversation.</value>
    [JsonPropertyName("memberInfo")]
    public GuestMemberInfo MemberInfo { get; set; }



    /// <summary>
    /// If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.
    /// </summary>
    /// <value>If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.</value>
    [JsonPropertyName("memberAuthToken")]
    public string MemberAuthToken { get; set; }



    /// <summary>
    /// A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).</value>
    [JsonPropertyName("journeyContext")]
    public JourneyContext JourneyContext { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWebChatConversationRequest {\n");

        sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
        sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
        sb.Append("  RoutingTarget: ").Append(RoutingTarget).Append("\n");
        sb.Append("  MemberInfo: ").Append(MemberInfo).Append("\n");
        sb.Append("  MemberAuthToken: ").Append(MemberAuthToken).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
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
        return Equals(obj as CreateWebChatConversationRequest);
    }

    /// <summary>
    /// Returns true if CreateWebChatConversationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateWebChatConversationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateWebChatConversationRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OrganizationId == other.OrganizationId ||
                OrganizationId != null &&
                OrganizationId.Equals(other.OrganizationId)
            ) &&
            (
                DeploymentId == other.DeploymentId ||
                DeploymentId != null &&
                DeploymentId.Equals(other.DeploymentId)
            ) &&
            (
                RoutingTarget == other.RoutingTarget ||
                RoutingTarget != null &&
                RoutingTarget.Equals(other.RoutingTarget)
            ) &&
            (
                MemberInfo == other.MemberInfo ||
                MemberInfo != null &&
                MemberInfo.Equals(other.MemberInfo)
            ) &&
            (
                MemberAuthToken == other.MemberAuthToken ||
                MemberAuthToken != null &&
                MemberAuthToken.Equals(other.MemberAuthToken)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
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
            if (OrganizationId != null)
            {
                hash = hash * 59 + OrganizationId.GetHashCode();
            }

            if (DeploymentId != null)
            {
                hash = hash * 59 + DeploymentId.GetHashCode();
            }

            if (RoutingTarget != null)
            {
                hash = hash * 59 + RoutingTarget.GetHashCode();
            }

            if (MemberInfo != null)
            {
                hash = hash * 59 + MemberInfo.GetHashCode();
            }

            if (MemberAuthToken != null)
            {
                hash = hash * 59 + MemberAuthToken.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
            }

            return hash;
        }
    }
}
