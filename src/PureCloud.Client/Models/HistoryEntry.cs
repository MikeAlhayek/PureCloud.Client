using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class HistoryEntry
{
    /// <summary>
    /// The action performed
    /// </summary>
    /// <value>The action performed</value>
    public HistoryEntryActionEnum? Action { get; set; }

    /// <summary>
    /// For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.
    /// </summary>
    /// <value>For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.</value>
    public string Resource { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// User associated with this entry.
    /// </summary>
    /// <value>User associated with this entry.</value>
    public User User { get; set; }

    /// <summary>
    /// OAuth client associated with this entry.
    /// </summary>
    /// <value>OAuth client associated with this entry.</value>
    public DomainEntityRef Client { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Secure
    /// </summary>
    public bool? Secure { get; set; }

    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    public bool? VirtualAgentEnabled { get; set; }
}
