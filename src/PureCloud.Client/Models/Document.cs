using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Document
/// </summary>

public partial class Document : IEquatable<Document>
{
    /// <summary>
    /// Gets or Sets SystemType
    /// </summary>
    
    public enum SystemTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Document for "DOCUMENT"
        /// </summary>
        [EnumMember(Value = "DOCUMENT")]
        Document,

        /// <summary>
        /// Enum Fax for "FAX"
        /// </summary>
        [EnumMember(Value = "FAX")]
        Fax,

        /// <summary>
        /// Enum Recording for "RECORDING"
        /// </summary>
        [EnumMember(Value = "RECORDING")]
        Recording
    }
    /// <summary>
    /// Gets or Sets UploadMethod
    /// </summary>
    
    public enum UploadMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum SinglePut for "SINGLE_PUT"
        /// </summary>
        [EnumMember(Value = "SINGLE_PUT")]
        SinglePut,

        /// <summary>
        /// Enum MultipartPost for "MULTIPART_POST"
        /// </summary>
        [EnumMember(Value = "MULTIPART_POST")]
        MultipartPost
    }
    /// <summary>
    /// Gets or Sets SharingStatus
    /// </summary>
    
    public enum SharingStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Limited for "LIMITED"
        /// </summary>
        [EnumMember(Value = "LIMITED")]
        Limited,

        /// <summary>
        /// Enum Public for "PUBLIC"
        /// </summary>
        [EnumMember(Value = "PUBLIC")]
        Public
    }
    /// <summary>
    /// Gets or Sets SystemType
    /// </summary>
    [JsonPropertyName("systemType")]
    public SystemTypeEnum? SystemType { get; set; }
    /// <summary>
    /// Gets or Sets UploadMethod
    /// </summary>
    [JsonPropertyName("uploadMethod")]
    public UploadMethodEnum? UploadMethod { get; set; }
    /// <summary>
    /// Gets or Sets SharingStatus
    /// </summary>
    [JsonPropertyName("sharingStatus")]
    public SharingStatusEnum? SharingStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Document" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ChangeNumber">ChangeNumber.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateUploaded">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ContentUri">ContentUri.</param>
    /// <param name="Workspace">Workspace.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="UploadedBy">UploadedBy.</param>
    /// <param name="SharingUri">SharingUri.</param>
    /// <param name="ContentType">ContentType.</param>
    /// <param name="ContentLength">ContentLength.</param>
    /// <param name="SystemType">SystemType.</param>
    /// <param name="Filename">Filename.</param>
    /// <param name="PageCount">PageCount.</param>
    /// <param name="Read">Read.</param>
    /// <param name="CallerAddress">CallerAddress.</param>
    /// <param name="ReceiverAddress">ReceiverAddress.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="TagValues">TagValues.</param>
    /// <param name="Attributes">Attributes.</param>
    /// <param name="Thumbnails">Thumbnails.</param>
    /// <param name="UploadStatus">UploadStatus.</param>
    /// <param name="UploadDestinationUri">UploadDestinationUri.</param>
    /// <param name="UploadMethod">UploadMethod.</param>
    /// <param name="LockInfo">LockInfo.</param>
    /// <param name="Acl">A list of permitted action rights for the user making the request.</param>
    /// <param name="SharingStatus">SharingStatus.</param>
    /// <param name="DownloadSharingUri">DownloadSharingUri.</param>
    public Document(string Name = null, int? ChangeNumber = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateUploaded = null, string ContentUri = null, DomainEntityRef Workspace = null, DomainEntityRef CreatedBy = null, DomainEntityRef UploadedBy = null, string SharingUri = null, string ContentType = null, long? ContentLength = null, SystemTypeEnum? SystemType = null, string Filename = null, long? PageCount = null, bool? Read = null, string CallerAddress = null, string ReceiverAddress = null, List<string> Tags = null, List<TagValue> TagValues = null, List<DocumentAttribute> Attributes = null, List<DocumentThumbnail> Thumbnails = null, DomainEntityRef UploadStatus = null, string UploadDestinationUri = null, UploadMethodEnum? UploadMethod = null, LockInfo LockInfo = null, List<string> Acl = null, SharingStatusEnum? SharingStatus = null, string DownloadSharingUri = null)
    {
        this.Name = Name;
        this.ChangeNumber = ChangeNumber;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DateUploaded = DateUploaded;
        this.ContentUri = ContentUri;
        this.Workspace = Workspace;
        this.CreatedBy = CreatedBy;
        this.UploadedBy = UploadedBy;
        this.SharingUri = SharingUri;
        this.ContentType = ContentType;
        this.ContentLength = ContentLength;
        this.SystemType = SystemType;
        this.Filename = Filename;
        this.PageCount = PageCount;
        this.Read = Read;
        this.CallerAddress = CallerAddress;
        this.ReceiverAddress = ReceiverAddress;
        this.Tags = Tags;
        this.TagValues = TagValues;
        this.Attributes = Attributes;
        this.Thumbnails = Thumbnails;
        this.UploadStatus = UploadStatus;
        this.UploadDestinationUri = UploadDestinationUri;
        this.UploadMethod = UploadMethod;
        this.LockInfo = LockInfo;
        this.Acl = Acl;
        this.SharingStatus = SharingStatus;
        this.DownloadSharingUri = DownloadSharingUri;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    [JsonPropertyName("changeNumber")]
    public int? ChangeNumber { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateUploaded")]
    public DateTime? DateUploaded { get; set; }



    /// <summary>
    /// Gets or Sets ContentUri
    /// </summary>
    [JsonPropertyName("contentUri")]
    public string ContentUri { get; set; }



    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    [JsonPropertyName("workspace")]
    public DomainEntityRef Workspace { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [JsonPropertyName("createdBy")]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets UploadedBy
    /// </summary>
    [JsonPropertyName("uploadedBy")]
    public DomainEntityRef UploadedBy { get; set; }



    /// <summary>
    /// Gets or Sets SharingUri
    /// </summary>
    [JsonPropertyName("sharingUri")]
    public string SharingUri { get; set; }



    /// <summary>
    /// Gets or Sets ContentType
    /// </summary>
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; }



    /// <summary>
    /// Gets or Sets ContentLength
    /// </summary>
    [JsonPropertyName("contentLength")]
    public long? ContentLength { get; set; }





    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [JsonPropertyName("filename")]
    public string Filename { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public long? PageCount { get; set; }



    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    [JsonPropertyName("callerAddress")]
    public string CallerAddress { get; set; }



    /// <summary>
    /// Gets or Sets ReceiverAddress
    /// </summary>
    [JsonPropertyName("receiverAddress")]
    public string ReceiverAddress { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets TagValues
    /// </summary>
    [JsonPropertyName("tagValues")]
    public List<TagValue> TagValues { get; set; }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public List<DocumentAttribute> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    [JsonPropertyName("thumbnails")]
    public List<DocumentThumbnail> Thumbnails { get; set; }



    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    [JsonPropertyName("uploadStatus")]
    public DomainEntityRef UploadStatus { get; set; }



    /// <summary>
    /// Gets or Sets UploadDestinationUri
    /// </summary>
    [JsonPropertyName("uploadDestinationUri")]
    public string UploadDestinationUri { get; set; }





    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    [JsonPropertyName("lockInfo")]
    public LockInfo LockInfo { get; set; }



    /// <summary>
    /// A list of permitted action rights for the user making the request
    /// </summary>
    /// <value>A list of permitted action rights for the user making the request</value>
    [JsonPropertyName("acl")]
    public List<string> Acl { get; set; }





    /// <summary>
    /// Gets or Sets DownloadSharingUri
    /// </summary>
    [JsonPropertyName("downloadSharingUri")]
    public string DownloadSharingUri { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Document {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
        sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
        sb.Append("  SharingUri: ").Append(SharingUri).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
        sb.Append("  SystemType: ").Append(SystemType).Append("\n");
        sb.Append("  Filename: ").Append(Filename).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  ReceiverAddress: ").Append(ReceiverAddress).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  TagValues: ").Append(TagValues).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
        sb.Append("  UploadDestinationUri: ").Append(UploadDestinationUri).Append("\n");
        sb.Append("  UploadMethod: ").Append(UploadMethod).Append("\n");
        sb.Append("  LockInfo: ").Append(LockInfo).Append("\n");
        sb.Append("  Acl: ").Append(Acl).Append("\n");
        sb.Append("  SharingStatus: ").Append(SharingStatus).Append("\n");
        sb.Append("  DownloadSharingUri: ").Append(DownloadSharingUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as Document);
    }

    /// <summary>
    /// Returns true if Document instances are equal
    /// </summary>
    /// <param name="other">Instance of Document to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Document other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ChangeNumber == other.ChangeNumber ||
                ChangeNumber != null &&
                ChangeNumber.Equals(other.ChangeNumber)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateUploaded == other.DateUploaded ||
                DateUploaded != null &&
                DateUploaded.Equals(other.DateUploaded)
            ) &&
            (
                ContentUri == other.ContentUri ||
                ContentUri != null &&
                ContentUri.Equals(other.ContentUri)
            ) &&
            (
                Workspace == other.Workspace ||
                Workspace != null &&
                Workspace.Equals(other.Workspace)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                UploadedBy == other.UploadedBy ||
                UploadedBy != null &&
                UploadedBy.Equals(other.UploadedBy)
            ) &&
            (
                SharingUri == other.SharingUri ||
                SharingUri != null &&
                SharingUri.Equals(other.SharingUri)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                ContentLength == other.ContentLength ||
                ContentLength != null &&
                ContentLength.Equals(other.ContentLength)
            ) &&
            (
                SystemType == other.SystemType ||
                SystemType != null &&
                SystemType.Equals(other.SystemType)
            ) &&
            (
                Filename == other.Filename ||
                Filename != null &&
                Filename.Equals(other.Filename)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                CallerAddress == other.CallerAddress ||
                CallerAddress != null &&
                CallerAddress.Equals(other.CallerAddress)
            ) &&
            (
                ReceiverAddress == other.ReceiverAddress ||
                ReceiverAddress != null &&
                ReceiverAddress.Equals(other.ReceiverAddress)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                TagValues == other.TagValues ||
                TagValues != null &&
                TagValues.SequenceEqual(other.TagValues)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Thumbnails == other.Thumbnails ||
                Thumbnails != null &&
                Thumbnails.SequenceEqual(other.Thumbnails)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
            ) &&
            (
                UploadDestinationUri == other.UploadDestinationUri ||
                UploadDestinationUri != null &&
                UploadDestinationUri.Equals(other.UploadDestinationUri)
            ) &&
            (
                UploadMethod == other.UploadMethod ||
                UploadMethod != null &&
                UploadMethod.Equals(other.UploadMethod)
            ) &&
            (
                LockInfo == other.LockInfo ||
                LockInfo != null &&
                LockInfo.Equals(other.LockInfo)
            ) &&
            (
                Acl == other.Acl ||
                Acl != null &&
                Acl.SequenceEqual(other.Acl)
            ) &&
            (
                SharingStatus == other.SharingStatus ||
                SharingStatus != null &&
                SharingStatus.Equals(other.SharingStatus)
            ) &&
            (
                DownloadSharingUri == other.DownloadSharingUri ||
                DownloadSharingUri != null &&
                DownloadSharingUri.Equals(other.DownloadSharingUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ChangeNumber != null)
            {
                hash = hash * 59 + ChangeNumber.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateUploaded != null)
            {
                hash = hash * 59 + DateUploaded.GetHashCode();
            }

            if (ContentUri != null)
            {
                hash = hash * 59 + ContentUri.GetHashCode();
            }

            if (Workspace != null)
            {
                hash = hash * 59 + Workspace.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (UploadedBy != null)
            {
                hash = hash * 59 + UploadedBy.GetHashCode();
            }

            if (SharingUri != null)
            {
                hash = hash * 59 + SharingUri.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (ContentLength != null)
            {
                hash = hash * 59 + ContentLength.GetHashCode();
            }

            if (SystemType != null)
            {
                hash = hash * 59 + SystemType.GetHashCode();
            }

            if (Filename != null)
            {
                hash = hash * 59 + Filename.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (ReceiverAddress != null)
            {
                hash = hash * 59 + ReceiverAddress.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (TagValues != null)
            {
                hash = hash * 59 + TagValues.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Thumbnails != null)
            {
                hash = hash * 59 + Thumbnails.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            if (UploadDestinationUri != null)
            {
                hash = hash * 59 + UploadDestinationUri.GetHashCode();
            }

            if (UploadMethod != null)
            {
                hash = hash * 59 + UploadMethod.GetHashCode();
            }

            if (LockInfo != null)
            {
                hash = hash * 59 + LockInfo.GetHashCode();
            }

            if (Acl != null)
            {
                hash = hash * 59 + Acl.GetHashCode();
            }

            if (SharingStatus != null)
            {
                hash = hash * 59 + SharingStatus.GetHashCode();
            }

            if (DownloadSharingUri != null)
            {
                hash = hash * 59 + DownloadSharingUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
