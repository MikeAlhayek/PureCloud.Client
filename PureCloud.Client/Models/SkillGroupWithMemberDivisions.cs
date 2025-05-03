using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SkillGroupWithMemberDivisions
/// </summary>

public partial class SkillGroupWithMemberDivisions : IEquatable<SkillGroupWithMemberDivisions>
{
    /// <summary>
    /// Group's filling status
    /// </summary>
    /// <value>Group's filling status</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete
    }
    /// <summary>
    /// Group's filling status
    /// </summary>
    /// <value>Group's filling status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SkillGroupWithMemberDivisions" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SkillGroupWithMemberDivisions() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SkillGroupWithMemberDivisions" /> class.
    /// </summary>
    /// <param name="Name">The group name. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">Group description.</param>
    /// <param name="SkillConditions">Conditions for this group (required).</param>
    /// <param name="MemberDivisions">Member divisions for this skill group.</param>
    public SkillGroupWithMemberDivisions(string Name = null, WritableDivision Division = null, string Description = null, List<SkillGroupCondition> SkillConditions = null, List<string> MemberDivisions = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.SkillConditions = SkillConditions;
        this.MemberDivisions = MemberDivisions;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The group name.
    /// </summary>
    /// <value>The group name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// Group description
    /// </summary>
    /// <value>Group description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.
    /// </summary>
    /// <value>Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.</value>
    [JsonPropertyName("memberCount")]
    public long? MemberCount { get; private set; }



    /// <summary>
    /// Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }





    /// <summary>
    /// Conditions for this group
    /// </summary>
    /// <value>Conditions for this group</value>
    [JsonPropertyName("skillConditions")]
    public List<SkillGroupCondition> SkillConditions { get; set; }



    /// <summary>
    /// Member divisions for this skill group
    /// </summary>
    /// <value>Member divisions for this skill group</value>
    [JsonPropertyName("memberDivisions")]
    public List<string> MemberDivisions { get; set; }



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
        sb.Append("class SkillGroupWithMemberDivisions {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SkillConditions: ").Append(SkillConditions).Append("\n");
        sb.Append("  MemberDivisions: ").Append(MemberDivisions).Append("\n");
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
        return Equals(obj as SkillGroupWithMemberDivisions);
    }

    /// <summary>
    /// Returns true if SkillGroupWithMemberDivisions instances are equal
    /// </summary>
    /// <param name="other">Instance of SkillGroupWithMemberDivisions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SkillGroupWithMemberDivisions other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                MemberCount == other.MemberCount ||
                MemberCount != null &&
                MemberCount.Equals(other.MemberCount)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                SkillConditions == other.SkillConditions ||
                SkillConditions != null &&
                SkillConditions.SequenceEqual(other.SkillConditions)
            ) &&
            (
                MemberDivisions == other.MemberDivisions ||
                MemberDivisions != null &&
                MemberDivisions.SequenceEqual(other.MemberDivisions)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (MemberCount != null)
            {
                hash = hash * 59 + MemberCount.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SkillConditions != null)
            {
                hash = hash * 59 + SkillConditions.GetHashCode();
            }

            if (MemberDivisions != null)
            {
                hash = hash * 59 + MemberDivisions.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
