using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PlanningPeriodShiftConstraints
/// </summary>

public partial class PlanningPeriodShiftConstraints : IEquatable<PlanningPeriodShiftConstraints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningPeriodShiftConstraints" /> class.
    /// </summary>
    /// <param name="Enabled">Whether shifts per planning period is enabled. This field is non-nullable on the response.</param>
    /// <param name="MinimumCount">The minimum number of shifts required per planning period. This field is non-nullable on the response.</param>
    /// <param name="MaximumCount">The maximum number of shifts allowed per planning period. This field is non-nullable on the response.</param>
    public PlanningPeriodShiftConstraints(bool? Enabled = null, int? MinimumCount = null, int? MaximumCount = null)
    {
        this.Enabled = Enabled;
        this.MinimumCount = MinimumCount;
        this.MaximumCount = MaximumCount;

    }



    /// <summary>
    /// Whether shifts per planning period is enabled. This field is non-nullable on the response
    /// </summary>
    /// <value>Whether shifts per planning period is enabled. This field is non-nullable on the response</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The minimum number of shifts required per planning period. This field is non-nullable on the response
    /// </summary>
    /// <value>The minimum number of shifts required per planning period. This field is non-nullable on the response</value>
    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }



    /// <summary>
    /// The maximum number of shifts allowed per planning period. This field is non-nullable on the response
    /// </summary>
    /// <value>The maximum number of shifts allowed per planning period. This field is non-nullable on the response</value>
    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PlanningPeriodShiftConstraints {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MinimumCount: ").Append(MinimumCount).Append("\n");
        sb.Append("  MaximumCount: ").Append(MaximumCount).Append("\n");
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
        return Equals(obj as PlanningPeriodShiftConstraints);
    }

    /// <summary>
    /// Returns true if PlanningPeriodShiftConstraints instances are equal
    /// </summary>
    /// <param name="other">Instance of PlanningPeriodShiftConstraints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PlanningPeriodShiftConstraints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                MinimumCount == other.MinimumCount ||
                MinimumCount != null &&
                MinimumCount.Equals(other.MinimumCount)
            ) &&
            (
                MaximumCount == other.MaximumCount ||
                MaximumCount != null &&
                MaximumCount.Equals(other.MaximumCount)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MinimumCount != null)
            {
                hash = hash * 59 + MinimumCount.GetHashCode();
            }

            if (MaximumCount != null)
            {
                hash = hash * 59 + MaximumCount.GetHashCode();
            }

            return hash;
        }
    }
}
