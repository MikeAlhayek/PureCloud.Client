using System.Runtime.Serialization;

namespace PureCloud.Client.Extensions.Notifications;

///<Summary>
/// ChannelMetadataNotification class
///</Summary>
public class ChannelMetadataNotification
{
    ///<Summary>
    /// Message
    ///</Summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }
}
