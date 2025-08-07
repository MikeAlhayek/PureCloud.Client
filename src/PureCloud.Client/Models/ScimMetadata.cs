namespace PureCloud.Client.Models;

/// <summary>
/// Defines the SCIM metadata.
/// </summary>
public sealed class ScimMetadata
{
    /// <summary>
    /// The type of SCIM resource.
    /// </summary>
    public ScimMetadataResourceTypeEnum? ResourceType { get; set; }

    /// <summary>
    /// The last time that the resource was modified. Date time is represented as an "ISO-8601 string", for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with "Schema" and "ResourceType" resources.
    /// </summary>
    public DateTime? LastModified { get; set; }

    /// <summary>
    /// The URI of the resource.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// The version of the resource. Matches the ETag HTTP response header. Not included with "Schema" and "ResourceType" resources.
    /// </summary>
    public string Version { get; set; }
}