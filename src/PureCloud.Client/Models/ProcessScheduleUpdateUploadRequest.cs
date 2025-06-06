using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProcessScheduleUpdateUploadRequest
/// </summary>

public partial class ProcessScheduleUpdateUploadRequest : IEquatable<ProcessScheduleUpdateUploadRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessScheduleUpdateUploadRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProcessScheduleUpdateUploadRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessScheduleUpdateUploadRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">The uploadKey provided by the request to get an upload URL (required).</param>
    /// <param name="TeamIds">The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit.</param>
    /// <param name="ManagementUnitIdsForAddedTeamUsers">The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit.</param>
    public ProcessScheduleUpdateUploadRequest(string UploadKey = null, List<string> TeamIds = null, List<string> ManagementUnitIdsForAddedTeamUsers = null)
    {
        this.UploadKey = UploadKey;
        this.TeamIds = TeamIds;
        this.ManagementUnitIdsForAddedTeamUsers = ManagementUnitIdsForAddedTeamUsers;

    }



    /// <summary>
    /// The uploadKey provided by the request to get an upload URL
    /// </summary>
    /// <value>The uploadKey provided by the request to get an upload URL</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }



    /// <summary>
    /// The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit
    /// </summary>
    /// <value>The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit</value>
    [JsonPropertyName("teamIds")]
    public List<string> TeamIds { get; set; }



    /// <summary>
    /// The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit
    /// </summary>
    /// <value>The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit</value>
    [JsonPropertyName("managementUnitIdsForAddedTeamUsers")]
    public List<string> ManagementUnitIdsForAddedTeamUsers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProcessScheduleUpdateUploadRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
        sb.Append("  ManagementUnitIdsForAddedTeamUsers: ").Append(ManagementUnitIdsForAddedTeamUsers).Append("\n");
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
        return Equals(obj as ProcessScheduleUpdateUploadRequest);
    }

    /// <summary>
    /// Returns true if ProcessScheduleUpdateUploadRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ProcessScheduleUpdateUploadRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProcessScheduleUpdateUploadRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                TeamIds == other.TeamIds ||
                TeamIds != null &&
                TeamIds.SequenceEqual(other.TeamIds)
            ) &&
            (
                ManagementUnitIdsForAddedTeamUsers == other.ManagementUnitIdsForAddedTeamUsers ||
                ManagementUnitIdsForAddedTeamUsers != null &&
                ManagementUnitIdsForAddedTeamUsers.SequenceEqual(other.ManagementUnitIdsForAddedTeamUsers)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (TeamIds != null)
            {
                hash = hash * 59 + TeamIds.GetHashCode();
            }

            if (ManagementUnitIdsForAddedTeamUsers != null)
            {
                hash = hash * 59 + ManagementUnitIdsForAddedTeamUsers.GetHashCode();
            }

            return hash;
        }
    }
}
