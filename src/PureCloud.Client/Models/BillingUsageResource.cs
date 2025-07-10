using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BillingUsageResource
{
    /// <summary>
    /// Identifies the resource (e.g. license user, device).
    /// </summary>
    /// <value>Identifies the resource (e.g. license user, device).</value>
    public string Name { get; set; }

    /// <summary>
    /// The date that the usage was first observed by the billing subsystem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date that the usage was first observed by the billing subsystem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Date { get; set; }
}
