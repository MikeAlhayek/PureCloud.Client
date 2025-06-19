using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonAllAlertUpdateRequest
{
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    public CommonAllAlertUpdateRequestTypeEnum? Type { get; set; }

    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    public UnreadFields Unread { get; set; }
}
