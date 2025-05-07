using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets UsedRouting
/// </summary>

public enum AcdEndDetailEventTopicAcdEndEventUsedRoutingEnum
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
    /// Enum Manual for "MANUAL"
    /// </summary>
    [EnumMember(Value = "MANUAL")]
    Manual,

    /// <summary>
    /// Enum Predictive for "PREDICTIVE"
    /// </summary>
    [EnumMember(Value = "PREDICTIVE")]
    Predictive,

    /// <summary>
    /// Enum Preferred for "PREFERRED"
    /// </summary>
    [EnumMember(Value = "PREFERRED")]
    Preferred,

    /// <summary>
    /// Enum Last for "LAST"
    /// </summary>
    [EnumMember(Value = "LAST")]
    Last,

    /// <summary>
    /// Enum Bullseye for "BULLSEYE"
    /// </summary>
    [EnumMember(Value = "BULLSEYE")]
    Bullseye,

    /// <summary>
    /// Enum Standard for "STANDARD"
    /// </summary>
    [EnumMember(Value = "STANDARD")]
    Standard,

    /// <summary>
    /// Enum Other for "OTHER"
    /// </summary>
    [EnumMember(Value = "OTHER")]
    Other,

    /// <summary>
    /// Enum Conditional for "CONDITIONAL"
    /// </summary>
    [EnumMember(Value = "CONDITIONAL")]
    Conditional,

    /// <summary>
    /// Enum Vip for "VIP"
    /// </summary>
    [EnumMember(Value = "VIP")]
    Vip
}
