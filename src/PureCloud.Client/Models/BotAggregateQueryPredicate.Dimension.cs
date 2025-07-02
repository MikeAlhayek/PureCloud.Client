using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum BotAggregateQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Askactionid for "askActionId"
    /// </summary>
    [EnumMember(Value = "askActionId")]
    Askactionid,

    /// <summary>
    /// Enum Askactionresult for "askActionResult"
    /// </summary>
    [EnumMember(Value = "askActionResult")]
    Askactionresult,

    /// <summary>
    /// Enum Askactiontype for "askActionType"
    /// </summary>
    [EnumMember(Value = "askActionType")]
    Askactiontype,

    /// <summary>
    /// Enum Botfinalintent for "botFinalIntent"
    /// </summary>
    [EnumMember(Value = "botFinalIntent")]
    Botfinalintent,

    /// <summary>
    /// Enum Botflowsubtype for "botFlowSubType"
    /// </summary>
    [EnumMember(Value = "botFlowSubType")]
    Botflowsubtype,

    /// <summary>
    /// Enum Botflowtype for "botFlowType"
    /// </summary>
    [EnumMember(Value = "botFlowType")]
    Botflowtype,

    /// <summary>
    /// Enum Botid for "botId"
    /// </summary>
    [EnumMember(Value = "botId")]
    Botid,

    /// <summary>
    /// Enum Botintent for "botIntent"
    /// </summary>
    [EnumMember(Value = "botIntent")]
    Botintent,

    /// <summary>
    /// Enum Botname for "botName"
    /// </summary>
    [EnumMember(Value = "botName")]
    Botname,

    /// <summary>
    /// Enum Botproduct for "botProduct"
    /// </summary>
    [EnumMember(Value = "botProduct")]
    Botproduct,

    /// <summary>
    /// Enum Botprovider for "botProvider"
    /// </summary>
    [EnumMember(Value = "botProvider")]
    Botprovider,

    /// <summary>
    /// Enum Botrecognitionfailurereason for "botRecognitionFailureReason"
    /// </summary>
    [EnumMember(Value = "botRecognitionFailureReason")]
    Botrecognitionfailurereason,

    /// <summary>
    /// Enum Botresult for "botResult"
    /// </summary>
    [EnumMember(Value = "botResult")]
    Botresult,

    /// <summary>
    /// Enum Botsessionid for "botSessionId"
    /// </summary>
    [EnumMember(Value = "botSessionId")]
    Botsessionid,

    /// <summary>
    /// Enum Botslot for "botSlot"
    /// </summary>
    [EnumMember(Value = "botSlot")]
    Botslot,

    /// <summary>
    /// Enum Botslotmechanism for "botSlotMechanism"
    /// </summary>
    [EnumMember(Value = "botSlotMechanism")]
    Botslotmechanism,

    /// <summary>
    /// Enum Botversion for "botVersion"
    /// </summary>
    [EnumMember(Value = "botVersion")]
    Botversion,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Externalcontactid for "externalContactId"
    /// </summary>
    [EnumMember(Value = "externalContactId")]
    Externalcontactid,

    /// <summary>
    /// Enum Intermediateintentname for "intermediateIntentName"
    /// </summary>
    [EnumMember(Value = "intermediateIntentName")]
    Intermediateintentname,

    /// <summary>
    /// Enum Knowledgebaseid for "knowledgeBaseId"
    /// </summary>
    [EnumMember(Value = "knowledgeBaseId")]
    Knowledgebaseid,

    /// <summary>
    /// Enum Languagecode for "languageCode"
    /// </summary>
    [EnumMember(Value = "languageCode")]
    Languagecode,

    /// <summary>
    /// Enum Lastactionid for "lastActionId"
    /// </summary>
    [EnumMember(Value = "lastActionId")]
    Lastactionid,

    /// <summary>
    /// Enum Lastinputactionid for "lastInputActionId"
    /// </summary>
    [EnumMember(Value = "lastInputActionId")]
    Lastinputactionid,

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
    /// Enum Previewmode for "previewMode"
    /// </summary>
    [EnumMember(Value = "previewMode")]
    Previewmode,

    /// <summary>
    /// Enum Selfserved for "selfServed"
    /// </summary>
    [EnumMember(Value = "selfServed")]
    Selfserved
}
