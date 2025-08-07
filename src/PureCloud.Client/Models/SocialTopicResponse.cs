namespace PureCloud.Client.Models;

/// <summary>
/// SocialTopicResponse
/// </summary>
public sealed class SocialTopicResponse
{
    /// <summary>
    /// The status of the social topic.
    /// </summary>
    /// <value>The status of the social topic.</value>
    public SocialTopicResponseStatus? Status { get; set; }

    /// <summary>
    /// ID of the social topic.
    /// </summary>
    /// <value>ID of the social topic.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the social topic.
    /// </summary>
    /// <value>The name of the social topic.</value>
    public string Name { get; set; }

    /// <summary>
    /// A description of the social topic.
    /// </summary>
    /// <value>A description of the social topic.</value>
    public string Description { get; set; }

    /// <summary>
    /// Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The ID of the division to which the social topic belongs to.
    /// </summary>
    /// <value>The ID of the division to which the social topic belongs to.</value>
    public string DivisionId { get; set; }

    /// <summary>
    /// The data ingestion rule metadata.
    /// </summary>
    /// <value>The data ingestion rule metadata.</value>
    public IEnumerable<DataIngestionRulesMetadata> DataIngestionRulesMetadata { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}