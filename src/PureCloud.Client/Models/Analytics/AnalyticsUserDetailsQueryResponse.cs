using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsUserDetailsQueryResponse
{
    /// <summary>
    /// Gets or Sets UserDetails
    /// </summary>
    public IEnumerable<AnalyticsUserDetail> UserDetails { get; set; }

    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    public IEnumerable<AggregationResult> Aggregations { get; set; }

    /// <summary>
    /// Gets or Sets TotalHits
    /// </summary>
    public int? TotalHits { get; set; }
}
