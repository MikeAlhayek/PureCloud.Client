using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxTopicFaxDataV2
/// </summary>

public partial class FaxTopicFaxDataV2 : IEquatable<FaxTopicFaxDataV2>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxTopicFaxDataV2" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="Workspace">Workspace.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="ContentType">ContentType.</param>
    /// <param name="ContentLength">ContentLength.</param>
    /// <param name="Filename">Filename.</param>
    /// <param name="ChangeNumber">ChangeNumber.</param>
    /// <param name="DateUploaded">DateUploaded.</param>
    /// <param name="UploadedBy">UploadedBy.</param>
    /// <param name="LockInfo">LockInfo.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="CallerAddress">CallerAddress.</param>
    /// <param name="ReceiverAddress">ReceiverAddress.</param>
    /// <param name="Read">Read.</param>
    public FaxTopicFaxDataV2(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, FaxTopicWorkspaceData Workspace = null, FaxTopicUserData CreatedBy = null, string ContentType = null, long? ContentLength = null, string Filename = null, long? ChangeNumber = null, DateTime? DateUploaded = null, FaxTopicUserData UploadedBy = null, FaxTopicLockData LockInfo = null, string SelfUri = null, string CallerAddress = null, string ReceiverAddress = null, bool? Read = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Workspace = Workspace;
        this.CreatedBy = CreatedBy;
        this.ContentType = ContentType;
        this.ContentLength = ContentLength;
        this.Filename = Filename;
        this.ChangeNumber = ChangeNumber;
        this.DateUploaded = DateUploaded;
        this.UploadedBy = UploadedBy;
        this.LockInfo = LockInfo;
        this.SelfUri = SelfUri;
        this.CallerAddress = CallerAddress;
        this.ReceiverAddress = ReceiverAddress;
        this.Read = Read;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    [JsonPropertyName("workspace")]
    public FaxTopicWorkspaceData Workspace { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [JsonPropertyName("createdBy")]
    public FaxTopicUserData CreatedBy { get; set; }



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
    /// Gets or Sets ChangeNumber
    /// </summary>
    [JsonPropertyName("changeNumber")]
    public long? ChangeNumber { get; set; }



    /// <summary>
    /// Gets or Sets DateUploaded
    /// </summary>
    [JsonPropertyName("dateUploaded")]
    public DateTime? DateUploaded { get; set; }



    /// <summary>
    /// Gets or Sets UploadedBy
    /// </summary>
    [JsonPropertyName("uploadedBy")]
    public FaxTopicUserData UploadedBy { get; set; }



    /// <summary>
    /// Gets or Sets LockInfo
    /// </summary>
    [JsonPropertyName("lockInfo")]
    public FaxTopicLockData LockInfo { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



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
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FaxTopicFaxDataV2 {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
        sb.Append("  Filename: ").Append(Filename).Append("\n");
        sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
        sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
        sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
        sb.Append("  LockInfo: ").Append(LockInfo).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  ReceiverAddress: ").Append(ReceiverAddress).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
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
        return Equals(obj as FaxTopicFaxDataV2);
    }

    /// <summary>
    /// Returns true if FaxTopicFaxDataV2 instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxTopicFaxDataV2 to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxTopicFaxDataV2 other)
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
                ChangeNumber == other.ChangeNumber ||
                ChangeNumber != null &&
                ChangeNumber.Equals(other.ChangeNumber)
            ) &&
            (
                DateUploaded == other.DateUploaded ||
                DateUploaded != null &&
                DateUploaded.Equals(other.DateUploaded)
            ) &&
            (
                UploadedBy == other.UploadedBy ||
                UploadedBy != null &&
                UploadedBy.Equals(other.UploadedBy)
            ) &&
            (
                LockInfo == other.LockInfo ||
                LockInfo != null &&
                LockInfo.Equals(other.LockInfo)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
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

            if (Workspace != null)
            {
                hash = hash * 59 + Workspace.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
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

            if (ChangeNumber != null)
            {
                hash = hash * 59 + ChangeNumber.GetHashCode();
            }

            if (DateUploaded != null)
            {
                hash = hash * 59 + DateUploaded.GetHashCode();
            }

            if (UploadedBy != null)
            {
                hash = hash * 59 + UploadedBy.GetHashCode();
            }

            if (LockInfo != null)
            {
                hash = hash * 59 + LockInfo.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (ReceiverAddress != null)
            {
                hash = hash * 59 + ReceiverAddress.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            return hash;
        }
    }
}
