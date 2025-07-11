using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAppointmentAggregateResponse
{
    /// <summary>
    /// The results of the query
    /// </summary>
    /// <value>The results of the query</value>
    public IEnumerable<QueryResponseGroupedData> Results { get; set; }
}
