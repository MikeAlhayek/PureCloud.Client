using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MoveAgentsRequest
/// </summary>

public partial class MoveAgentsRequest : IEquatable<MoveAgentsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MoveAgentsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MoveAgentsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MoveAgentsRequest" /> class.
    /// </summary>
    /// <param name="UserIds">The list of user ids to move (required).</param>
    /// <param name="DestinationManagementUnitId">The id of the management unit for which the move will be performed. To remove users from their management unit this should be set to null..</param>
    public MoveAgentsRequest(List<string> UserIds = null, string DestinationManagementUnitId = null)
    {
        this.UserIds = UserIds;
        this.DestinationManagementUnitId = DestinationManagementUnitId;

    }



    /// <summary>
    /// The list of user ids to move
    /// </summary>
    /// <value>The list of user ids to move</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// The id of the management unit for which the move will be performed. To remove users from their management unit this should be set to null.
    /// </summary>
    /// <value>The id of the management unit for which the move will be performed. To remove users from their management unit this should be set to null.</value>
    [JsonPropertyName("destinationManagementUnitId")]
    public string DestinationManagementUnitId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MoveAgentsRequest {\n");

        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  DestinationManagementUnitId: ").Append(DestinationManagementUnitId).Append("\n");
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
        return Equals(obj as MoveAgentsRequest);
    }

    /// <summary>
    /// Returns true if MoveAgentsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MoveAgentsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MoveAgentsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
            ) &&
            (
                DestinationManagementUnitId == other.DestinationManagementUnitId ||
                DestinationManagementUnitId != null &&
                DestinationManagementUnitId.Equals(other.DestinationManagementUnitId)
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
            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (DestinationManagementUnitId != null)
            {
                hash = hash * 59 + DestinationManagementUnitId.GetHashCode();
            }

            return hash;
        }
    }
}
