namespace PureCloud.Client.Models;

public sealed class FieldConfig
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public EntityType? EntityType { get; set; }

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
    /// Gets or Sets State
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Sections
    /// </summary>
    public List<Section> Sections { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets SchemaVersion
    /// </summary>
    public string SchemaVersion { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
