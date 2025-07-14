using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CommandStatusStatusCodeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inprogress for "INPROGRESS"
    /// </summary>
    [EnumMember(Value = "INPROGRESS")]
    Inprogress,

    /// <summary>
    /// Enum Complete for "COMPLETE"
    /// </summary>
    [EnumMember(Value = "COMPLETE")]
    Complete,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error,

    /// <summary>
    /// Enum Canceling for "CANCELING"
    /// </summary>
    [EnumMember(Value = "CANCELING")]
    Canceling,

    /// <summary>
    /// Enum Canceled for "CANCELED"
    /// </summary>
    [EnumMember(Value = "CANCELED")]
    Canceled
}
