using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FacetStatistics
{
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    public long? Count { get; set; }

    /// <summary>
    /// Gets or Sets Min
    /// </summary>
    public double? Min { get; set; }

    /// <summary>
    /// Gets or Sets Max
    /// </summary>
    public double? Max { get; set; }

    /// <summary>
    /// Gets or Sets Mean
    /// </summary>
    public double? Mean { get; set; }

    /// <summary>
    /// Gets or Sets StdDeviation
    /// </summary>
    public double? StdDeviation { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateMin { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateMax { get; set; }
}
