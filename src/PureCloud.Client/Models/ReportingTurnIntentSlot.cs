using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnIntentSlot
{
    /// <summary>
    /// The name of the slot.
    /// </summary>
    /// <value>The name of the slot.</value>
    public string Name { get; set; }

    /// <summary>
    /// The value of the slot.
    /// </summary>
    /// <value>The value of the slot.</value>
    public string Value { get; set; }

    /// <summary>
    /// The NLU entity type of the slot (either builtin or user defined)
    /// </summary>
    /// <value>The NLU entity type of the slot (either builtin or user defined)</value>
    public string Type { get; set; }

    /// <summary>
    /// The confidence score this slot received during detection.
    /// </summary>
    /// <value>The confidence score this slot received during detection.</value>
    public double? Confidence { get; set; }
}
