using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DashboardConfigurationBulkRequest
{
    /// <summary>
    /// The user supplied dashboard configuration ids
    /// </summary>
    /// <value>The user supplied dashboard configuration ids</value>
    public IEnumerable<string> DashboardConfigurationIds { get; set; }
}
