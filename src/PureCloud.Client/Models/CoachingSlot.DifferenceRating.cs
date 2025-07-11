using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CoachingSlotDifferenceRatingEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Poor for "Poor"
    /// </summary>
    [EnumMember(Value = "Poor")]
    Poor,

    /// <summary>
    /// Enum Neutral for "Neutral"
    /// </summary>
    [EnumMember(Value = "Neutral")]
    Neutral,

    /// <summary>
    /// Enum Good for "Good"
    /// </summary>
    [EnumMember(Value = "Good")]
    Good
}
