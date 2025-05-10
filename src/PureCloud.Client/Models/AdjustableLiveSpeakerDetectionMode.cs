using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Modes to tune between speed to live speaker detection vs accuracy.
/// </summary>
/// <value>Modes to tune between speed to live speaker detection vs accuracy.</value>

public enum AdjustableLiveSpeakerDetectionMode
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Disabled for "disabled"
    /// </summary>
    [EnumMember(Value = "disabled")]
    Disabled,

    /// <summary>
    /// Enum Low for "low"
    /// </summary>
    [EnumMember(Value = "low")]
    Low,

    /// <summary>
    /// Enum Medium for "medium"
    /// </summary>
    [EnumMember(Value = "medium")]
    Medium,

    /// <summary>
    /// Enum High for "high"
    /// </summary>
    [EnumMember(Value = "high")]
    High
}
