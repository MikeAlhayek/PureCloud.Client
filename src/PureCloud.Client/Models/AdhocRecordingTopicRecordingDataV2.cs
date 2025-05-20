using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AdhocRecordingTopicRecordingDataV2
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    public AdhocRecordingTopicWorkspaceData Workspace { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public AdhocRecordingTopicUserData CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets ContentType
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Gets or Sets ContentLength
    /// </summary>
    public long? ContentLength { get; set; }

    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    public long? ChangeNumber { get; set; }

    /// <summary>
    /// Gets or Sets DateUploaded
    /// </summary>
    public DateTime? DateUploaded { get; set; }

    /// <summary>
    /// Gets or Sets UploadedBy
    /// </summary>
    public AdhocRecordingTopicUserData UploadedBy { get; set; }

    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    public AdhocRecordingTopicLockData LockInfo { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets DurationMillieconds
    /// </summary>
    public long? DurationMillieconds { get; set; }

    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    public AdhocRecordingTopicConversationData Conversation { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }
}
