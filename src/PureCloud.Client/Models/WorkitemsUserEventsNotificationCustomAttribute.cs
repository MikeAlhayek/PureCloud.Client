using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsUserEventsNotificationCustomAttribute
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    public WorkitemsUserEventsNotificationCustomAttributeDataTypeEnum? DataType { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
