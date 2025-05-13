using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationAssociatedValue
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    public JourneyOutcomeEventsNotificationAssociatedValueDataTypeEnum? DataType { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public double? Value { get; set; }
}
