using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GamificationScorecardChangeTopicScorecardChange
/// </summary>
[DataContract]
public partial class GamificationScorecardChangeTopicScorecardChange : IEquatable<GamificationScorecardChangeTopicScorecardChange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicScorecardChange" /> class.
    /// </summary>
    /// <param name="Workday">Workday.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="TeamId">TeamId.</param>
    /// <param name="PerformanceProfileId">PerformanceProfileId.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="PerformanceMetrics">PerformanceMetrics.</param>
    public GamificationScorecardChangeTopicScorecardChange(string Workday = null, string DivisionId = null, string TeamId = null, string PerformanceProfileId = null, string UserId = null, List<GamificationScorecardChangeTopicPerformanceMetric> PerformanceMetrics = null)
    {
        this.Workday = Workday;
        this.DivisionId = DivisionId;
        this.TeamId = TeamId;
        this.PerformanceProfileId = PerformanceProfileId;
        this.UserId = UserId;
        this.PerformanceMetrics = PerformanceMetrics;

    }



    /// <summary>
    /// Gets or Sets Workday
    /// </summary>
    [DataMember(Name = "workday", EmitDefaultValue = false)]
    public string Workday { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets TeamId
    /// </summary>
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }



    /// <summary>
    /// Gets or Sets PerformanceProfileId
    /// </summary>
    [DataMember(Name = "performanceProfileId", EmitDefaultValue = false)]
    public string PerformanceProfileId { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets PerformanceMetrics
    /// </summary>
    [DataMember(Name = "performanceMetrics", EmitDefaultValue = false)]
    public List<GamificationScorecardChangeTopicPerformanceMetric> PerformanceMetrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GamificationScorecardChangeTopicScorecardChange {\n");

        sb.Append("  Workday: ").Append(Workday).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  PerformanceMetrics: ").Append(PerformanceMetrics).Append("\n");
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
        return Equals(obj as GamificationScorecardChangeTopicScorecardChange);
    }

    /// <summary>
    /// Returns true if GamificationScorecardChangeTopicScorecardChange instances are equal
    /// </summary>
    /// <param name="other">Instance of GamificationScorecardChangeTopicScorecardChange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GamificationScorecardChangeTopicScorecardChange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Workday == other.Workday ||
                Workday != null &&
                Workday.Equals(other.Workday)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                PerformanceProfileId == other.PerformanceProfileId ||
                PerformanceProfileId != null &&
                PerformanceProfileId.Equals(other.PerformanceProfileId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                PerformanceMetrics == other.PerformanceMetrics ||
                PerformanceMetrics != null &&
                PerformanceMetrics.SequenceEqual(other.PerformanceMetrics)
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
            if (Workday != null)
            {
                hash = hash * 59 + Workday.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (PerformanceProfileId != null)
            {
                hash = hash * 59 + PerformanceProfileId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (PerformanceMetrics != null)
            {
                hash = hash * 59 + PerformanceMetrics.GetHashCode();
            }

            return hash;
        }
    }
}
