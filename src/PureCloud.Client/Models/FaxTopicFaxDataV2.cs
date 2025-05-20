using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FaxTopicFaxDataV2
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
    public FaxTopicWorkspaceData Workspace { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public FaxTopicUserData CreatedBy { get; set; }

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
    public FaxTopicUserData UploadedBy { get; set; }

    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    public FaxTopicLockData LockInfo { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    public string CallerAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReceiverAddress
    /// </summary>
    public string ReceiverAddress { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }
}
