using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Action
/// </summary>

public enum V2MobiusRulesTopicRuleActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Create for "CREATE"
    /// </summary>
    [EnumMember(Value = "CREATE")]
    Create,

    /// <summary>
    /// Enum Update for "UPDATE"
    /// </summary>
    [EnumMember(Value = "UPDATE")]
    Update,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete
}
