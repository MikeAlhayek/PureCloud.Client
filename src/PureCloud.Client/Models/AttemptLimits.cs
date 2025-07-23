namespace PureCloud.Client.Models;

/// <summary>
/// AttemptLimits
/// </summary>
public sealed class AttemptLimits
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public int? Version { get; set; }

    /// <summary>
    /// The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.
    /// </summary>
    /// <value>The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.</value>
    public int? MaxAttemptsPerContact { get; set; }

    /// <summary>
    /// The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.
    /// </summary>
    /// <value>The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.</value>
    public int? MaxAttemptsPerNumber { get; set; }

    /// <summary>
    /// If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.
    /// </summary>
    /// <value>If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.</value>
    public string TimeZoneId { get; set; }

    /// <summary>
    /// After how long the number of attempts will be set back to 0. Defaults to NEVER.
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
    public AttemptLimitsResetPeriodEnum? ResetPeriod { get; set; }

    /// <summary>
    /// Configuration for recall attempts.
    /// </summary>
    /// <value>Configuration for recall attempts.</value>
    public IEnumerable<KeyValuePair<string, RecallEntry>> RecallEntries { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}