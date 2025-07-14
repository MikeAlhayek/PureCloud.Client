using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MaskingRuleValidateResponse
{
    /// <summary>
    /// is masking rule definition valid?
    /// </summary>
    /// <value>is masking rule definition valid?</value>
    public bool? Valid { get; set; }

    /// <summary>
    /// Validation message.
    /// </summary>
    /// <value>Validation message.</value>
    public string ValidationMessage { get; set; }

    /// <summary>
    /// Masked text.
    /// </summary>
    /// <value>Masked text.</value>
    public string MaskedText { get; set; }
}
