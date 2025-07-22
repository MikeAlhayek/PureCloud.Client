using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class IntegrationStatusInfo
{
    /// <summary>
    /// Machine-readable status as reported by the integration.
    /// </summary>
    /// <value>Machine-readable status as reported by the integration.</value>
    public IntegrationStatusInfoCodeEnum? Code { get; set; }

    /// <summary>
    /// Localized, human-readable, effective status of the integration.
    /// </summary>
    /// <value>Localized, human-readable, effective status of the integration.</value>
    public string Effective { get; set; }

    /// <summary>
    /// Localizable status details for the integration.
    /// </summary>
    /// <value>Localizable status details for the integration.</value>
    public MessageInfo Detail { get; set; }

    /// <summary>
    /// Date and time (in UTC) when the integration status (i.e. the code field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time (in UTC) when the integration status (i.e. the code field) was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? LastUpdated { get; set; }
}
