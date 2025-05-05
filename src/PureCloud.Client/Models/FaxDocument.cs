using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxDocument
/// </summary>

public partial class FaxDocument : IEquatable<FaxDocument>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxDocument" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ContentUri">ContentUri.</param>
    /// <param name="Workspace">Workspace.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="SharingUri">SharingUri.</param>
    /// <param name="ContentType">ContentType.</param>
    /// <param name="ContentLength">ContentLength.</param>
    /// <param name="Filename">Filename.</param>
    /// <param name="Read">Read.</param>
    /// <param name="PageCount">PageCount.</param>
    /// <param name="CallerAddress">CallerAddress.</param>
    /// <param name="ReceiverAddress">ReceiverAddress.</param>
    /// <param name="Thumbnails">Thumbnails.</param>
    /// <param name="DownloadSharingUri">DownloadSharingUri.</param>
    public FaxDocument(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ContentUri = null, DomainEntityRef Workspace = null, DomainEntityRef CreatedBy = null, string SharingUri = null, string ContentType = null, long? ContentLength = null, string Filename = null, bool? Read = null, long? PageCount = null, string CallerAddress = null, string ReceiverAddress = null, List<DocumentThumbnail> Thumbnails = null, string DownloadSharingUri = null)
    {
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.ContentUri = ContentUri;
        this.Workspace = Workspace;
        this.CreatedBy = CreatedBy;
        this.SharingUri = SharingUri;
        this.ContentType = ContentType;
        this.ContentLength = ContentLength;
        this.Filename = Filename;
        this.Read = Read;
        this.PageCount = PageCount;
        this.CallerAddress = CallerAddress;
        this.ReceiverAddress = ReceiverAddress;
        this.Thumbnails = Thumbnails;
        this.DownloadSharingUri = DownloadSharingUri;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



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
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public long? PageCount { get; set; }



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
    /// Gets or Sets Thumbnails
    /// </summary>
    [JsonPropertyName("thumbnails")]
    public List<DocumentThumbnail> Thumbnails { get; set; }



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
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FaxDocument {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  SharingUri: ").Append(SharingUri).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
        sb.Append("  Filename: ").Append(Filename).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  ReceiverAddress: ").Append(ReceiverAddress).Append("\n");
        sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
        return Equals(obj as FaxDocument);
    }

    /// <summary>
    /// Returns true if FaxDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxDocument other)
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
                Filename == other.Filename ||
                Filename != null &&
                Filename.Equals(other.Filename)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
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
                Thumbnails == other.Thumbnails ||
                Thumbnails != null &&
                Thumbnails.SequenceEqual(other.Thumbnails)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
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

            if (Filename != null)
            {
                hash = hash * 59 + Filename.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (ReceiverAddress != null)
            {
                hash = hash * 59 + ReceiverAddress.GetHashCode();
            }

            if (Thumbnails != null)
            {
                hash = hash * 59 + Thumbnails.GetHashCode();
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
