using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AgentCopilotAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agentassistantid for "agentAssistantId"
    /// </summary>
    [EnumMember(Value = "agentAssistantId")]
    Agentassistantid,

    /// <summary>
    /// Enum Cannedresponseid for "cannedResponseId"
    /// </summary>
    [EnumMember(Value = "cannedResponseId")]
    Cannedresponseid,

    /// <summary>
    /// Enum Cannedresponselibraryid for "cannedResponseLibraryId"
    /// </summary>
    [EnumMember(Value = "cannedResponseLibraryId")]
    Cannedresponselibraryid,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Engagementtype for "engagementType"
    /// </summary>
    [EnumMember(Value = "engagementType")]
    Engagementtype,

    /// <summary>
    /// Enum Externalcontactid for "externalContactId"
    /// </summary>
    [EnumMember(Value = "externalContactId")]
    Externalcontactid,

    /// <summary>
    /// Enum Feedbackrating for "feedbackRating"
    /// </summary>
    [EnumMember(Value = "feedbackRating")]
    Feedbackrating,

    /// <summary>
    /// Enum Hasanswerhighlight for "hasAnswerHighlight"
    /// </summary>
    [EnumMember(Value = "hasAnswerHighlight")]
    Hasanswerhighlight,

    /// <summary>
    /// Enum Knowledgebasedocumentid for "knowledgeBaseDocumentId"
    /// </summary>
    [EnumMember(Value = "knowledgeBaseDocumentId")]
    Knowledgebasedocumentid,

    /// <summary>
    /// Enum Knowledgebasedocumentversionid for "knowledgeBaseDocumentVersionId"
    /// </summary>
    [EnumMember(Value = "knowledgeBaseDocumentVersionId")]
    Knowledgebasedocumentversionid,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Messageid for "messageId"
    /// </summary>
    [EnumMember(Value = "messageId")]
    Messageid,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Scriptid for "scriptId"
    /// </summary>
    [EnumMember(Value = "scriptId")]
    Scriptid,

    /// <summary>
    /// Enum Scriptpageid for "scriptPageId"
    /// </summary>
    [EnumMember(Value = "scriptPageId")]
    Scriptpageid,

    /// <summary>
    /// Enum Searchid for "searchId"
    /// </summary>
    [EnumMember(Value = "searchId")]
    Searchid,

    /// <summary>
    /// Enum State for "state"
    /// </summary>
    [EnumMember(Value = "state")]
    State,

    /// <summary>
    /// Enum Suggestionid for "suggestionId"
    /// </summary>
    [EnumMember(Value = "suggestionId")]
    Suggestionid,

    /// <summary>
    /// Enum Suggestiontype for "suggestionType"
    /// </summary>
    [EnumMember(Value = "suggestionType")]
    Suggestiontype,

    /// <summary>
    /// Enum Triggertype for "triggerType"
    /// </summary>
    [EnumMember(Value = "triggerType")]
    Triggertype,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Utteranceid for "utteranceId"
    /// </summary>
    [EnumMember(Value = "utteranceId")]
    Utteranceid
}
