using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FaxConfig
{
    /// <summary>
    /// Whether to enable email notifications for this organization
    /// </summary>
    /// <value>Whether to enable email notifications for this organization</value>
    public bool? SendEmailNotifications { get; set; }

    /// <summary>
    /// Whether to disable PII for email notifications
    /// </summary>
    /// <value>Whether to disable PII for email notifications</value>
    public bool? DisableEmailPii { get; set; }
}
