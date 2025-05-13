using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets WrapupCode
/// </summary>

public enum OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEventWrapupCodeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum OutboundMessageSent for "OUTBOUND_MESSAGE_SENT"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MESSAGE_SENT")]
    OutboundMessageSent,

    /// <summary>
    /// Enum OutboundMessageFailed for "OUTBOUND_MESSAGE_FAILED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MESSAGE_FAILED")]
    OutboundMessageFailed,

    /// <summary>
    /// Enum OutboundMessageThrottled for "OUTBOUND_MESSAGE_THROTTLED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MESSAGE_THROTTLED")]
    OutboundMessageThrottled
}
