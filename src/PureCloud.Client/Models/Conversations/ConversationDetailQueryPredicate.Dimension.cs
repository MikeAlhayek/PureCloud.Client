using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum ConversationDetailQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Conversationend for "conversationEnd"
    /// </summary>
    [EnumMember(Value = "conversationEnd")]
    Conversationend,

    /// <summary>
    /// Enum Conversationid for "conversationId"
    /// </summary>
    [EnumMember(Value = "conversationId")]
    Conversationid,

    /// <summary>
    /// Enum Conversationinitiator for "conversationInitiator"
    /// </summary>
    [EnumMember(Value = "conversationInitiator")]
    Conversationinitiator,

    /// <summary>
    /// Enum Conversationstart for "conversationStart"
    /// </summary>
    [EnumMember(Value = "conversationStart")]
    Conversationstart,

    /// <summary>
    /// Enum Customerparticipation for "customerParticipation"
    /// </summary>
    [EnumMember(Value = "customerParticipation")]
    Customerparticipation,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Externaltag for "externalTag"
    /// </summary>
    [EnumMember(Value = "externalTag")]
    Externaltag,

    /// <summary>
    /// Enum Mediastatsminconversationmos for "mediaStatsMinConversationMos"
    /// </summary>
    [EnumMember(Value = "mediaStatsMinConversationMos")]
    Mediastatsminconversationmos,

    /// <summary>
    /// Enum Originatingdirection for "originatingDirection"
    /// </summary>
    [EnumMember(Value = "originatingDirection")]
    Originatingdirection,

    /// <summary>
    /// Enum Originatingsocialmediapublic for "originatingSocialMediaPublic"
    /// </summary>
    [EnumMember(Value = "originatingSocialMediaPublic")]
    Originatingsocialmediapublic
}
