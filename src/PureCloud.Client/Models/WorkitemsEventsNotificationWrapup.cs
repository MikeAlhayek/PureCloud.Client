using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsEventsNotificationWrapup
{
    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    public WorkitemsEventsNotificationWrapupOpEnum? Op { get; set; }
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public WorkitemsEventsNotificationWrapupActionEnum? Action { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public Guid? UserId { get; set; }
}
