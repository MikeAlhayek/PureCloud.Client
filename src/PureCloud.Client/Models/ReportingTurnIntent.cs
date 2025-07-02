using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnIntent
{
    /// <summary>
    /// The name of the intent detected during this reporting turn.
    /// </summary>
    /// <value>The name of the intent detected during this reporting turn.</value>
    public string Name { get; set; }

    /// <summary>
    /// The confidence score of the intent detected during this reporting turn.
    /// </summary>
    /// <value>The confidence score of the intent detected during this reporting turn.</value>
    public double? Confidence { get; set; }

    /// <summary>
    /// The slots detected during this reporting turn.
    /// </summary>
    /// <value>The slots detected during this reporting turn.</value>
    public IEnumerable<ReportingTurnIntentSlot> Slots { get; set; }
}
