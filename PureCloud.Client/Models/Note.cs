using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Note
/// </summary>

public partial class Note : IEquatable<Note>
{
    /// <summary>
    /// This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.
    /// </summary>
    /// <value>This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.</value>
    
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Contact for "contact"
        /// </summary>
        [EnumMember(Value = "contact")]
        Contact,

        /// <summary>
        /// Enum Organization for "organization"
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization
    }
    /// <summary>
    /// This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.
    /// </summary>
    /// <value>This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used.</value>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Note" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Note() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Note" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="EntityId">The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs..</param>
    /// <param name="EntityType">This is only need to be set when using Bulk API. Using any other value than contact or organization will result in null being used..</param>
    /// <param name="NoteText">NoteText.</param>
    /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">When creating or updating a note, only User.id is required. User object is fully populated when expanding a note. (required).</param>
    public Note(WritableStarrableDivision Division = null, string EntityId = null, EntityTypeEnum? EntityType = null, string NoteText = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, User CreatedBy = null)
    {
        this.Division = Division;
        this.EntityId = EntityId;
        this.EntityType = EntityType;
        this.NoteText = NoteText;
        this.ModifyDate = ModifyDate;
        this.CreateDate = CreateDate;
        this.CreatedBy = CreatedBy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.
    /// </summary>
    /// <value>The id of the contact or organization to which this note refers. This only needs to be set for input when using the Bulk APIs.</value>
    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }





    /// <summary>
    /// Gets or Sets NoteText
    /// </summary>
    [JsonPropertyName("noteText")]
    public string NoteText { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifyDate")]
    public DateTime? ModifyDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.
    /// </summary>
    /// <value>When creating or updating a note, only User.id is required. User object is fully populated when expanding a note.</value>
    [JsonPropertyName("createdBy")]
    public User CreatedBy { get; set; }



    /// <summary>
    /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
    [JsonPropertyName("externalDataSources")]
    public List<ExternalDataSource> ExternalDataSources { get; private set; }



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
        sb.Append("class Note {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  NoteText: ").Append(NoteText).Append("\n");
        sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
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
        return Equals(obj as Note);
    }

    /// <summary>
    /// Returns true if Note instances are equal
    /// </summary>
    /// <param name="other">Instance of Note to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Note other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                EntityId == other.EntityId ||
                EntityId != null &&
                EntityId.Equals(other.EntityId)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                NoteText == other.NoteText ||
                NoteText != null &&
                NoteText.Equals(other.NoteText)
            ) &&
            (
                ModifyDate == other.ModifyDate ||
                ModifyDate != null &&
                ModifyDate.Equals(other.ModifyDate)
            ) &&
            (
                CreateDate == other.CreateDate ||
                CreateDate != null &&
                CreateDate.Equals(other.CreateDate)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ExternalDataSources == other.ExternalDataSources ||
                ExternalDataSources != null &&
                ExternalDataSources.SequenceEqual(other.ExternalDataSources)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (NoteText != null)
            {
                hash = hash * 59 + NoteText.GetHashCode();
            }

            if (ModifyDate != null)
            {
                hash = hash * 59 + ModifyDate.GetHashCode();
            }

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ExternalDataSources != null)
            {
                hash = hash * 59 + ExternalDataSources.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
