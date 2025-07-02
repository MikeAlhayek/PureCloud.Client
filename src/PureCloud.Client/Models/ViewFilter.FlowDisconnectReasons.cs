using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets FlowDisconnectReasons
/// </summary>

public enum ViewFilterFlowDisconnectReasonsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum FlowDisconnect for "FLOW_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_DISCONNECT")]
    FlowDisconnect,

    /// <summary>
    /// Enum FlowErrorDisconnect for "FLOW_ERROR_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_ERROR_DISCONNECT")]
    FlowErrorDisconnect,

    /// <summary>
    /// Enum Disconnect for "DISCONNECT"
    /// </summary>
    [EnumMember(Value = "DISCONNECT")]
    Disconnect
}
