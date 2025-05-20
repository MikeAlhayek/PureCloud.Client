using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PersistentConnectionChangeTopicPersistentConnectionChangeEvent
{
    /// <summary>
    /// Gets or Sets PersistentState
    /// </summary>
    public PersistentConnectionChangeTopicPersistentConnectionChangeEventPersistentStateEnum? PersistentState { get; set; }

    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    public PersistentConnectionChangeTopicErrorInfo ErrorInfo { get; set; }

    /// <summary>
    /// Gets or Sets StationId
    /// </summary>
    public string StationId { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public DateTime? EventTime { get; set; }
}
