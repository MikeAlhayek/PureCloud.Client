namespace PureCloud.Client.Models;

/// <summary>
/// StaCategory
/// </summary>
public sealed class StaCategory
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
    /// The description of the category
    /// </summary>
    /// <value>The description of the category</value>
    public string Description { get; set; }

    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    public StaCategoryInteractionType? InteractionType { get; set; }

    /// <summary>
    /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
    /// </summary>
    /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
    public Operand Criteria { get; set; }

    /// <summary>
    /// The user who created the record
    /// </summary>
    /// <value>The user who created the record</value>
    public AddressableEntityRef CreatedBy { get; set; }

    /// <summary>
    /// The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The user who last modified the record
    /// </summary>
    /// <value>The user who last modified the record</value>
    public AddressableEntityRef ModifiedBy { get; set; }

    /// <summary>
    /// The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}