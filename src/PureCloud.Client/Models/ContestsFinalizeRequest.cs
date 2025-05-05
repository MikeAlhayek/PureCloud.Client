using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestsFinalizeRequest
/// </summary>

public partial class ContestsFinalizeRequest : IEquatable<ContestsFinalizeRequest>
{
    /// <summary>
    /// The Contest finalization status
    /// </summary>
    /// <value>The Contest finalization status</value>
    
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
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
    /// <summary>
    /// The Contest finalization status
    /// </summary>
    /// <value>The Contest finalization status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsFinalizeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestsFinalizeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsFinalizeRequest" /> class.
    /// </summary>
    /// <param name="Status">The Contest finalization status (required).</param>
    /// <param name="Winners">The Contest finalization winners.</param>
    /// <param name="DisqualifiedAgents">The Contest finalization disqualified agents.</param>
    public ContestsFinalizeRequest(StatusEnum? Status = null, List<ContestWinnersRequest> Winners = null, List<ContestDisqualifiedAgents> DisqualifiedAgents = null)
    {
        this.Status = Status;
        this.Winners = Winners;
        this.DisqualifiedAgents = DisqualifiedAgents;

    }





    /// <summary>
    /// The Contest finalization winners
    /// </summary>
    /// <value>The Contest finalization winners</value>
    [JsonPropertyName("winners")]
    public List<ContestWinnersRequest> Winners { get; set; }



    /// <summary>
    /// The Contest finalization disqualified agents
    /// </summary>
    /// <value>The Contest finalization disqualified agents</value>
    [JsonPropertyName("disqualifiedAgents")]
    public List<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestsFinalizeRequest {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Winners: ").Append(Winners).Append("\n");
        sb.Append("  DisqualifiedAgents: ").Append(DisqualifiedAgents).Append("\n");
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
        return Equals(obj as ContestsFinalizeRequest);
    }

    /// <summary>
    /// Returns true if ContestsFinalizeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestsFinalizeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestsFinalizeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Winners == other.Winners ||
                Winners != null &&
                Winners.SequenceEqual(other.Winners)
            ) &&
            (
                DisqualifiedAgents == other.DisqualifiedAgents ||
                DisqualifiedAgents != null &&
                DisqualifiedAgents.SequenceEqual(other.DisqualifiedAgents)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Winners != null)
            {
                hash = hash * 59 + Winners.GetHashCode();
            }

            if (DisqualifiedAgents != null)
            {
                hash = hash * 59 + DisqualifiedAgents.GetHashCode();
            }

            return hash;
        }
    }
}
