using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EvaluationAsyncAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Assigneeapplicable for "assigneeApplicable"
    /// </summary>
    [EnumMember(Value = "assigneeApplicable")]
    Assigneeapplicable,

    /// <summary>
    /// Enum Assigneeid for "assigneeId"
    /// </summary>
    [EnumMember(Value = "assigneeId")]
    Assigneeid,

    /// <summary>
    /// Enum Calibrationid for "calibrationId"
    /// </summary>
    [EnumMember(Value = "calibrationId")]
    Calibrationid,

    /// <summary>
    /// Enum Contextid for "contextId"
    /// </summary>
    [EnumMember(Value = "contextId")]
    Contextid,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Evaluationcontextid for "evaluationContextId"
    /// </summary>
    [EnumMember(Value = "evaluationContextId")]
    Evaluationcontextid,

    /// <summary>
    /// Enum Evaluationid for "evaluationId"
    /// </summary>
    [EnumMember(Value = "evaluationId")]
    Evaluationid,

    /// <summary>
    /// Enum Evaluatorid for "evaluatorId"
    /// </summary>
    [EnumMember(Value = "evaluatorId")]
    Evaluatorid,

    /// <summary>
    /// Enum Formid for "formId"
    /// </summary>
    [EnumMember(Value = "formId")]
    Formid,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Released for "released"
    /// </summary>
    [EnumMember(Value = "released")]
    Released,

    /// <summary>
    /// Enum Rescored for "rescored"
    /// </summary>
    [EnumMember(Value = "rescored")]
    Rescored,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
