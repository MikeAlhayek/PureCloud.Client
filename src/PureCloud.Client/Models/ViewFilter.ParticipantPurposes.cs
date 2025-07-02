using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ParticipantPurposes
/// </summary>

public enum ViewFilterParticipantPurposesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Internal for "internal"
    /// </summary>
    [EnumMember(Value = "internal")]
    Internal,

    /// <summary>
    /// Enum External for "external"
    /// </summary>
    [EnumMember(Value = "external")]
    External
}
