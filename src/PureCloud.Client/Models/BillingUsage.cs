using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BillingUsage
{
    /// <summary>
    /// Identifies the billable usage.
    /// </summary>
    /// <value>Identifies the billable usage.</value>
    public string Name { get; set; }

    /// <summary>
    /// The total amount of usage, expressed as a decimal number in string format.
    /// </summary>
    /// <value>The total amount of usage, expressed as a decimal number in string format.</value>
    public string TotalUsage { get; set; }

    /// <summary>
    /// The resources for which usage was observed (e.g. license users, devices).
    /// </summary>
    /// <value>The resources for which usage was observed (e.g. license users, devices).</value>
    public IEnumerable<BillingUsageResource> Resources { get; set; }
}
