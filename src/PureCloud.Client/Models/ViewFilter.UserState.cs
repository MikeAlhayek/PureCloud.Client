using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The user supplied state value in the view
/// </summary>
/// <value>The user supplied state value in the view</value>

public enum ViewFilterUserStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Activeandinactive for "ActiveAndInactive"
    /// </summary>
    [EnumMember(Value = "ActiveAndInactive")]
    Activeandinactive,

    /// <summary>
    /// Enum Active for "Active"
    /// </summary>
    [EnumMember(Value = "Active")]
    Active,

    /// <summary>
    /// Enum Inactive for "Inactive"
    /// </summary>
    [EnumMember(Value = "Inactive")]
    Inactive,

    /// <summary>
    /// Enum Deleted for "Deleted"
    /// </summary>
    [EnumMember(Value = "Deleted")]
    Deleted
}
