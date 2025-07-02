using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SummaryAsyncAggregationQueryGroupByEnum
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
    /// Enum Copied for "copied"
    /// </summary>
    [EnumMember(Value = "copied")]
    Copied,

    /// <summary>
    /// Enum Editedfield for "editedField"
    /// </summary>
    [EnumMember(Value = "editedField")]
    Editedfield,

    /// <summary>
    /// Enum Errortype for "errorType"
    /// </summary>
    [EnumMember(Value = "errorType")]
    Errortype,

    /// <summary>
    /// Enum Language for "language"
    /// </summary>
    [EnumMember(Value = "language")]
    Language,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Messagetype for "messageType"
    /// </summary>
    [EnumMember(Value = "messageType")]
    Messagetype,

    /// <summary>
    /// Enum Presented for "presented"
    /// </summary>
    [EnumMember(Value = "presented")]
    Presented,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Summarygenerated for "summaryGenerated"
    /// </summary>
    [EnumMember(Value = "summaryGenerated")]
    Summarygenerated,

    /// <summary>
    /// Enum Summaryid for "summaryId"
    /// </summary>
    [EnumMember(Value = "summaryId")]
    Summaryid,

    /// <summary>
    /// Enum Summaryrating for "summaryRating"
    /// </summary>
    [EnumMember(Value = "summaryRating")]
    Summaryrating,

    /// <summary>
    /// Enum Triggersourceid for "triggerSourceId"
    /// </summary>
    [EnumMember(Value = "triggerSourceId")]
    Triggersourceid,

    /// <summary>
    /// Enum Triggersourceoutcome for "triggerSourceOutcome"
    /// </summary>
    [EnumMember(Value = "triggerSourceOutcome")]
    Triggersourceoutcome,

    /// <summary>
    /// Enum Triggersourcetype for "triggerSourceType"
    /// </summary>
    [EnumMember(Value = "triggerSourceType")]
    Triggersourcetype,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Wrapupcoderating for "wrapUpCodeRating"
    /// </summary>
    [EnumMember(Value = "wrapUpCodeRating")]
    Wrapupcoderating,

    /// <summary>
    /// Enum Wrapupcodesuggestionselected for "wrapUpCodeSuggestionSelected"
    /// </summary>
    [EnumMember(Value = "wrapUpCodeSuggestionSelected")]
    Wrapupcodesuggestionselected,

    /// <summary>
    /// Enum Wrapupcodesgenerated for "wrapupCodesGenerated"
    /// </summary>
    [EnumMember(Value = "wrapupCodesGenerated")]
    Wrapupcodesgenerated
}
