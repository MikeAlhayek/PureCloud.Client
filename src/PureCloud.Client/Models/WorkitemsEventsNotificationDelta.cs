using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsEventsNotificationDelta
{
    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    public WorkitemsEventsNotificationDeltaOpEnum? Op { get; set; }

    /// <summary>
    /// Gets or Sets Field
    /// </summary>
    public string Field { get; set; }

    /// <summary>
    /// Gets or Sets OldValue
    /// </summary>
    public string OldValue { get; set; }

    /// <summary>
    /// Gets or Sets NewValue
    /// </summary>
    public string NewValue { get; set; }
}
