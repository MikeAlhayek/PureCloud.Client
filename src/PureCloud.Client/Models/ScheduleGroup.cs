using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ScheduleGroup
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    public ScheduleGroupStateEnum? State { get; set; }

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
    /// The timezone the schedules are a part of.  This is not a schedule property to allow a schedule to be used in multiple timezones.
    /// </summary>
    /// <value>The timezone the schedules are a part of.  This is not a schedule property to allow a schedule to be used in multiple timezones.</value>
    public string TimeZone { get; set; }

    /// <summary>
    /// The schedules defining the hours an organization is open.
    /// </summary>
    /// <value>The schedules defining the hours an organization is open.</value>
    public IEnumerable<DomainEntityRef> OpenSchedules { get; set; }

    /// <summary>
    /// The schedules defining the hours an organization is closed.
    /// </summary>
    /// <value>The schedules defining the hours an organization is closed.</value>
    public IEnumerable<DomainEntityRef> ClosedSchedules { get; set; }

    /// <summary>
    /// The schedules defining the hours an organization is closed for the holidays.
    /// </summary>
    /// <value>The schedules defining the hours an organization is closed for the holidays.</value>
    public IEnumerable<DomainEntityRef> HolidaySchedules { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
