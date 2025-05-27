using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AsyncQueryStatus
{
    /// <summary>
    /// The current state of the asynchronous query
    /// </summary>
    /// <value>The current state of the asynchronous query</value>
    public AsyncQueryStatusStateEnum? State { get; set; }

    /// <summary>
    /// The error associated with the current query, if the state is FAILED
    /// </summary>
    /// <value>The error associated with the current query, if the state is FAILED</value>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which results for this query will expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the query was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? SubmissionDate { get; set; }

    /// <summary>
    /// The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the query completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CompletionDate { get; set; }
}
