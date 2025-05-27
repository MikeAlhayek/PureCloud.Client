using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class ChatUserRef
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets Jid
    /// </summary>
    public string Jid { get; set; }

    /// <summary>
    /// Gets or Sets Inactive
    /// </summary>
    public bool? Inactive { get; set; }

    /// <summary>
    /// Gets or Sets Integrations
    /// </summary>
    public IEnumerable<Contact> Integrations { get; set; }

    /// <summary>
    /// Gets or Sets Presence
    /// </summary>
    public ChatPresence Presence { get; set; }
}
