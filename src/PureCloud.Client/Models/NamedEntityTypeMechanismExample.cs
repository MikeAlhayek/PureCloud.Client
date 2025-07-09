using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityTypeMechanismExample
{
    /// <summary>
    /// Example input text
    /// </summary>
    /// <value>Example input text</value>
    public string Text { get; set; }

    /// <summary>
    /// Resolved entity value
    /// </summary>
    /// <value>Resolved entity value</value>
    public string ResolvedValue { get; set; }
}
