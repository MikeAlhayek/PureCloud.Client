using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectFlowReference
{
    /// <summary>
    /// The flow type.
    /// </summary>
    /// <value>The flow type.</value>
    public ArchitectFlowReferenceTypeEnum? Type { get; set; }

    /// <summary>
    /// The flow identifier.
    /// </summary>
    /// <value>The flow identifier.</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow name.
    /// </summary>
    /// <value>The flow name.</value>
    public string Name { get; set; }

    /// <summary>
    /// The flow version.
    /// </summary>
    /// <value>The flow version.</value>
    public string Version { get; set; }
}
