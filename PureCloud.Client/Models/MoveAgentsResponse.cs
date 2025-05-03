using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MoveAgentsResponse
/// </summary>

public partial class MoveAgentsResponse : IEquatable<MoveAgentsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoveAgentsResponse" /> class.
    /// </summary>
    /// <param name="RequestingUser">The user that made the request.</param>
    /// <param name="DestinationManagementUnit">The management unit specified on the request.</param>
    /// <param name="Results">The list containing the agent and result of the move operation.</param>
    public MoveAgentsResponse(UserReference RequestingUser = null, ManagementUnitReference DestinationManagementUnit = null, List<MoveAgentResponse> Results = null)
    {
        this.RequestingUser = RequestingUser;
        this.DestinationManagementUnit = DestinationManagementUnit;
        this.Results = Results;

    }



    /// <summary>
    /// The user that made the request
    /// </summary>
    /// <value>The user that made the request</value>
    [JsonPropertyName("requestingUser")]
    public UserReference RequestingUser { get; set; }



    /// <summary>
    /// The management unit specified on the request
    /// </summary>
    /// <value>The management unit specified on the request</value>
    [JsonPropertyName("destinationManagementUnit")]
    public ManagementUnitReference DestinationManagementUnit { get; set; }



    /// <summary>
    /// The list containing the agent and result of the move operation
    /// </summary>
    /// <value>The list containing the agent and result of the move operation</value>
    [JsonPropertyName("results")]
    public List<MoveAgentResponse> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MoveAgentsResponse {\n");

        sb.Append("  RequestingUser: ").Append(RequestingUser).Append("\n");
        sb.Append("  DestinationManagementUnit: ").Append(DestinationManagementUnit).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as MoveAgentsResponse);
    }

    /// <summary>
    /// Returns true if MoveAgentsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of MoveAgentsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MoveAgentsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RequestingUser == other.RequestingUser ||
                RequestingUser != null &&
                RequestingUser.Equals(other.RequestingUser)
            ) &&
            (
                DestinationManagementUnit == other.DestinationManagementUnit ||
                DestinationManagementUnit != null &&
                DestinationManagementUnit.Equals(other.DestinationManagementUnit)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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
            if (RequestingUser != null)
            {
                hash = hash * 59 + RequestingUser.GetHashCode();
            }

            if (DestinationManagementUnit != null)
            {
                hash = hash * 59 + DestinationManagementUnit.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
