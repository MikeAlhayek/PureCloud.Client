using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserRecording
/// </summary>
[DataContract]
public partial class UserRecording : IEquatable<UserRecording>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRecording" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ContentUri">ContentUri.</param>
    /// <param name="Workspace">Workspace.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="ContentLength">ContentLength.</param>
    /// <param name="DurationMilliseconds">DurationMilliseconds.</param>
    /// <param name="Thumbnails">Thumbnails.</param>
    /// <param name="Read">Read.</param>
    public UserRecording(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ContentUri = null, DomainEntityRef Workspace = null, DomainEntityRef CreatedBy = null, Conversation Conversation = null, long? ContentLength = null, long? DurationMilliseconds = null, List<DocumentThumbnail> Thumbnails = null, bool? Read = null)
    {
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.ContentUri = ContentUri;
        this.Workspace = Workspace;
        this.CreatedBy = CreatedBy;
        this.Conversation = Conversation;
        this.ContentLength = ContentLength;
        this.DurationMilliseconds = DurationMilliseconds;
        this.Thumbnails = Thumbnails;
        this.Read = Read;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets ContentUri
    /// </summary>
    [DataMember(Name = "contentUri", EmitDefaultValue = false)]
    public string ContentUri { get; set; }



    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    [DataMember(Name = "workspace", EmitDefaultValue = false)]
    public DomainEntityRef Workspace { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    [DataMember(Name = "conversation", EmitDefaultValue = false)]
    public Conversation Conversation { get; set; }



    /// <summary>
    /// Gets or Sets ContentLength
    /// </summary>
    [DataMember(Name = "contentLength", EmitDefaultValue = false)]
    public long? ContentLength { get; set; }



    /// <summary>
    /// Gets or Sets DurationMilliseconds
    /// </summary>
    [DataMember(Name = "durationMilliseconds", EmitDefaultValue = false)]
    public long? DurationMilliseconds { get; set; }



    /// <summary>
    /// Gets or Sets Thumbnails
    /// </summary>
    [DataMember(Name = "thumbnails", EmitDefaultValue = false)]
    public List<DocumentThumbnail> Thumbnails { get; set; }



    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [DataMember(Name = "read", EmitDefaultValue = false)]
    public bool? Read { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserRecording {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
        sb.Append("  DurationMilliseconds: ").Append(DurationMilliseconds).Append("\n");
        sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
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
        return Equals(obj as UserRecording);
    }

    /// <summary>
    /// Returns true if UserRecording instances are equal
    /// </summary>
    /// <param name="other">Instance of UserRecording to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserRecording other)
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
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                ContentLength == other.ContentLength ||
                ContentLength != null &&
                ContentLength.Equals(other.ContentLength)
            ) &&
            (
                DurationMilliseconds == other.DurationMilliseconds ||
                DurationMilliseconds != null &&
                DurationMilliseconds.Equals(other.DurationMilliseconds)
            ) &&
            (
                Thumbnails == other.Thumbnails ||
                Thumbnails != null &&
                Thumbnails.SequenceEqual(other.Thumbnails)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
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

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (ContentLength != null)
            {
                hash = hash * 59 + ContentLength.GetHashCode();
            }

            if (DurationMilliseconds != null)
            {
                hash = hash * 59 + DurationMilliseconds.GetHashCode();
            }

            if (Thumbnails != null)
            {
                hash = hash * 59 + Thumbnails.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
