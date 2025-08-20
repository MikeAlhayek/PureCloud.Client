namespace PureCloud.Client.Models;

/// <summary>
/// EscalationRuleResponse
/// </summary>
public sealed class EscalationRuleResponse
{
    /// <summary>
    /// ID of the escalation rule.
    /// </summary>
    /// <value>ID of the escalation rule.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the escalation rule.
    /// </summary>
    /// <value>The name of the escalation rule.</value>
    public string Name { get; set; }

    /// <summary>
    /// The criteria that defines when a social media message should be escalated.
    /// </summary>
    /// <value>The criteria that defines when a social media message should be escalated.</value>
    public string MatchCriteria { get; set; }

    /// <summary>
    /// The priority of the escalation rule.
    /// </summary>
    /// <value>The priority of the escalation rule.</value>
    public int? Priority { get; set; }

    /// <summary>
    /// The ID of the division the social escalation rule belongs to.
    /// </summary>
    /// <value>The ID of the division the social escalation rule belongs to.</value>
    public string DivisionId { get; set; }

    /// <summary>
    /// A description of the social escalation rule.
    /// </summary>
    /// <value>A description of the social escalation rule.</value>
    public string Description { get; set; }

    /// <summary>
    /// Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The status of the escalation rule.
    /// </summary>
    /// <value>The status of the escalation rule.</value>
    public EscalationRuleResponseStatus? Status { get; set; }

    /// <summary>
    /// The target integration configuration used for an open social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an open social media message if the match criteria returns true.</value>
    public EscalationTarget OpenEscalation { get; set; }

    /// <summary>
    /// The target integration configuration used for a Facebook social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a Facebook social media message if the match criteria returns true.</value>
    public EscalationTarget FacebookEscalation { get; set; }

    /// <summary>
    /// The target integration configuration used for an Instagram social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an Instagram social media message if the match criteria returns true.</value>
    public EscalationTarget InstagramEscalation { get; set; }

    /// <summary>
    /// The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.</value>
    public EscalationTarget TwitterEscalation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
