using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DevelopmentActivity
{
    /// <summary>
    /// Module archive type
    /// </summary>
    /// <value>Module archive type</value>
    public DevelopmentActivityArchivalModeEnum? ArchivalMode { get; set; }

    /// <summary>
    /// The type of activity
    /// </summary>
    /// <value>The type of activity</value>
    public DevelopmentActivityTypeEnum? Type { get; set; }

    /// <summary>
    /// The status of the activity
    /// </summary>
    /// <value>The status of the activity</value>
    public DevelopmentActivityStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// User that created activity
    /// </summary>
    /// <value>User that created activity</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The user&#39;s percentage score for this activity
    /// </summary>
    /// <value>The user&#39;s percentage score for this activity</value>
    public float? PercentageScore { get; set; }

    /// <summary>
    /// True if the activity was passed
    /// </summary>
    /// <value>True if the activity was passed</value>
    public bool? IsPassed { get; set; }

    /// <summary>
    /// True if this is the latest version of assignment assigned to the user
    /// </summary>
    /// <value>True if this is the latest version of assignment assigned to the user</value>
    public bool? IsLatest { get; set; }

    /// <summary>
    /// True if the associated module is archived
    /// </summary>
    /// <value>True if the associated module is archived</value>
    public bool? IsModuleArchived { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The name of the activity
    /// </summary>
    /// <value>The name of the activity</value>
    public string Name { get; set; }

    /// <summary>
    /// Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateDue { get; set; }

    /// <summary>
    /// Facilitator of the activity
    /// </summary>
    /// <value>Facilitator of the activity</value>
    public UserReference Facilitator { get; set; }

    /// <summary>
    /// List of users attending the activity
    /// </summary>
    /// <value>List of users attending the activity</value>
    public IEnumerable<UserReference> Attendees { get; set; }

    /// <summary>
    /// Indicates if the activity is overdue
    /// </summary>
    /// <value>Indicates if the activity is overdue</value>
    public bool? IsOverdue { get; set; }
}
