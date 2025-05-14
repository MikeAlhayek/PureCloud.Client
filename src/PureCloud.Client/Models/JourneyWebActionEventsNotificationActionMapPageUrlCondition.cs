using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class JourneyWebActionEventsNotificationActionMapPageUrlCondition
{
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public JourneyWebActionEventsNotificationActionMapPageUrlConditionOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    public IEnumerable<string> Values { get; set; }
}
