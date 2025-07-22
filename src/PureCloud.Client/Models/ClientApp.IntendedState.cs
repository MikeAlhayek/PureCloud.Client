using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ClientAppIntendedStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Enabled for "ENABLED"
    /// </summary>
    [EnumMember(Value = "ENABLED")]
    Enabled,

    /// <summary>
    /// Enum Disabled for "DISABLED"
    /// </summary>
    [EnumMember(Value = "DISABLED")]
    Disabled,

    /// <summary>
    /// Enum Deleted for "DELETED"
    /// </summary>
    [EnumMember(Value = "DELETED")]
    Deleted,

    /// <summary>
    /// Enum Restored for "RESTORED"
    /// </summary>
    [EnumMember(Value = "RESTORED")]
    Restored
}
