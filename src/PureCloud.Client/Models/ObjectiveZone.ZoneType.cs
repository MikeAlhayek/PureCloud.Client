using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// zone type
/// </summary>
/// <value>zone type</value>

public enum ObjectiveZoneZoneTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Good for "Good"
    /// </summary>
    [EnumMember(Value = "Good")]
    Good,

    /// <summary>
    /// Enum Target for "Target"
    /// </summary>
    [EnumMember(Value = "Target")]
    Target,

    /// <summary>
    /// Enum Great for "Great"
    /// </summary>
    [EnumMember(Value = "Great")]
    Great,

    /// <summary>
    /// Enum Out for "Out"
    /// </summary>
    [EnumMember(Value = "Out")]
    Out
}
