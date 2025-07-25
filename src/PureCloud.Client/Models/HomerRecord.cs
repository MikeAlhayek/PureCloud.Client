namespace PureCloud.Client.Models;

/// <summary>
/// HomerRecord
/// </summary>
public sealed class HomerRecord
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string MilliTs { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string MicroTs { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ReplyReason { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Ruri { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string RuriUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string RuriDomain { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string FromUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string FromDomain { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string FromTag { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ToUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ToDomain { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ToTag { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string PidUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ContactUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string AuthUser { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Callid { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string CallidAleg { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Via1 { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Via1Branch { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Cseq { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Diversion { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Reason { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Auth { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string UserAgent { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string SourceIp { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string SourcePort { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string DestinationIp { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string DestinationPort { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ContactIp { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ContactPort { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string OriginatorIp { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string OriginatorPort { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Proto { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Family { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string RtpStat { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Node { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Trans { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Dbnode { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string Msg { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string SourceAlias { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string DestinationAlias { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Metadata associated to the SIP calls.
    /// </summary>
    public string ParticipantId { get; set; }

    /// <summary>
    /// The URI for this object.
    /// </summary>
    public string SelfUri { get; set; }
}
