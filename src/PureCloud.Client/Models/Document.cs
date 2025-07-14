using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Document
{
    /// <summary>
    /// Gets or Sets SystemType
    /// </summary>
    public DocumentSystemTypeEnum? SystemType { get; set; }

    /// <summary>
    /// Gets or Sets UploadMethod
    /// </summary>
    public DocumentUploadMethodEnum? UploadMethod { get; set; }

    /// <summary>
    /// Gets or Sets SharingStatus
    /// </summary>
    public DocumentSharingStatusEnum? SharingStatus { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    public int? ChangeNumber { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateUploaded { get; set; }

    /// <summary>
    /// Gets or Sets ContentUri
    /// </summary>
    public string ContentUri { get; set; }

    /// <summary>
    /// Gets or Sets Workspace
    public DomainEntityRef Workspace { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets UploadedBy
    /// </summary>
    public DomainEntityRef UploadedBy { get; set; }

    /// <summary>
    /// Gets or Sets SharingUri
    /// </summary>
    public string SharingUri { get; set; }

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
    /// Gets or Sets PageCount
    /// </summary>
    public long? PageCount { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }

    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    public string CallerAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReceiverAddress
    /// </summary>
    public string ReceiverAddress { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets TagValues
    /// </summary>
    public IEnumerable<TagValue> TagValues { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public IEnumerable<DocumentAttribute> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    public IEnumerable<DocumentThumbnail> Thumbnails { get; set; }

    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    public DomainEntityRef UploadStatus { get; set; }

    /// <summary>
    /// Gets or Sets UploadDestinationUri
    /// </summary>
    public string UploadDestinationUri { get; set; }

    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    public LockInfo LockInfo { get; set; }

    /// <summary>
    /// A list of permitted action rights for the user making the request
    /// </summary>
    /// <value>A list of permitted action rights for the user making the request</value>
    public IEnumerable<string> Acl { get; set; }

    /// <summary>
    /// Gets or Sets DownloadSharingUri
    /// </summary>
    public string DownloadSharingUri { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
