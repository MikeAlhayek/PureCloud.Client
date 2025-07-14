using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MaskingRuleValidateRequest
{
    /// <summary>
    /// Text to mask.
    /// </summary>
    /// <value>Text to mask.</value>
    public string Text { get; set; }

    /// <summary>
    /// Regex to be applied
    /// </summary>
    /// <value>Regex to be applied</value>
    public string Definition { get; set; }
}
