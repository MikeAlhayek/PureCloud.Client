using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class VoicemailMessagesTopicVoicemailMessage
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }

    /// <summary>
    /// Gets or Sets AudioRecordingDurationSeconds
    /// </summary>
    public long? AudioRecordingDurationSeconds { get; set; }

    /// <summary>
    /// Gets or Sets AudioRecordingSizeBytes
    /// </summary>
    public long? AudioRecordingSizeBytes { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateString
    /// </summary>
    public string CreatedDateString { get; set; }

    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    public string CallerAddress { get; set; }

    /// <summary>
    /// Gets or Sets CallerName
    /// </summary>
    public string CallerName { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Gets or Sets Deleted
    /// </summary>
    public bool? Deleted { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedByUserId
    /// </summary>
    public string ModifiedByUserId { get; set; }

    /// <summary>
    /// Gets or Sets CopiedTo
    /// </summary>
    public IEnumerable<VoicemailMessagesTopicVoicemailCopyRecord> CopiedTo { get; set; }

    /// <summary>
    /// Gets or Sets CopiedFrom
    /// </summary>
    public VoicemailMessagesTopicVoicemailCopyRecord CopiedFrom { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateString
    /// </summary>
    public string ModifiedDateString { get; set; }
}
