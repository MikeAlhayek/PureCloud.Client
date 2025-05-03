using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GamificationStatus
/// </summary>

public partial class GamificationStatus : IEquatable<GamificationStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GamificationStatus" /> class.
    /// </summary>
    /// <param name="IsActive">Gamification status of the organization..</param>
    /// <param name="DateStart">Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="AutomaticUserAssignment">Automatic assignment of users to the default profile.</param>
    /// <param name="DateStartPersonalBest">Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    public GamificationStatus(bool? IsActive = null, string DateStart = null, bool? AutomaticUserAssignment = null, string DateStartPersonalBest = null)
    {
        this.IsActive = IsActive;
        this.DateStart = DateStart;
        this.AutomaticUserAssignment = AutomaticUserAssignment;
        this.DateStartPersonalBest = DateStartPersonalBest;

    }



    /// <summary>
    /// Gamification status of the organization.
    /// </summary>
    /// <value>Gamification status of the organization.</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Gamification start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStart")]
    public string DateStart { get; set; }



    /// <summary>
    /// Automatic assignment of users to the default profile
    /// </summary>
    /// <value>Automatic assignment of users to the default profile</value>
    [JsonPropertyName("automaticUserAssignment")]
    public bool? AutomaticUserAssignment { get; set; }



    /// <summary>
    /// Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Personal best aggregation starting date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartPersonalBest")]
    public string DateStartPersonalBest { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GamificationStatus {\n");

        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  AutomaticUserAssignment: ").Append(AutomaticUserAssignment).Append("\n");
        sb.Append("  DateStartPersonalBest: ").Append(DateStartPersonalBest).Append("\n");
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
        return Equals(obj as GamificationStatus);
    }

    /// <summary>
    /// Returns true if GamificationStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of GamificationStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GamificationStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                AutomaticUserAssignment == other.AutomaticUserAssignment ||
                AutomaticUserAssignment != null &&
                AutomaticUserAssignment.Equals(other.AutomaticUserAssignment)
            ) &&
            (
                DateStartPersonalBest == other.DateStartPersonalBest ||
                DateStartPersonalBest != null &&
                DateStartPersonalBest.Equals(other.DateStartPersonalBest)
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
            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (AutomaticUserAssignment != null)
            {
                hash = hash * 59 + AutomaticUserAssignment.GetHashCode();
            }

            if (DateStartPersonalBest != null)
            {
                hash = hash * 59 + DateStartPersonalBest.GetHashCode();
            }

            return hash;
        }
    }
}
