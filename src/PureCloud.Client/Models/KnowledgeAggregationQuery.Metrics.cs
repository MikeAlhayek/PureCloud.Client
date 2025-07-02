using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum KnowledgeAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ndistinctknowledgesessions for "nDistinctKnowledgeSessions"
    /// </summary>
    [EnumMember(Value = "nDistinctKnowledgeSessions")]
    Ndistinctknowledgesessions,

    /// <summary>
    /// Enum Nknowledgedocumentcopied for "nKnowledgeDocumentCopied"
    /// </summary>
    [EnumMember(Value = "nKnowledgeDocumentCopied")]
    Nknowledgedocumentcopied,

    /// <summary>
    /// Enum Nknowledgedocumentfeedback for "nKnowledgeDocumentFeedback"
    /// </summary>
    [EnumMember(Value = "nKnowledgeDocumentFeedback")]
    Nknowledgedocumentfeedback,

    /// <summary>
    /// Enum Nknowledgedocumentpresented for "nKnowledgeDocumentPresented"
    /// </summary>
    [EnumMember(Value = "nKnowledgeDocumentPresented")]
    Nknowledgedocumentpresented,

    /// <summary>
    /// Enum Nknowledgedocumentsurfaced for "nKnowledgeDocumentSurfaced"
    /// </summary>
    [EnumMember(Value = "nKnowledgeDocumentSurfaced")]
    Nknowledgedocumentsurfaced,

    /// <summary>
    /// Enum Nknowledgedocumentviewed for "nKnowledgeDocumentViewed"
    /// </summary>
    [EnumMember(Value = "nKnowledgeDocumentViewed")]
    Nknowledgedocumentviewed,

    /// <summary>
    /// Enum Nknowledgesearch for "nKnowledgeSearch"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSearch")]
    Nknowledgesearch,

    /// <summary>
    /// Enum Nknowledgesearchanswered for "nKnowledgeSearchAnswered"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSearchAnswered")]
    Nknowledgesearchanswered,

    /// <summary>
    /// Enum Nknowledgesearchfeedback for "nKnowledgeSearchFeedback"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSearchFeedback")]
    Nknowledgesearchfeedback,

    /// <summary>
    /// Enum Nknowledgesearchunanswered for "nKnowledgeSearchUnanswered"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSearchUnanswered")]
    Nknowledgesearchunanswered,

    /// <summary>
    /// Enum Nknowledgesessions for "nKnowledgeSessions"
    /// </summary>
    [EnumMember(Value = "nKnowledgeSessions")]
    Nknowledgesessions,

    /// <summary>
    /// Enum Oknowledgedocumentquery for "oKnowledgeDocumentQuery"
    /// </summary>
    [EnumMember(Value = "oKnowledgeDocumentQuery")]
    Oknowledgedocumentquery,

    /// <summary>
    /// Enum Oknowledgedocumentqueryselfserved for "oKnowledgeDocumentQuerySelfServed"
    /// </summary>
    [EnumMember(Value = "oKnowledgeDocumentQuerySelfServed")]
    Oknowledgedocumentqueryselfserved,

    /// <summary>
    /// Enum Oknowledgesearch for "oKnowledgeSearch"
    /// </summary>
    [EnumMember(Value = "oKnowledgeSearch")]
    Oknowledgesearch
}
