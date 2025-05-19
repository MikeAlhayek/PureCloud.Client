using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CallForwardingEventCallForwarding
{
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public CallForwardingEventUser User { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    public IEnumerable<CallForwardingEventCall> Calls { get; set; }

    /// <summary>
    /// Gets or Sets Voicemail
    /// </summary>
    public string Voicemail { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public DateTime? ModifiedDate { get; set; }
}
