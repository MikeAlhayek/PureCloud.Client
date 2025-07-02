using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AgentStateAgentQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Activequeueid for "activeQueueId"
    /// </summary>
    [EnumMember(Value = "activeQueueId")]
    Activequeueid,

    /// <summary>
    /// Enum Assignedskillid for "assignedSkillId"
    /// </summary>
    [EnumMember(Value = "assignedSkillId")]
    Assignedskillid,

    /// <summary>
    /// Enum Assignedlanguageid for "assignedLanguageId"
    /// </summary>
    [EnumMember(Value = "assignedLanguageId")]
    Assignedlanguageid,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Managerid for "managerId"
    /// </summary>
    [EnumMember(Value = "managerId")]
    Managerid
}
