using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmailInitialConfiguration
{
    /// <summary>
    /// An email address that this email is to.
    /// </summary>
    /// <value>An email address that this email is to.</value>
    public string To { get; set; }

    /// <summary>
    /// An email address that this email is from.
    /// </summary>
    /// <value>An email address that this email is from.</value>
    public string From { get; set; }

    /// <summary>
    /// An email addresses that this email is carbon copied to.
    /// </summary>
    /// <value>An email addresses that this email is carbon copied to.</value>
    public IEnumerable<string> Cc { get; set; }

    /// <summary>
    /// An email addresses that this email is blind carbon copied to.
    /// </summary>
    /// <value>An email addresses that this email is blind carbon copied to.</value>
    public IEnumerable<string> Bcc { get; set; }

    /// <summary>
    /// The subject for this email.
    /// </summary>
    /// <value>The subject for this email.</value>
    public string Subject { get; set; }

    /// <summary>
    /// UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.
    /// </summary>
    /// <value>UUID identifying the most recent previous email communication ID from the same participant on this email conversation. Will be null if this is a new participant.</value>
    public string PreviousEmailId { get; set; }

    /// <summary>
    /// Indicates that this communication&#39;s initial state is held.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is held.</value>
    public bool? Held { get; set; }

    /// <summary>
    /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
    /// </summary>
    /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
    public bool? Alerting { get; set; }

    /// <summary>
    /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
    /// </summary>
    /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
    public bool? Inbound { get; set; }

    /// <summary>
    /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
    /// </summary>
    /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
    public string InvitedBy { get; set; }

    /// <summary>
    /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
    /// </summary>
    /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
    public Dictionary<string, string> AdditionalInfo { get; set; }
}
