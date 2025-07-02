using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UpdateAnalyticsDataRetentionRequest
{
    /// <summary>
    /// Analytics data retention period in days to set for the organization.
    /// </summary>
    /// <value>Analytics data retention period in days to set for the organization.</value>
    public int? RetentionDays { get; set; }
}
