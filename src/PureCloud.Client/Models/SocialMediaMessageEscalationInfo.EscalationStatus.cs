using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets EscalationStatus
/// </summary>
public enum SocialMediaMessageEscalationInfoEscalationStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Manual for "Manual"
    /// </summary>
    [EnumMember(Value = "Manual")]
    Manual,

    /// <summary>
    /// Enum Throttled for "Throttled"
    /// </summary>
    [EnumMember(Value = "Throttled")]
    Throttled,

    /// <summary>
    /// Enum Previouslyescalated for "PreviouslyEscalated"
    /// </summary>
    [EnumMember(Value = "PreviouslyEscalated")]
    Previouslyescalated,

    /// <summary>
    /// Enum Notescalated for "NotEscalated"
    /// </summary>
    [EnumMember(Value = "NotEscalated")]
    Notescalated,

    /// <summary>
    /// Enum Automatic for "Automatic"
    /// </summary>
    [EnumMember(Value = "Automatic")]
    Automatic
}