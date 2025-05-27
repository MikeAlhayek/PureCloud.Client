using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DataAvailabilityResponse
{
    /// <summary>
    /// Date and time before which data is guaranteed to be available in the datalake. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time before which data is guaranteed to be available in the datalake. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DataAvailabilityDate { get; set; }
}
