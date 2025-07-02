using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum SurveyDetailQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Eventtime for "eventTime"
    /// </summary>
    [EnumMember(Value = "eventTime")]
    Eventtime,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Surveycompleteddate for "surveyCompletedDate"
    /// </summary>
    [EnumMember(Value = "surveyCompletedDate")]
    Surveycompleteddate,

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
    /// Enum Surveypromoterscore for "surveyPromoterScore"
    /// </summary>
    [EnumMember(Value = "surveyPromoterScore")]
    Surveypromoterscore,

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
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid
}
