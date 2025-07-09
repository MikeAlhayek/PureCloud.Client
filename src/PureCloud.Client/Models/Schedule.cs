using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Schedule
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    public ScheduleStateEnum? State { get; set; }

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
    /// Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS</value>
    public DateTime? Start { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS</value>
    public DateTime? End { get; set; }

    /// <summary>
    /// An iCal Recurrence Rule (RRULE) string. It is required to be set for schedules determining when upgrades to the Edge software can be applied.
    /// </summary>
    /// <value>An iCal Recurrence Rule (RRULE) string. It is required to be set for schedules determining when upgrades to the Edge software can be applied.</value>
    public string Rrule { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
