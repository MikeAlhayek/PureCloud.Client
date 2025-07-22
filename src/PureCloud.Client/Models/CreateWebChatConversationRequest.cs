using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateWebChatConversationRequest
{
    /// <summary>
    /// The organization identifier.
    /// </summary>
    /// <value>The organization identifier.</value>
    public string OrganizationId { get; set; }

    /// <summary>
    /// The web chat Deployment ID which contains the appropriate settings for this chat conversation.
    /// </summary>
    /// <value>The web chat Deployment ID which contains the appropriate settings for this chat conversation.</value>
    public string DeploymentId { get; set; }

    /// <summary>
    /// The routing information to use for the new chat conversation.
    /// </summary>
    /// <value>The routing information to use for the new chat conversation.</value>
    public WebChatRoutingTarget RoutingTarget { get; set; }

    /// <summary>
    /// The guest member info to use for the new chat conversation.
    /// </summary>
    /// <value>The guest member info to use for the new chat conversation.</value>
    public GuestMemberInfo MemberInfo { get; set; }

    /// <summary>
    /// If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.
    /// </summary>
    /// <value>If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.</value>
    public string MemberAuthToken { get; set; }

    /// <summary>
    /// A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).</value>
    public JourneyContext JourneyContext { get; set; }
}
