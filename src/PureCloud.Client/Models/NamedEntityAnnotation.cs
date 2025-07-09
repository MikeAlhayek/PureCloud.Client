using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityAnnotation
{
    /// <summary>
    /// The name of the annotated named entity.
    /// </summary>
    /// <value>The name of the annotated named entity.</value>
    public string Name { get; set; }
}
