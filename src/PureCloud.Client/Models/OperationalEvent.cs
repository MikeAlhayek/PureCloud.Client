namespace PureCloud.Client.Models;

/// <summary>
/// OperationalEvent
/// </summary>
public sealed class OperationalEvent
{
    /// <summary>
    /// The event that occurred.
    /// </summary>
    public AddressableEntityRef EventDefinition { get; set; }

    /// <summary>
    /// The unique identifier for the entity
    /// </summary>
    public string EntityId { get; set; }

    /// <summary>
    /// A token representing the entity
    /// </summary>
    public string EntityToken { get; set; }

    /// <summary>
    /// The name for the entity
    /// </summary>
    public string EntityName { get; set; }

    /// <summary>
    /// The value prior to the event
    /// </summary>
    public string PreviousValue { get; set; }

    /// <summary>
    /// The changed value following the event
    /// </summary>
    public string CurrentValue { get; set; }

    /// <summary>
    /// The error code of the entity in the providing service associated to the event
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// The unique identifier for the parent of the entity
    /// </summary>
    public string ParentEntityId { get; set; }

    /// <summary>
    /// The link to a conversation
    /// </summary>
    public AddressableEntityRef Conversation { get; set; }

    /// <summary>
    /// The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The version of the entity in the providing service
    /// </summary>
    public string EntityVersion { get; set; }
}
