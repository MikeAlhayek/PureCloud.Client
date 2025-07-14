using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SchemaQuantityLimits
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
    /// The minimum number of schema field name characters allowed.
    /// </summary>
    /// <value>The minimum number of schema field name characters allowed.</value>
    public int? MinFieldNameCharacters { get; set; }

    /// <summary>
    /// The maximum number of schema field name characters allowed.
    /// </summary>
    /// <value>The maximum number of schema field name characters allowed.</value>
    public int? MaxFieldNameCharacters { get; set; }

    /// <summary>
    /// The minimum number of schema field description characters allowed.
    /// </summary>
    /// <value>The minimum number of schema field description characters allowed.</value>
    public int? MinFieldDescriptionCharacters { get; set; }

    /// <summary>
    /// The maximum number of schema field description characters allowed.
    /// </summary>
    /// <value>The maximum number of schema field description characters allowed.</value>
    public int? MaxFieldDescriptionCharacters { get; set; }

    /// <summary>
    /// The minimum number of schema name characters allowed.
    /// </summary>
    /// <value>The minimum number of schema name characters allowed.</value>
    public int? MinSchemaNameCharacters { get; set; }

    /// <summary>
    /// The maximum number of schema name characters allowed.
    /// </summary>
    /// <value>The maximum number of schema name characters allowed.</value>
    public int? MaxSchemaNameCharacters { get; set; }

    /// <summary>
    /// The minimum number of schema description characters allowed.
    /// </summary>
    /// <value>The minimum number of schema description characters allowed.</value>
    public int? MinSchemaDescriptionCharacters { get; set; }

    /// <summary>
    /// The maximum number of schema description characters allowed.
    /// </summary>
    /// <value>The maximum number of schema description characters allowed.</value>
    public int? MaxSchemaDescriptionCharacters { get; set; }

    /// <summary>
    /// The maximum number of schema allowed per org.
    /// </summary>
    /// <value>The maximum number of schema allowed per org.</value>
    public int? MaxNumberOfSchemasPerOrg { get; set; }

    /// <summary>
    /// The maximum number of schema fields allowed per schema.
    /// </summary>
    /// <value>The maximum number of schema fields allowed per schema.</value>
    public int? MaxNumberOfFieldsPerSchema { get; set; }

    /// <summary>
    /// The maximum number of schema fields allowed per organization across all of their schemas.
    /// </summary>
    /// <value>The maximum number of schema fields allowed per organization across all of their schemas.</value>
    public int? MaxNumberOfFieldsPerOrg { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
