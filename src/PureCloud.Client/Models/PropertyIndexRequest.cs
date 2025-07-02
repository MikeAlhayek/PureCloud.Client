using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Models;

public sealed class PropertyIndexRequest
{
    /// <summary>
    /// Attach properties to a segment in the indicated session
    /// </summary>
    /// <value>Attach properties to a segment in the indicated session</value>
    public string SessionId { get; set; }

    /// <summary>
    /// Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? TargetDate { get; set; }

    /// <summary>
    /// The list of properties to index
    /// </summary>
    /// <value>The list of properties to index</value>
    public IEnumerable<AnalyticsProperty> Properties { get; set; }
}
