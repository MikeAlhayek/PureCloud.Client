using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityTypeDefinition
{
    /// <summary>
    /// The name of the entity type.
    /// </summary>
    /// <value>The name of the entity type.</value>
    public string Name { get; set; }

    /// <summary>
    /// Description of the of the named entity type.
    /// </summary>
    /// <value>Description of the of the named entity type.</value>
    public string Description { get; set; }

    /// <summary>
    /// The mechanism enabling detection of the named entity type.
    /// </summary>
    /// <value>The mechanism enabling detection of the named entity type.</value>
    public NamedEntityTypeMechanism Mechanism { get; set; }
}
