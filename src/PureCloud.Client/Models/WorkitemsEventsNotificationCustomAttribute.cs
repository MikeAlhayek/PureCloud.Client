using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsEventsNotificationCustomAttribute
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    public WorkitemsEventsNotificationCustomAttributeDataTypeEnum? DataType { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
