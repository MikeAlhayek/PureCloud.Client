using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataResultEntity
{
    /// <summary>
    /// whether the modified resource is visible or hidden
    /// </summary>
    /// <value>whether the modified resource is visible or hidden</value>
    public MetadataResultEntityVisibilityEnum? Visibility { get; set; }

    /// <summary>
    /// object type of the modified resource
    /// </summary>
    /// <value>object type of the modified resource</value>
    public string Type { get; set; }

    /// <summary>
    /// description of the modified resource
    /// </summary>
    /// <value>description of the modified resource</value>
    public string Description { get; set; }
}
