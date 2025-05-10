using PureCloud.Client.Models.Queues;

namespace PureCloud.Client.Models;

public sealed class InboundRoute
{
    /// <summary>
    /// The configuration to indicate how the history of a conversation has to be included in a draft
    /// </summary>
    /// <value>The configuration to indicate how the history of a conversation has to be included in a draft</value>
    public HistoryInclusionEnum? HistoryInclusion { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The search pattern that the mailbox name should match.
    /// </summary>
    /// <value>The search pattern that the mailbox name should match.</value>
    public string Pattern { get; set; }

    /// <summary>
    /// The queue to route the emails to.
    /// </summary>
    /// <value>The queue to route the emails to.</value>
    public DomainEntityRef Queue { get; set; }

    /// <summary>
    /// The priority to use for routing.
    /// </summary>
    /// <value>The priority to use for routing.</value>
    public int? Priority { get; set; }

    /// <summary>
    /// The skills to use for routing.
    /// </summary>
    /// <value>The skills to use for routing.</value>
    public IEnumerable<DomainEntityRef> Skills { get; set; }

    /// <summary>
    /// The language to use for routing.
    /// </summary>
    /// <value>The language to use for routing.</value>
    public DomainEntityRef Language { get; set; }

    /// <summary>
    /// The sender name to use for outgoing replies.
    /// </summary>
    /// <value>The sender name to use for outgoing replies.</value>
    public string FromName { get; set; }

    /// <summary>
    /// The sender email to use for outgoing replies.
    /// </summary>
    /// <value>The sender email to use for outgoing replies.</value>
    public string FromEmail { get; set; }

    /// <summary>
    /// The flow to use for processing the email.
    /// </summary>
    /// <value>The flow to use for processing the email.</value>
    public DomainEntityRef Flow { get; set; }

    /// <summary>
    /// The route to use for email replies.
    /// </summary>
    /// <value>The route to use for email replies.</value>
    public QueueEmailAddress ReplyEmailAddress { get; set; }

    /// <summary>
    /// The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.
    /// </summary>
    /// <value>The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.</value>
    public IEnumerable<EmailAddress> AutoBcc { get; set; }

    /// <summary>
    /// The flow to use for processing inbound emails that have been marked as spam.
    /// </summary>
    /// <value>The flow to use for processing inbound emails that have been marked as spam.</value>
    public DomainEntityRef SpamFlow { get; set; }

    /// <summary>
    /// The configuration for the canned response signature that will be appended to outbound emails sent via this route
    /// </summary>
    /// <value>The configuration for the canned response signature that will be appended to outbound emails sent via this route</value>
    public Signature Signature { get; set; }

    /// <summary>
    /// Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action
    /// </summary>
    /// <value>Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action</value>
    public bool? AllowMultipleActions { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
