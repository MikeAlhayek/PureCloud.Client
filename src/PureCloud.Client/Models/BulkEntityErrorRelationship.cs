using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkEntityErrorRelationship
{
    /// <summary>
    /// An error code for the specific error condition.
    /// </summary>
    /// <value>An error code for the specific error condition.</value>
    public string Code { get; set; }

    /// <summary>
    /// A short error message.
    /// </summary>
    /// <value>A short error message.</value>
    public string Message { get; set; }

    /// <summary>
    /// The HTTP Status Code for the error.
    /// </summary>
    /// <value>The HTTP Status Code for the error.</value>
    public int? Status { get; set; }

    /// <summary>
    /// Whether this particular error should be retried.
    /// </summary>
    /// <value>Whether this particular error should be retried.</value>
    public bool? Retryable { get; set; }

    /// <summary>
    /// Additional error details for specific fields.
    /// </summary>
    /// <value>Additional error details for specific fields.</value>
    public IEnumerable<BulkErrorDetail> Details { get; set; }

    /// <summary>
    /// The entity body specified in the Bulk request operation that caused this error.
    /// </summary>
    /// <value>The entity body specified in the Bulk request operation that caused this error.</value>
    public Relationship Entity { get; set; }
}
