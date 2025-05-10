using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Queues;

public enum SkillEvaluationMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None,

    /// <summary>
    /// Enum Best for "BEST"
    /// </summary>
    [EnumMember(Value = "BEST")]
    Best,

    /// <summary>
    /// Enum All for "ALL"
    /// </summary>
    [EnumMember(Value = "ALL")]
    All
}
