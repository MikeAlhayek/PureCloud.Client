using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class JourneyWebEventsNotificationCustomEventAttribute
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    public JourneyWebEventsNotificationCustomEventAttributeDataTypeEnum? DataType { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
