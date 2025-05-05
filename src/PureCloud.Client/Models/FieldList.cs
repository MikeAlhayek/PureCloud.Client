namespace PureCloud.Client.Models;

public sealed class FieldList
{
    /// <summary>
    /// Gets or Sets CustomLabels
    /// </summary>
    public bool? CustomLabels { get; set; }

    /// <summary>
    /// Gets or Sets InstructionText
    /// </summary>
    public string InstructionText { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets LabelKeys
    /// </summary>
    public List<string> LabelKeys { get; set; }

    /// <summary>
    /// Gets or Sets Params
    /// </summary>
    public Dictionary<string, object> Params { get; set; }

    /// <summary>
    /// Gets or Sets Repeatable
    /// </summary>
    public bool? Repeatable { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets Gdpr
    /// </summary>
    public bool? Gdpr { get; set; }
}
