using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Channels;

/// <summary>
/// Gets or Sets Transports
/// </summary>

public enum AvailableTopicTransports
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All,

    /// <summary>
    /// Enum Websocket for "Websocket"
    /// </summary>
    [EnumMember(Value = "Websocket")]
    Websocket,

    /// <summary>
    /// Enum Eventbridge for "EventBridge"
    /// </summary>
    [EnumMember(Value = "EventBridge")]
    Eventbridge,

    /// <summary>
    /// Enum Processautomation for "ProcessAutomation"
    /// </summary>
    [EnumMember(Value = "ProcessAutomation")]
    Processautomation,
}
