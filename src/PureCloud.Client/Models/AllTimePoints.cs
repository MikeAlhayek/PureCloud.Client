using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AllTimePoints
{
    /// <summary>
    /// Queried user
    /// </summary>
    /// <value>Queried user</value>
    public UserReference User { get; set; }

    /// <summary>
    /// Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Queried end workday for all time points to be collected. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// All time point collected bt the user
    /// </summary>
    /// <value>All time point collected bt the user</value>
    public long? _AllTimePoints { get; set; }
}
