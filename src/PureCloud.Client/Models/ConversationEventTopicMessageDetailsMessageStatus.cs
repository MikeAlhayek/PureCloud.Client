using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the delivery status of the message.
/// </summary>
/// <value>Indicates the delivery status of the message.</value>
public enum ConversationEventTopicMessageDetailsMessageStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Queued for "queued"
    /// </summary>
    [EnumMember(Value = "queued")]
    Queued,

    /// <summary>
    /// Enum Sent for "sent"
    /// </summary>
    [EnumMember(Value = "sent")]
    Sent,

    /// <summary>
    /// Enum Failed for "failed"
    /// </summary>
    [EnumMember(Value = "failed")]
    Failed,

    /// <summary>
    /// Enum Received for "received"
    /// </summary>
    [EnumMember(Value = "received")]
    Received,

    /// <summary>
    /// Enum Deliverysuccess for "delivery-success"
    /// </summary>
    [EnumMember(Value = "delivery-success")]
    Deliverysuccess,

    /// <summary>
    /// Enum Deliveryfailed for "delivery-failed"
    /// </summary>
    [EnumMember(Value = "delivery-failed")]
    Deliveryfailed,

    /// <summary>
    /// Enum Read for "read"
    /// </summary>
    [EnumMember(Value = "read")]
    Read,

    /// <summary>
    /// Enum Removed for "removed"
    /// </summary>
    [EnumMember(Value = "removed")]
    Removed,

    /// <summary>
    /// Enum Published for "published"
    /// </summary>
    [EnumMember(Value = "published")]
    Published
}
