using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Section
{
    /// <summary>
    /// Gets or Sets FieldList
    /// </summary>
    [JsonPropertyName("fieldList")]
    public IEnumerable<FieldList> FieldList { get; set; }

    /// <summary>
    /// Gets or Sets InstructionText
    /// </summary>
    public string InstructionText { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public string State { get; set; }
}
