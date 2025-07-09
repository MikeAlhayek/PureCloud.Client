using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DependencyObject
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public DependencyObjectTypeEnum? Type { get; set; }

    /// <summary>
    /// The dependency identifier
    /// </summary>
    /// <value>The dependency identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Deleted
    /// </summary>
    public bool? Deleted { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary
    public bool? Updated { get; set; }

    /// <summary>
    /// Gets or Sets StateUnknown
    /// </summary
    public bool? StateUnknown { get; set; }

    /// <summary>
    /// Gets or Sets ConsumedResources
    /// </summary>
    public IEnumerable<Dependency> ConsumedResources { get; set; }

    /// <summary>
    /// Gets or Sets ConsumingResources
    /// </summary>
    public IEnumerable<Dependency> ConsumingResources { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
