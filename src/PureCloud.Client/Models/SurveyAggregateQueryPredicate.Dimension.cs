using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum SurveyAggregateQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
    /// Enum Externalcontactid for "externalContactId"
    /// </summary>
    [EnumMember(Value = "externalContactId")]
    Externalcontactid,

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
    /// Enum Requestedlanguageid for "requestedLanguageId"
    /// </summary>
    [EnumMember(Value = "requestedLanguageId")]
    Requestedlanguageid,

    /// <summary>
    /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
    /// </summary>
    [EnumMember(Value = "requestedRoutingSkillId")]
    Requestedroutingskillid,

    /// <summary>
    /// Enum Surveyanswerid for "surveyAnswerId"
    /// </summary>
    [EnumMember(Value = "surveyAnswerId")]
    Surveyanswerid,

    /// <summary>
    /// Enum Surveycreateddate for "surveyCreatedDate"
    /// </summary>
    [EnumMember(Value = "surveyCreatedDate")]
    Surveycreateddate,

    /// <summary>
    /// Enum Surveyerrorreason for "surveyErrorReason"
    /// </summary>
    [EnumMember(Value = "surveyErrorReason")]
    Surveyerrorreason,

    /// <summary>
    /// Enum Surveyformcontextid for "surveyFormContextId"
    /// </summary>
    [EnumMember(Value = "surveyFormContextId")]
    Surveyformcontextid,

    /// <summary>
    /// Enum Surveyformid for "surveyFormId"
    /// </summary>
    [EnumMember(Value = "surveyFormId")]
    Surveyformid,

    /// <summary>
    /// Enum Surveyformname for "surveyFormName"
    /// </summary>
    [EnumMember(Value = "surveyFormName")]
    Surveyformname,

    /// <summary>
    /// Enum Surveyid for "surveyId"
    /// </summary>
    [EnumMember(Value = "surveyId")]
    Surveyid,

    /// <summary>
    /// Enum Surveypartialresponse for "surveyPartialResponse"
    /// </summary>
    [EnumMember(Value = "surveyPartialResponse")]
    Surveypartialresponse,

    /// <summary>
    /// Enum Surveypreviousstatus for "surveyPreviousStatus"
    /// </summary>
    [EnumMember(Value = "surveyPreviousStatus")]
    Surveypreviousstatus,

    /// <summary>
    /// Enum Surveypromoterscore for "surveyPromoterScore"
    /// </summary>
    [EnumMember(Value = "surveyPromoterScore")]
    Surveypromoterscore,

    /// <summary>
    /// Enum Surveyquestiongroupid for "surveyQuestionGroupId"
    /// </summary>
    [EnumMember(Value = "surveyQuestionGroupId")]
    Surveyquestiongroupid,

    /// <summary>
    /// Enum Surveyquestionid for "surveyQuestionId"
    /// </summary>
    [EnumMember(Value = "surveyQuestionId")]
    Surveyquestionid,

    /// <summary>
    /// Enum Surveystatus for "surveyStatus"
    /// </summary>
    [EnumMember(Value = "surveyStatus")]
    Surveystatus,

    /// <summary>
    /// Enum Surveytype for "surveyType"
    /// </summary>
    [EnumMember(Value = "surveyType")]
    Surveytype,

    /// <summary>
    /// Enum Teamid for "teamId"
    /// </summary>
    [EnumMember(Value = "teamId")]
    Teamid,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Wrapupcode for "wrapUpCode"
    /// </summary>
    [EnumMember(Value = "wrapUpCode")]
    Wrapupcode
}
