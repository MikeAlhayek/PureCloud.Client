using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactsExport
{
    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    public ContactsExportStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Division IDs of entities
    /// </summary>
    /// <value>Division IDs of entities</value>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// Query conditions to apply on export
    /// </summary>
    /// <value>Query conditions to apply on export</value>
    public ContactsExportQueryConditions QueryConditions { get; set; }

    /// <summary>
    /// The user that created this request
    /// </summary>
    /// <value>The user that created this request</value>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The location where the results of the request can be retrieved
    /// </summary>
    /// <value>The location where the results of the request can be retrieved</value>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
