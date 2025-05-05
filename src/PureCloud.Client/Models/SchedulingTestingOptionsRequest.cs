using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingTestingOptionsRequest
/// </summary>

public partial class SchedulingTestingOptionsRequest : IEquatable<SchedulingTestingOptionsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingTestingOptionsRequest" /> class.
    /// </summary>
    /// <param name="FastScheduling">Whether to enable fast scheduling.</param>
    /// <param name="DelayScheduling">Whether to force delayed scheduling.</param>
    /// <param name="FailScheduling">Whether to force scheduling to fail.</param>
    /// <param name="PopulateWarnings">Whether to populate warnings in the generated schedule.</param>
    /// <param name="PopulateDeprecatedWarnings">Whether to populate deprecated warnings in the generated schedule.</param>
    public SchedulingTestingOptionsRequest(bool? FastScheduling = null, bool? DelayScheduling = null, bool? FailScheduling = null, bool? PopulateWarnings = null, bool? PopulateDeprecatedWarnings = null)
    {
        this.FastScheduling = FastScheduling;
        this.DelayScheduling = DelayScheduling;
        this.FailScheduling = FailScheduling;
        this.PopulateWarnings = PopulateWarnings;
        this.PopulateDeprecatedWarnings = PopulateDeprecatedWarnings;

    }



    /// <summary>
    /// Whether to enable fast scheduling
    /// </summary>
    /// <value>Whether to enable fast scheduling</value>
    [JsonPropertyName("fastScheduling")]
    public bool? FastScheduling { get; set; }



    /// <summary>
    /// Whether to force delayed scheduling
    /// </summary>
    /// <value>Whether to force delayed scheduling</value>
    [JsonPropertyName("delayScheduling")]
    public bool? DelayScheduling { get; set; }



    /// <summary>
    /// Whether to force scheduling to fail
    /// </summary>
    /// <value>Whether to force scheduling to fail</value>
    [JsonPropertyName("failScheduling")]
    public bool? FailScheduling { get; set; }



    /// <summary>
    /// Whether to populate warnings in the generated schedule
    /// </summary>
    /// <value>Whether to populate warnings in the generated schedule</value>
    [JsonPropertyName("populateWarnings")]
    public bool? PopulateWarnings { get; set; }



    /// <summary>
    /// Whether to populate deprecated warnings in the generated schedule
    /// </summary>
    /// <value>Whether to populate deprecated warnings in the generated schedule</value>
    [JsonPropertyName("populateDeprecatedWarnings")]
    public bool? PopulateDeprecatedWarnings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingTestingOptionsRequest {\n");

        sb.Append("  FastScheduling: ").Append(FastScheduling).Append("\n");
        sb.Append("  DelayScheduling: ").Append(DelayScheduling).Append("\n");
        sb.Append("  FailScheduling: ").Append(FailScheduling).Append("\n");
        sb.Append("  PopulateWarnings: ").Append(PopulateWarnings).Append("\n");
        sb.Append("  PopulateDeprecatedWarnings: ").Append(PopulateDeprecatedWarnings).Append("\n");
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
        return Equals(obj as SchedulingTestingOptionsRequest);
    }

    /// <summary>
    /// Returns true if SchedulingTestingOptionsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingTestingOptionsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingTestingOptionsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FastScheduling == other.FastScheduling ||
                FastScheduling != null &&
                FastScheduling.Equals(other.FastScheduling)
            ) &&
            (
                DelayScheduling == other.DelayScheduling ||
                DelayScheduling != null &&
                DelayScheduling.Equals(other.DelayScheduling)
            ) &&
            (
                FailScheduling == other.FailScheduling ||
                FailScheduling != null &&
                FailScheduling.Equals(other.FailScheduling)
            ) &&
            (
                PopulateWarnings == other.PopulateWarnings ||
                PopulateWarnings != null &&
                PopulateWarnings.Equals(other.PopulateWarnings)
            ) &&
            (
                PopulateDeprecatedWarnings == other.PopulateDeprecatedWarnings ||
                PopulateDeprecatedWarnings != null &&
                PopulateDeprecatedWarnings.Equals(other.PopulateDeprecatedWarnings)
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
            if (FastScheduling != null)
            {
                hash = hash * 59 + FastScheduling.GetHashCode();
            }

            if (DelayScheduling != null)
            {
                hash = hash * 59 + DelayScheduling.GetHashCode();
            }

            if (FailScheduling != null)
            {
                hash = hash * 59 + FailScheduling.GetHashCode();
            }

            if (PopulateWarnings != null)
            {
                hash = hash * 59 + PopulateWarnings.GetHashCode();
            }

            if (PopulateDeprecatedWarnings != null)
            {
                hash = hash * 59 + PopulateDeprecatedWarnings.GetHashCode();
            }

            return hash;
        }
    }
}
