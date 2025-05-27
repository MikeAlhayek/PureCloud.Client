using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Models;

public sealed class ChatPresence
{
    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public ChatPresenceSystemPresenceEnum? SystemPresence { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationPresence
    /// </summary>
    public OrganizationPresence OrganizationPresence { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets OutOfOffice
    /// </summary>
    public OutOfOffice OutOfOffice { get; set; }
}
