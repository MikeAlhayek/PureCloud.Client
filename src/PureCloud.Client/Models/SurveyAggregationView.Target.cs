using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SurveyAggregationViewTargetEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nsurveyerrors for "nSurveyErrors"
    /// </summary>
    [EnumMember(Value = "nSurveyErrors")]
    Nsurveyerrors,

    /// <summary>
    /// Enum Nsurveyfullresponses for "nSurveyFullResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyFullResponses")]
    Nsurveyfullresponses,

    /// <summary>
    /// Enum Nsurveynpsdetractors for "nSurveyNpsDetractors"
    /// </summary>
    [EnumMember(Value = "nSurveyNpsDetractors")]
    Nsurveynpsdetractors,

    /// <summary>
    /// Enum Nsurveynpspromoters for "nSurveyNpsPromoters"
    /// </summary>
    [EnumMember(Value = "nSurveyNpsPromoters")]
    Nsurveynpspromoters,

    /// <summary>
    /// Enum Nsurveynpsresponses for "nSurveyNpsResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyNpsResponses")]
    Nsurveynpsresponses,

    /// <summary>
    /// Enum Nsurveypartialresponses for "nSurveyPartialResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyPartialResponses")]
    Nsurveypartialresponses,

    /// <summary>
    /// Enum Nsurveyquestiongroupresponses for "nSurveyQuestionGroupResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyQuestionGroupResponses")]
    Nsurveyquestiongroupresponses,

    /// <summary>
    /// Enum Nsurveyquestionresponses for "nSurveyQuestionResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyQuestionResponses")]
    Nsurveyquestionresponses,

    /// <summary>
    /// Enum Nsurveyresponses for "nSurveyResponses"
    /// </summary>
    [EnumMember(Value = "nSurveyResponses")]
    Nsurveyresponses,

    /// <summary>
    /// Enum Nsurveysabandoned for "nSurveysAbandoned"
    /// </summary>
    [EnumMember(Value = "nSurveysAbandoned")]
    Nsurveysabandoned,

    /// <summary>
    /// Enum Nsurveysdeleted for "nSurveysDeleted"
    /// </summary>
    [EnumMember(Value = "nSurveysDeleted")]
    Nsurveysdeleted,

    /// <summary>
    /// Enum Nsurveysexpired for "nSurveysExpired"
    /// </summary>
    [EnumMember(Value = "nSurveysExpired")]
    Nsurveysexpired,

    /// <summary>
    /// Enum Nsurveyssent for "nSurveysSent"
    /// </summary>
    [EnumMember(Value = "nSurveysSent")]
    Nsurveyssent,

    /// <summary>
    /// Enum Nsurveysstarted for "nSurveysStarted"
    /// </summary>
    [EnumMember(Value = "nSurveysStarted")]
    Nsurveysstarted,

    /// <summary>
    /// Enum Nvoicesurveys for "nVoiceSurveys"
    /// </summary>
    [EnumMember(Value = "nVoiceSurveys")]
    Nvoicesurveys,

    /// <summary>
    /// Enum Nwebsurveys for "nWebSurveys"
    /// </summary>
    [EnumMember(Value = "nWebSurveys")]
    Nwebsurveys,

    /// <summary>
    /// Enum Osurveyquestiongroupscore for "oSurveyQuestionGroupScore"
    /// </summary>
    [EnumMember(Value = "oSurveyQuestionGroupScore")]
    Osurveyquestiongroupscore,

    /// <summary>
    /// Enum Osurveyquestionscore for "oSurveyQuestionScore"
    /// </summary>
    [EnumMember(Value = "oSurveyQuestionScore")]
    Osurveyquestionscore,

    /// <summary>
    /// Enum Osurveytotalscore for "oSurveyTotalScore"
    /// </summary>
    [EnumMember(Value = "oSurveyTotalScore")]
    Osurveytotalscore
}
