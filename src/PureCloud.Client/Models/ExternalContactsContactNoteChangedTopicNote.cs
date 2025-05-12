using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsContactNoteChangedTopicNote
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public ExternalContactsContactNoteChangedTopicNoteEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ExternalContactsContactNoteChangedTopicDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    public string EntityId { get; set; }

    /// <summary>
    /// Gets or Sets NoteText
    /// </summary>
    public string NoteText { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public ExternalContactsContactNoteChangedTopicUser CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    public DateTime? ModifyDate { get; set; }
}
