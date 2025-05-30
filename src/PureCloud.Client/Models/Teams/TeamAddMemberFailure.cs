using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TeamAddMemberFailure
/// </summary>

public partial class TeamAddMemberFailure : IEquatable<TeamAddMemberFailure>
{
    /// <summary>
    /// Specific reason the member could not be added.
    /// </summary>
    /// <value>Specific reason the member could not be added.</value>
    
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Usernotfound for "UserNotFound"
        /// </summary>
        [EnumMember(Value = "UserNotFound")]
        Usernotfound,

        /// <summary>
        /// Enum Usergrouplimitexceeded for "UserGroupLimitExceeded"
        /// </summary>
        [EnumMember(Value = "UserGroupLimitExceeded")]
        Usergrouplimitexceeded,

        /// <summary>
        /// Enum Usergroupdivisionmismatch for "UserGroupDivisionMismatch"
        /// </summary>
        [EnumMember(Value = "UserGroupDivisionMismatch")]
        Usergroupdivisionmismatch
    }
    /// <summary>
    /// Specific reason the member could not be added.
    /// </summary>
    /// <value>Specific reason the member could not be added.</value>
    [JsonPropertyName("reason")]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamAddMemberFailure" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    public TeamAddMemberFailure(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamAddMemberFailure {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
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
        return Equals(obj as TeamAddMemberFailure);
    }

    /// <summary>
    /// Returns true if TeamAddMemberFailure instances are equal
    /// </summary>
    /// <param name="other">Instance of TeamAddMemberFailure to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamAddMemberFailure other)
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
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
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

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            return hash;
        }
    }
}
