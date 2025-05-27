using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserActivityResponse
{
    /// <summary>
    /// Dimension that is used as an entityId
    /// </summary>
    /// <value>Dimension that is used as an entityId</value>
    public UserActivityResponseEntityIdDimensionEnum? EntityIdDimension { get; set; }

    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    public IEnumerable<UserActivityData> Results { get; set; }
}
