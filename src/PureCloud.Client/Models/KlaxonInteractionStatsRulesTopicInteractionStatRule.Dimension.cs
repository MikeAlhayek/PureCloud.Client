using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum KlaxonInteractionStatsRulesTopicInteractionStatRuleDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
