using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class HistoryListing
{
    /// <summary>
    /// Action name
    /// </summary>
    /// <value>Action name</value>
    public HistoryListingActionNameEnum? ActionName { get; set; }

    /// <summary>
    /// Action status
    /// </summary>
    /// <value>Action status</value>
    public HistoryListingActionStatusEnum? ActionStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Complete
    /// </summary>
    public bool? Complete { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    public DomainEntityRef Client { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDetails
    /// </summary>
    public IEnumerable<Detail> ErrorDetails { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessageParams
    /// </summary>
    public Dictionary<string, string> ErrorMessageParams { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    public bool? System { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Started { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Completed { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<HistoryEntry> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    public int? PageCount { get; set; }
}
