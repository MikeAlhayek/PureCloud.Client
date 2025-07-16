using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DataSchema
{
    /// <summary>
    /// The globally unique identifier for the schema.  Only required if a schema is used for custom fields during external entity creation or updates.
    /// </summary>
    /// <value>The globally unique identifier for the schema.  Only required if a schema is used for custom fields during external entity creation or updates.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The schema&#39;s version, a positive integer. Required for updates.
    /// </summary>
    /// <value>The schema&#39;s version, a positive integer. Required for updates.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Indicates the built-in entity type to which this schema applies.
    /// </summary>
    /// <value>Indicates the built-in entity type to which this schema applies.</value>
    public IEnumerable<DataSchemaAppliesToEnum> AppliesTo { get; set; }

    /// <summary>
    /// The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.
    /// </summary>
    /// <value>The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The URI of the user that created this schema.
    /// </summary>
    /// <value>The URI of the user that created this schema.</value>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// A JSON schema defining the extension to the built-in entity type.
    /// </summary>
    /// <value>A JSON schema defining the extension to the built-in entity type.</value>
    public JsonSchemaDocument JsonSchema { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
