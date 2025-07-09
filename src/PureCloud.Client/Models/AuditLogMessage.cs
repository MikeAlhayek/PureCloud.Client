using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditLogMessage
{
    /// <summary>
    /// Level of this audit message, USER or SYSTEM.
    /// </summary>
    /// <value>Level of this audit message, USER or SYSTEM.</value>
    public AuditLogMessageLevelEnum? Level { get; set; }

    /// <summary>
    /// Status of the event being audited
    /// </summary>
    /// <value>Status of the event being audited</value>
    public AuditLogMessageStatusEnum? Status { get; set; }

    /// <summary>
    /// Id of the audit message.
    /// </summary>
    /// <value>Id of the audit message.</value>
    public string Id { get; set; }

    /// <summary>
    /// Home Organization Id associated with this audit message.
    /// </summary>
    /// <value>Home Organization Id associated with this audit message.</value>
    public string UserHomeOrgId { get; set; }

    /// <summary>
    /// User associated with this audit message.
    /// </summary>
    /// <value>User associated with this audit message.</value>
    public DomainEntityRef User { get; set; }

    /// <summary>
    /// Client associated with this audit message.
    /// </summary>
    /// <value>Client associated with this audit message.</value>
    public AddressableEntityRef Client { get; set; }

    /// <summary>
    /// List of IP addresses of systems that originated or handled the request.
    /// </summary>
    /// <value>List of IP addresses of systems that originated or handled the request.</value>
    public IEnumerable<string> RemoteIp { get; set; }

    /// <summary>
    /// Name of the service that logged this audit message.
    /// </summary>
    /// <value>Name of the service that logged this audit message.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventDate { get; set; }

    /// <summary>
    /// Message describing the event being audited.
    /// </summary>
    /// <value>Message describing the event being audited.</value>
    public MessageInfo Message { get; set; }

    /// <summary>
    /// Action that took place.
    /// </summary>
    /// <value>Action that took place.</value>
    public string Action { get; set; }

    /// <summary>
    /// Entity that was impacted.
    /// </summary>
    /// <value>Entity that was impacted.</value>
    public DomainEntityRef Entity { get; set; }

    /// <summary>
    /// Type of the entity that was impacted.
    /// </summary>
    /// <value>Type of the entity that was impacted.</value>
    public string EntityType { get; set; }

    /// <summary>
    /// Name of the application used to perform the audit&#39;s action
    /// </summary>
    /// <value>Name of the application used to perform the audit&#39;s action</value>
    public string Application { get; set; }

    /// <summary>
    /// Id and action of the audit initiating the transaction
    /// </summary>
    /// <value>Id and action of the audit initiating the transaction</value>
    public InitiatingAction InitiatingAction { get; set; }

    /// <summary>
    /// Whether the current audit is the initiator of the transaction
    /// </summary>
    /// <value>Whether the current audit is the initiator of the transaction</value>
    public bool? TransactionInitiator { get; set; }

    /// <summary>
    /// List of properties that were changed and changes made to those properties.
    /// </summary>
    /// <value>List of properties that were changed and changes made to those properties.</value>
    public IEnumerable<PropertyChange> PropertyChanges { get; set; }

    /// <summary>
    /// Additional context for this message.
    /// </summary>
    /// <value>Additional context for this message.</value>
    public Dictionary<string, string> Context { get; set; }

    /// <summary>
    /// List of entities that were changed and changes made to those entities.
    /// </summary>
    /// <value>List of entities that were changed and changes made to those entities.</value>
    public IEnumerable<EntityChange> EntityChanges { get; set; }
}
