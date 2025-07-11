using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAnnotation
{
    /// <summary>
    /// Determines the permissions required to view this item.
    /// </summary>
    /// <value>Determines the permissions required to view this item.</value>
    public CoachingAnnotationAccessTypeEnum? AccessType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The user who created the annotation.
    /// </summary>
    /// <value>The user who created the annotation.</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The date/time the annotation was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the annotation was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The last user to modify the annotation.
    /// </summary>
    /// <value>The last user to modify the annotation.</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// The date/time the annotation was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the annotation was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The text of the annotation.
    /// </summary>
    /// <value>The text of the annotation.</value>
    public string Text { get; set; }

    /// <summary>
    /// Flag indicating whether the annotation is deleted.
    /// </summary>
    /// <value>Flag indicating whether the annotation is deleted.</value>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
