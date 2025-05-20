using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationJobNotificationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Addexplanation for "AddExplanation"
    /// </summary>
    [EnumMember(Value = "AddExplanation")]
    Addexplanation,

    /// <summary>
    /// Enum Updateexplanation for "UpdateExplanation"
    /// </summary>
    [EnumMember(Value = "UpdateExplanation")]
    Updateexplanation,

    /// <summary>
    /// Enum Queryagentexplanations for "QueryAgentExplanations"
    /// </summary>
    [EnumMember(Value = "QueryAgentExplanations")]
    Queryagentexplanations,

    /// <summary>
    /// Enum Querybuexplanations for "QueryBuExplanations"
    /// </summary>
    [EnumMember(Value = "QueryBuExplanations")]
    Querybuexplanations
}
