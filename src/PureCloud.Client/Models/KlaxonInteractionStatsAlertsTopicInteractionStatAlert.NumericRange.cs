using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets NumericRange
/// </summary>

public enum KlaxonInteractionStatsAlertsTopicInteractionStatAlertNumericRangeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Gt for "gt"
    /// </summary>
    [EnumMember(Value = "gt")]
    Gt,

    /// <summary>
    /// Enum Gte for "gte"
    /// </summary>
    [EnumMember(Value = "gte")]
    Gte,

    /// <summary>
    /// Enum Lt for "lt"
    /// </summary>
    [EnumMember(Value = "lt")]
    Lt,

    /// <summary>
    /// Enum Lte for "lte"
    /// </summary>
    [EnumMember(Value = "lte")]
    Lte,

    /// <summary>
    /// Enum Eq for "eq"
    /// </summary>
    [EnumMember(Value = "eq")]
    Eq,

    /// <summary>
    /// Enum Ne for "ne"
    /// </summary>
    [EnumMember(Value = "ne")]
    Ne
}
