using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AssistantQueue
{
    /// <summary>
    /// The globally unique identifier for the queue.
    /// </summary>
    /// <value>The globally unique identifier for the queue.</value>
    public string Id { get; set; }

    /// <summary>
    /// List of media Types in which the assistant is activated for this queue.
    /// </summary>
    /// <value>List of media Types in which the assistant is activated for this queue.</value>
    public IEnumerable<AssistantQueueMediaTypesEnum> MediaTypes { get; set; }

    /// <summary>
    /// Assistant to which the queue is assigned.
    /// </summary>
    /// <value>Assistant to which the queue is assigned.</value>
    public Assistant Assistant { get; set; }

    /// <summary>
    /// Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
