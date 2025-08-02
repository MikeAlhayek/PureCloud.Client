namespace PureCloud.Client.Models;

/// <summary>
/// OpenDataIngestionRuleResponse
/// </summary>
public sealed class OpenDataIngestionRuleResponse
{
    /// <summary>
    /// ID of the open data ingestion rule.
    /// </summary>
    /// <value>ID of the open data ingestion rule.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the data ingestion rule.
    /// </summary>
    /// <value>The name of the data ingestion rule.</value>
    public string Name { get; set; }

    /// <summary>
    /// A description of the data ingestion rule.
    /// </summary>
    /// <value>A description of the data ingestion rule.</value>
    public string Description { get; set; }

    /// <summary>
    /// The version number of the data ingestion rule.
    /// </summary>
    /// <value>The version number of the data ingestion rule.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The status of the data ingestion rule.
    /// </summary>
    /// <value>The status of the data ingestion rule.</value>
    public OpenDataIngestionRuleResponseStatus? Status { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
