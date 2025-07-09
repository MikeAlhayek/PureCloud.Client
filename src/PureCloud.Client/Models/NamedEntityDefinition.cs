using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityDefinition
{
    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    public string Name { get; set; }

    /// <summary>
    /// The name of the entity type.
    /// </summary>
    /// <value>The name of the entity type.</value>
    public string Type { get; set; }
}
