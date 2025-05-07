using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentManagementSingleDocumentTopicDocumentDataV2
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
    public ContentManagementSingleDocumentTopicWorkspaceData Workspace { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public ContentManagementSingleDocumentTopicUserData CreatedBy { get; set; }

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
    public ContentManagementSingleDocumentTopicUserData UploadedBy { get; set; }

    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    public ContentManagementSingleDocumentTopicLockData LockInfo { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
