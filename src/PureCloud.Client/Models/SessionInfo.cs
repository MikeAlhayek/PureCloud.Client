using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionInfo
/// </summary>

public partial class SessionInfo : IEquatable<SessionInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionInfo" /> class.
    /// </summary>
    /// <param name="Version">Version of the continuous forecast session.</param>
    /// <param name="SessionId">Session ID of the continuous forecast session.</param>
    /// <param name="BusinessUnitId">Business unit ID of the continuous forecast session.</param>
    /// <param name="PlanningGroupsVersion">Version of the planning groups.</param>
    /// <param name="DateOfSession">Date and Time of the Session. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public SessionInfo(int? Version = null, string SessionId = null, string BusinessUnitId = null, int? PlanningGroupsVersion = null, DateTime? DateOfSession = null)
    {
        this.Version = Version;
        this.SessionId = SessionId;
        this.BusinessUnitId = BusinessUnitId;
        this.PlanningGroupsVersion = PlanningGroupsVersion;
        this.DateOfSession = DateOfSession;

    }



    /// <summary>
    /// Version of the continuous forecast session
    /// </summary>
    /// <value>Version of the continuous forecast session</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Session ID of the continuous forecast session
    /// </summary>
    /// <value>Session ID of the continuous forecast session</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// Business unit ID of the continuous forecast session
    /// </summary>
    /// <value>Business unit ID of the continuous forecast session</value>
    [JsonPropertyName("businessUnitId")]
    public string BusinessUnitId { get; set; }



    /// <summary>
    /// Version of the planning groups
    /// </summary>
    /// <value>Version of the planning groups</value>
    [JsonPropertyName("planningGroupsVersion")]
    public int? PlanningGroupsVersion { get; set; }



    /// <summary>
    /// Date and Time of the Session. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and Time of the Session. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateOfSession")]
    public DateTime? DateOfSession { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionInfo {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
        sb.Append("  DateOfSession: ").Append(DateOfSession).Append("\n");
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
        return Equals(obj as SessionInfo);
    }

    /// <summary>
    /// Returns true if SessionInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                BusinessUnitId == other.BusinessUnitId ||
                BusinessUnitId != null &&
                BusinessUnitId.Equals(other.BusinessUnitId)
            ) &&
            (
                PlanningGroupsVersion == other.PlanningGroupsVersion ||
                PlanningGroupsVersion != null &&
                PlanningGroupsVersion.Equals(other.PlanningGroupsVersion)
            ) &&
            (
                DateOfSession == other.DateOfSession ||
                DateOfSession != null &&
                DateOfSession.Equals(other.DateOfSession)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (BusinessUnitId != null)
            {
                hash = hash * 59 + BusinessUnitId.GetHashCode();
            }

            if (PlanningGroupsVersion != null)
            {
                hash = hash * 59 + PlanningGroupsVersion.GetHashCode();
            }

            if (DateOfSession != null)
            {
                hash = hash * 59 + DateOfSession.GetHashCode();
            }

            return hash;
        }
    }
}
