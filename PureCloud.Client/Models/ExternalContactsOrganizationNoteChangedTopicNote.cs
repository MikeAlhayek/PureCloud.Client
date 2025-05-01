using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsOrganizationNoteChangedTopicNote
/// </summary>
[DataContract]
public partial class ExternalContactsOrganizationNoteChangedTopicNote : IEquatable<ExternalContactsOrganizationNoteChangedTopicNote>
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Contact for "Contact"
        /// </summary>
        [EnumMember(Value = "Contact")]
        Contact,

        /// <summary>
        /// Enum Organization for "Organization"
        /// </summary>
        [EnumMember(Value = "Organization")]
        Organization
    }
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsOrganizationNoteChangedTopicNote" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Division">Division.</param>
    /// <param name="EntityId">EntityId.</param>
    /// <param name="EntityType">EntityType.</param>
    /// <param name="NoteText">NoteText.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="CreateDate">CreateDate.</param>
    /// <param name="ModifyDate">ModifyDate.</param>
    public ExternalContactsOrganizationNoteChangedTopicNote(string Id = null, ExternalContactsOrganizationNoteChangedTopicDivision Division = null, string EntityId = null, EntityTypeEnum? EntityType = null, string NoteText = null, ExternalContactsOrganizationNoteChangedTopicUser CreatedBy = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
    {
        this.Id = Id;
        this.Division = Division;
        this.EntityId = EntityId;
        this.EntityType = EntityType;
        this.NoteText = NoteText;
        this.CreatedBy = CreatedBy;
        this.CreateDate = CreateDate;
        this.ModifyDate = ModifyDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public ExternalContactsOrganizationNoteChangedTopicDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [DataMember(Name = "entityId", EmitDefaultValue = false)]
    public string EntityId { get; set; }





    /// <summary>
    /// Gets or Sets NoteText
    /// </summary>
    [DataMember(Name = "noteText", EmitDefaultValue = false)]
    public string NoteText { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public ExternalContactsOrganizationNoteChangedTopicUser CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    [DataMember(Name = "createDate", EmitDefaultValue = false)]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    [DataMember(Name = "modifyDate", EmitDefaultValue = false)]
    public DateTime? ModifyDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsOrganizationNoteChangedTopicNote {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  NoteText: ").Append(NoteText).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
        return Equals(obj as ExternalContactsOrganizationNoteChangedTopicNote);
    }

    /// <summary>
    /// Returns true if ExternalContactsOrganizationNoteChangedTopicNote instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsOrganizationNoteChangedTopicNote to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsOrganizationNoteChangedTopicNote other)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                CreateDate == other.CreateDate ||
                CreateDate != null &&
                CreateDate.Equals(other.CreateDate)
            ) &&
            (
                ModifyDate == other.ModifyDate ||
                ModifyDate != null &&
                ModifyDate.Equals(other.ModifyDate)
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

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (ModifyDate != null)
            {
                hash = hash * 59 + ModifyDate.GetHashCode();
            }

            return hash;
        }
    }
}
