using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsRelationshipChangedTopicRelationship
/// </summary>

public partial class ExternalContactsRelationshipChangedTopicRelationship : IEquatable<ExternalContactsRelationshipChangedTopicRelationship>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsRelationshipChangedTopicRelationship" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Division">Division.</param>
    /// <param name="User">User.</param>
    /// <param name="ExternalOrganization">ExternalOrganization.</param>
    /// <param name="Relationship">Relationship.</param>
    /// <param name="CreateDate">CreateDate.</param>
    /// <param name="ModifyDate">ModifyDate.</param>
    public ExternalContactsRelationshipChangedTopicRelationship(string Id = null, ExternalContactsRelationshipChangedTopicDivision Division = null, ExternalContactsRelationshipChangedTopicUser User = null, ExternalContactsRelationshipChangedTopicExternalOrganization ExternalOrganization = null, string Relationship = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
    {
        this.Id = Id;
        this.Division = Division;
        this.User = User;
        this.ExternalOrganization = ExternalOrganization;
        this.Relationship = Relationship;
        this.CreateDate = CreateDate;
        this.ModifyDate = ModifyDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [JsonPropertyName("division")]
    public ExternalContactsRelationshipChangedTopicDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public ExternalContactsRelationshipChangedTopicUser User { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    [JsonPropertyName("externalOrganization")]
    public ExternalContactsRelationshipChangedTopicExternalOrganization ExternalOrganization { get; set; }



    /// <summary>
    /// Gets or Sets Relationship
    /// </summary>
    [JsonPropertyName("relationship")]
    public string Relationship { get; set; }



    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    [JsonPropertyName("modifyDate")]
    public DateTime? ModifyDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsRelationshipChangedTopicRelationship {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  Relationship: ").Append(Relationship).Append("\n");
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
        return Equals(obj as ExternalContactsRelationshipChangedTopicRelationship);
    }

    /// <summary>
    /// Returns true if ExternalContactsRelationshipChangedTopicRelationship instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsRelationshipChangedTopicRelationship to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsRelationshipChangedTopicRelationship other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                Relationship == other.Relationship ||
                Relationship != null &&
                Relationship.Equals(other.Relationship)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (Relationship != null)
            {
                hash = hash * 59 + Relationship.GetHashCode();
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
