using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SharingStatus
/// </summary>

public enum DocumentSharingStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None,

    /// <summary>
    /// Enum Limited for "LIMITED"
    /// </summary>
    [EnumMember(Value = "LIMITED")]
    Limited,

    /// <summary>
    /// Enum Public for "PUBLIC"
    /// </summary>
    [EnumMember(Value = "PUBLIC")]
    Public
}
