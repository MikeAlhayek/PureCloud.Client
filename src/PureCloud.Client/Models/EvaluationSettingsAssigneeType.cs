using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The assignee type. Valid values: Original, Individual, None
/// </summary>
/// <value>The assignee type. Valid values: Original, Individual, None</value>

public enum EvaluationSettingsAssigneeType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Original for "Original"
    /// </summary>
    [EnumMember(Value = "Original")]
    Original,

    /// <summary>
    /// Enum Individual for "Individual"
    /// </summary>
    [EnumMember(Value = "Individual")]
    Individual,

    /// <summary>
    /// Enum None for "None"
    /// </summary>
    [EnumMember(Value = "None")]
    None
}
