using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Note
{
    /// <summary>
    /// This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.
    /// </summary>
    /// <value>This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.</value>
    public NoteEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.
    /// </summary>
    /// <value>The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.</value>
    public string EntityId { get; set; }

    /// <summary>
    /// Gets or Sets NoteText
    /// </summary>
    public string NoteText { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifyDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.
    /// </summary>
    /// <value>When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.</value>
    public User CreatedBy { get; set; }

    /// <summary>
    /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
    public IEnumerable<ExternalDataSource> ExternalDataSources { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
