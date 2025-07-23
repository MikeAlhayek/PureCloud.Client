using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Who can view this group
/// </summary>
public enum TrustGroupVisibility
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
    /// Enum Owners for "owners"
    /// </summary>
    [EnumMember(Value = "owners")]
    Owners,

    /// <summary>
    /// Enum Members for "members"
    /// </summary>
    [EnumMember(Value = "members")]
    Members
}