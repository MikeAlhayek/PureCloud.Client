using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Workspace
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WorkspaceTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The current name of the workspace.
    /// </summary>
    /// <value>The current name of the workspace.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets IsCurrentUserWorkspace
    /// </summary>
    public bool? IsCurrentUserWorkspace { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public DomainEntityRef User { get; set; }

    /// <summary>
    /// Gets or Sets Bucket
    /// </summary>
    public string Bucket { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    public WorkspaceSummary Summary { get; set; }

    /// <summary>
    /// Gets or Sets Acl
    /// </summary>
    public IEnumerable<string> Acl { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
