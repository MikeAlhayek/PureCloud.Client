using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StaffingGroupResponse
/// </summary>

public partial class StaffingGroupResponse : IEquatable<StaffingGroupResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="StaffingGroupResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected StaffingGroupResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="StaffingGroupResponse" /> class.
    /// </summary>
    /// <param name="Name">The name of the staffing group (required).</param>
    /// <param name="Users">The list of users that belong to the staffing group.</param>
    /// <param name="ManagementUnit">The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit.</param>
    /// <param name="Metadata">Version metadata for the staffing group (required).</param>
    public StaffingGroupResponse(string Name = null, List<UserReference> Users = null, ManagementUnitReference ManagementUnit = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.Users = Users;
        this.ManagementUnit = ManagementUnit;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the staffing group
    /// </summary>
    /// <value>The name of the staffing group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The list of users that belong to the staffing group
    /// </summary>
    /// <value>The list of users that belong to the staffing group</value>
    [JsonPropertyName("users")]
    public List<UserReference> Users { get; set; }



    /// <summary>
    /// The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit
    /// </summary>
    /// <value>The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// Version metadata for the staffing group
    /// </summary>
    /// <value>Version metadata for the staffing group</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



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
        sb.Append("class StaffingGroupResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as StaffingGroupResponse);
    }

    /// <summary>
    /// Returns true if StaffingGroupResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of StaffingGroupResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StaffingGroupResponse other)
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
                Users == other.Users ||
                Users != null &&
                Users.SequenceEqual(other.Users)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Users != null)
            {
                hash = hash * 59 + Users.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
