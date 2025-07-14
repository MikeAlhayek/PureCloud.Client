using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommandStatus
{
    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    public CommandStatusStatusCodeEnum? StatusCode { get; set; }

    /// <summary>
    /// Gets or Sets CommandType
    /// </summary>
    public CommandStatusCommandTypeEnum? CommandType { get; set; }

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
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    public Document Document { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
