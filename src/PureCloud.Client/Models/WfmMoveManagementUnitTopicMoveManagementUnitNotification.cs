using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmMoveManagementUnitTopicMoveManagementUnitNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmMoveManagementUnitTopicMoveManagementUnitNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    public WfmMoveManagementUnitTopicBusinessUnit BusinessUnit { get; set; }
}
