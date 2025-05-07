using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Celebration
/// </summary>

public partial class Celebration : IEquatable<Celebration>
{
    /// <summary>
    /// The Celebration Type
    /// </summary>
    /// <value>The Celebration Type</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Recognition for "Recognition"
        /// </summary>
        [EnumMember(Value = "Recognition")]
        Recognition,

        /// <summary>
        /// Enum Contestcomplete for "ContestComplete"
        /// </summary>
        [EnumMember(Value = "ContestComplete")]
        Contestcomplete
    }
    /// <summary>
    /// The Celebration Type
    /// </summary>
    /// <value>The Celebration Type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Celebration" /> class.
    /// </summary>
    /// <param name="Recipient">The Recipient of the celebration.</param>
    /// <param name="CreatedBy">The creator of the celebration.</param>
    /// <param name="DateCreated">The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Type">The Celebration Type.</param>
    /// <param name="Title">The Celebration title.</param>
    /// <param name="Note">The Celebration note.</param>
    /// <param name="SourceEntity">The celebration&#39;s source entity.</param>
    public Celebration(UserReference Recipient = null, UserReference CreatedBy = null, DateTime? DateCreated = null, TypeEnum? Type = null, string Title = null, string Note = null, SourceEntity SourceEntity = null)
    {
        this.Recipient = Recipient;
        this.CreatedBy = CreatedBy;
        this.DateCreated = DateCreated;
        this.Type = Type;
        this.Title = Title;
        this.Note = Note;
        this.SourceEntity = SourceEntity;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The Recipient of the celebration
    /// </summary>
    /// <value>The Recipient of the celebration</value>
    [JsonPropertyName("recipient")]
    public UserReference Recipient { get; set; }



    /// <summary>
    /// The creator of the celebration
    /// </summary>
    /// <value>The creator of the celebration</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// The Celebration title
    /// </summary>
    /// <value>The Celebration title</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The Celebration note
    /// </summary>
    /// <value>The Celebration note</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }



    /// <summary>
    /// The celebration&#39;s source entity
    /// </summary>
    /// <value>The celebration&#39;s source entity</value>
    [JsonPropertyName("sourceEntity")]
    public SourceEntity SourceEntity { get; set; }



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
        sb.Append("class Celebration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Recipient: ").Append(Recipient).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  SourceEntity: ").Append(SourceEntity).Append("\n");
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
        return Equals(obj as Celebration);
    }

    /// <summary>
    /// Returns true if Celebration instances are equal
    /// </summary>
    /// <param name="other">Instance of Celebration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Celebration other)
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
                Recipient == other.Recipient ||
                Recipient != null &&
                Recipient.Equals(other.Recipient)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
            ) &&
            (
                SourceEntity == other.SourceEntity ||
                SourceEntity != null &&
                SourceEntity.Equals(other.SourceEntity)
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

            if (Recipient != null)
            {
                hash = hash * 59 + Recipient.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (SourceEntity != null)
            {
                hash = hash * 59 + SourceEntity.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
