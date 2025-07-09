using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmergencyGroup
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    public EmergencyGroupStateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    public string Description { get; set; }

    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    public int? Version { get; set; }

    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    public string CreatedBy { get; set; }

    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    public string ModifiedByApp { get; set; }

    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    public string CreatedByApp { get; set; }

    /// <summary>
    /// True if an emergency is occurring and the associated emergency call flow(s) should be used.  False otherwise.
    /// </summary>
    /// <value>True if an emergency is occurring and the associated emergency call flow(s) should be used.  False otherwise.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The emergency call flow(s) to use during an emergency.
    /// </summary>
    /// <value>The emergency call flow(s) to use during an emergency.</value>
    public IEnumerable<EmergencyCallFlow> EmergencyCallFlows { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
