using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GroupCreateStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "active"
    /// </summary>
    [EnumMember(Value = "active")]
    Active,

    /// <summary>
    /// Enum Inactive for "inactive"
    /// </summary>
    [EnumMember(Value = "inactive")]
    Inactive,

    /// <summary>
    /// Enum Deleted for "deleted"
    /// </summary>
    [EnumMember(Value = "deleted")]
    Deleted
}
