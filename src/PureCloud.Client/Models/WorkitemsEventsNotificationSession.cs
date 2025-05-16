using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsEventsNotificationSession
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WorkitemsEventsNotificationSessionTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WorkitemsEventsNotificationSessionStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionStart
    /// </summary>
    public string DateSessionStart { get; set; }

    /// <summary>
    /// Gets or Sets DateSessionEnd
    /// </summary>
    public string DateSessionEnd { get; set; }

    /// <summary>
    /// Gets or Sets AssignmentSegments
    /// </summary>
    public IEnumerable<WorkitemsEventsNotificationAssignmentSegment> AssignmentSegments { get; set; }
}
