using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SnapshotInfo
/// </summary>
[DataContract]
public partial class SnapshotInfo : IEquatable<SnapshotInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapshotInfo" /> class.
    /// </summary>
    /// <param name="Version">Version of the snapshot.</param>
    /// <param name="SnapshotId">Snapshot Id of the continuous forecast session.</param>
    /// <param name="SessionId">Session Id of the continuous forecast session.</param>
    /// <param name="BusinessUnitId">Business unit ID of the continuous forecast session.</param>
    /// <param name="PlanningGroupsVersion">Version of the planning groups.</param>
    public SnapshotInfo(int? Version = null, string SnapshotId = null, string SessionId = null, string BusinessUnitId = null, int? PlanningGroupsVersion = null)
    {
        this.Version = Version;
        this.SnapshotId = SnapshotId;
        this.SessionId = SessionId;
        this.BusinessUnitId = BusinessUnitId;
        this.PlanningGroupsVersion = PlanningGroupsVersion;

    }



    /// <summary>
    /// Version of the snapshot
    /// </summary>
    /// <value>Version of the snapshot</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Snapshot Id of the continuous forecast session
    /// </summary>
    /// <value>Snapshot Id of the continuous forecast session</value>
    [DataMember(Name = "snapshotId", EmitDefaultValue = false)]
    public string SnapshotId { get; set; }



    /// <summary>
    /// Session Id of the continuous forecast session
    /// </summary>
    /// <value>Session Id of the continuous forecast session</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Business unit ID of the continuous forecast session
    /// </summary>
    /// <value>Business unit ID of the continuous forecast session</value>
    [DataMember(Name = "businessUnitId", EmitDefaultValue = false)]
    public string BusinessUnitId { get; set; }



    /// <summary>
    /// Version of the planning groups
    /// </summary>
    /// <value>Version of the planning groups</value>
    [DataMember(Name = "planningGroupsVersion", EmitDefaultValue = false)]
    public int? PlanningGroupsVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SnapshotInfo {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  SnapshotId: ").Append(SnapshotId).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
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
        return Equals(obj as SnapshotInfo);
    }

    /// <summary>
    /// Returns true if SnapshotInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of SnapshotInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SnapshotInfo other)
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
                SnapshotId == other.SnapshotId ||
                SnapshotId != null &&
                SnapshotId.Equals(other.SnapshotId)
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

            if (SnapshotId != null)
            {
                hash = hash * 59 + SnapshotId.GetHashCode();
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

            return hash;
        }
    }
}
