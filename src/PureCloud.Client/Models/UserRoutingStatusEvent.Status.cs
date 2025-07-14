using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UserRoutingStatusEventStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Offqueue for "OffQueue"
    /// </summary>
    [EnumMember(Value = "OffQueue")]
    Offqueue,

    /// <summary>
    /// Enum Idle for "Idle"
    /// </summary>
    [EnumMember(Value = "Idle")]
    Idle,

    /// <summary>
    /// Enum Interacting for "Interacting"
    /// </summary>
    [EnumMember(Value = "Interacting")]
    Interacting,

    /// <summary>
    /// Enum Communicating for "Communicating"
    /// </summary>
    [EnumMember(Value = "Communicating")]
    Communicating,

    /// <summary>
    /// Enum Notresponding for "NotResponding"
    /// </summary>
    [EnumMember(Value = "NotResponding")]
    Notresponding
}
