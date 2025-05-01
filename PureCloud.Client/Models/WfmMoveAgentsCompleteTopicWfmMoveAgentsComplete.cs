using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete
/// </summary>
[DataContract]
public partial class WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete : IEquatable<WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete" /> class.
    /// </summary>
    /// <param name="RequestingUser">RequestingUser.</param>
    /// <param name="DestinationManagementUnit">DestinationManagementUnit.</param>
    /// <param name="Results">Results.</param>
    public WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete(WfmMoveAgentsCompleteTopicUserReference RequestingUser = null, WfmMoveAgentsCompleteTopicManagementUnit DestinationManagementUnit = null, List<WfmMoveAgentsCompleteTopicWfmMoveAgentData> Results = null)
    {
        this.RequestingUser = RequestingUser;
        this.DestinationManagementUnit = DestinationManagementUnit;
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets RequestingUser
    /// </summary>
    [DataMember(Name = "requestingUser", EmitDefaultValue = false)]
    public WfmMoveAgentsCompleteTopicUserReference RequestingUser { get; set; }



    /// <summary>
    /// Gets or Sets DestinationManagementUnit
    /// </summary>
    [DataMember(Name = "destinationManagementUnit", EmitDefaultValue = false)]
    public WfmMoveAgentsCompleteTopicManagementUnit DestinationManagementUnit { get; set; }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<WfmMoveAgentsCompleteTopicWfmMoveAgentData> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete {\n");

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
        return Equals(obj as WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete);
    }

    /// <summary>
    /// Returns true if WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete other)
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
