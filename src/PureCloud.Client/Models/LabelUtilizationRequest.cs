using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LabelUtilizationRequest
{
    /// <summary>
    /// Defines the maximum number of interactions with this label that an agent can handle at one time.
    /// </summary>
    /// <value>Defines the maximum number of interactions with this label that an agent can handle at one time.</value>
    public int? MaximumCapacity { get; set; }

    /// <summary>
    /// Defines other labels that can interrupt an interaction with this label.
    /// </summary>
    /// <value>Defines other labels that can interrupt an interaction with this label.</value>
    public IEnumerable<string> InterruptingLabelIds { get; set; }
}
