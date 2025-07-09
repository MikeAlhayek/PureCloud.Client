using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets CriteriaGroups
/// </summary>

public enum QueryCriteriaCriteriaGroupsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Flow for "flow"
    /// </summary>
    [EnumMember(Value = "flow")]
    Flow,

    /// <summary>
    /// Enum Bot for "bot"
    /// </summary>
    [EnumMember(Value = "bot")]
    Bot
}
