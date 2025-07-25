using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationNormalizedMessageTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Text for "Text"
    /// </summary>
    [EnumMember(Value = "Text")]
    Text,

    /// <summary>
    /// Enum Structured for "Structured"
    /// </summary>
    [EnumMember(Value = "Structured")]
    Structured,

    /// <summary>
    /// Enum Receipt for "Receipt"
    /// </summary>
    [EnumMember(Value = "Receipt")]
    Receipt,

    /// <summary>
    /// Enum Event for "Event"
    /// </summary>
    [EnumMember(Value = "Event")]
    Event,

    /// <summary>
    /// Enum Message for "Message"
    /// </summary>
    [EnumMember(Value = "Message")]
    Message,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
