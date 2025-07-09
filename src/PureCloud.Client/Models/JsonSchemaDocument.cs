using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JsonSchemaDocument
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    public string Schema { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    public IEnumerable<string> Required { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    public Dictionary<string, object> Properties { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public object AdditionalProperties { get; set; }
}
