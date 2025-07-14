using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets MemberType
/// </summary>

public enum CreateShareRequestMemberTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum Group for "GROUP"
    /// </summary>
    [EnumMember(Value = "GROUP")]
    Group,

    /// <summary>
    /// Enum Public for "PUBLIC"
    /// </summary>
    [EnumMember(Value = "PUBLIC")]
    Public
}
