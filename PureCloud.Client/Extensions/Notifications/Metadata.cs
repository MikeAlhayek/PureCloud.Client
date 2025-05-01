using System.Runtime.Serialization;

namespace PureCloud.Client.Extensions.Notifications;

///<Summary>
/// Notification (i.e. topic) Metadata
///</Summary>
public class Metadata
{
    ///<Summary>
    /// CorrelationId
    ///</Summary>
    [DataMember(EmitDefaultValue = false, Name = "CorrelationId")]
    public string CorrelationId { get; set; }
}
