using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoleSettings
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Boolean showing if organization is opted in or not to role backfills
    /// </summary>
    /// <value>Boolean showing if organization is opted in or not to role backfills</value>
    public bool? BackfillEnabled { get; set; }

    /// <summary>
    /// Boolean enabling enforcement of division aware for authorization grant add and delete
    /// </summary>
    /// <value>Boolean enabling enforcement of division aware for authorization grant add and delete</value>
    public bool? AuthorizationGrantDivisionAware { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
