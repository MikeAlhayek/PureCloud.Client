using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Who can view this group
/// </summary>
/// <value>Who can view this group</value>

public enum GroupUpdateVisibilityEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Public for "public"
    /// </summary>
    [EnumMember(Value = "public")]
    Public,

    /// <summary>
    /// Enum Ownerids for "ownerIds"
    /// </summary>
    [EnumMember(Value = "ownerIds")]
    Ownerids,

    /// <summary>
    /// Enum Members for "members"
    /// </summary>
    [EnumMember(Value = "members")]
    Members
}
