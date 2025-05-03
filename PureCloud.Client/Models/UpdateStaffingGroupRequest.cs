using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateStaffingGroupRequest
/// </summary>

public partial class UpdateStaffingGroupRequest : IEquatable<UpdateStaffingGroupRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateStaffingGroupRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateStaffingGroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateStaffingGroupRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the staffing group.</param>
    /// <param name="UserIds">The set of user Ids to associate with the staffing group.</param>
    /// <param name="Metadata">Version metadata for the staffing group (required).</param>
    public UpdateStaffingGroupRequest(string Name = null, SetWrapperString UserIds = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.UserIds = UserIds;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The name of the staffing group
    /// </summary>
    /// <value>The name of the staffing group</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The set of user Ids to associate with the staffing group
    /// </summary>
    /// <value>The set of user Ids to associate with the staffing group</value>
    [JsonPropertyName("userIds")]
    public SetWrapperString UserIds { get; set; }



    /// <summary>
    /// Version metadata for the staffing group
    /// </summary>
    /// <value>Version metadata for the staffing group</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateStaffingGroupRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as UpdateStaffingGroupRequest);
    }

    /// <summary>
    /// Returns true if UpdateStaffingGroupRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateStaffingGroupRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateStaffingGroupRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.Equals(other.UserIds)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
