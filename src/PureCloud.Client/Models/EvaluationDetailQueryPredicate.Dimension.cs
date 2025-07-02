using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum EvaluationDetailQueryPredicateDimensionEnum
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
    /// Enum Deleted for "deleted"
    /// </summary>
    [EnumMember(Value = "deleted")]
    Deleted,

    /// <summary>
    /// Enum Evaluationid for "evaluationId"
    /// </summary>
    [EnumMember(Value = "evaluationId")]
    Evaluationid,

    /// <summary>
    /// Enum Evaluationstatus for "evaluationStatus"
    /// </summary>
    [EnumMember(Value = "evaluationStatus")]
    Evaluationstatus,

    /// <summary>
    /// Enum Evaluatorid for "evaluatorId"
    /// </summary>
    [EnumMember(Value = "evaluatorId")]
    Evaluatorid,

    /// <summary>
    /// Enum Eventtime for "eventTime"
    /// </summary>
    [EnumMember(Value = "eventTime")]
    Eventtime,

    /// <summary>
    /// Enum Formid for "formId"
    /// </summary>
    [EnumMember(Value = "formId")]
    Formid,

    /// <summary>
    /// Enum Formname for "formName"
    /// </summary>
    [EnumMember(Value = "formName")]
    Formname,

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
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
