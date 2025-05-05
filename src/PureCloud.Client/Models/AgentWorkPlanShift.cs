using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlanShift
/// </summary>

public partial class AgentWorkPlanShift : IEquatable<AgentWorkPlanShift>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanShift" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanShift() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanShift" /> class.
    /// </summary>
    /// <param name="Days">Days of the week applicable for this shift (required).</param>
    /// <param name="FlexibleStartTime">Whether the start time of the shift is flexible (required).</param>
    /// <param name="ExactStartTimeMinutesFromMidnight">Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false (required).</param>
    /// <param name="EarliestStartTimeMinutesFromMidnight">Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true (required).</param>
    /// <param name="LatestStartTimeMinutesFromMidnight">Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true (required).</param>
    /// <param name="EarliestStopTimeMinutesFromMidnight">This is the earliest time a shift can end (required).</param>
    /// <param name="ConstrainLatestStopTime">Whether the latest stop time constraint for the shift is enabled (required).</param>
    /// <param name="LatestStopTimeMinutesFromMidnight">Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true (required).</param>
    /// <param name="FlexiblePaidTime">Whether the paid time setting for the shift is flexible (required).</param>
    /// <param name="ExactPaidTimeMinutes">Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false (required).</param>
    /// <param name="MinimumPaidTimeMinutes">Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true (required).</param>
    /// <param name="MaximumPaidTimeMinutes">Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true (required).</param>
    /// <param name="Activities">Activities configured for this shift (required).</param>
    public AgentWorkPlanShift(SetWrapperDayOfWeek Days = null, bool? FlexibleStartTime = null, int? ExactStartTimeMinutesFromMidnight = null, int? EarliestStartTimeMinutesFromMidnight = null, int? LatestStartTimeMinutesFromMidnight = null, int? EarliestStopTimeMinutesFromMidnight = null, bool? ConstrainLatestStopTime = null, int? LatestStopTimeMinutesFromMidnight = null, bool? FlexiblePaidTime = null, int? ExactPaidTimeMinutes = null, int? MinimumPaidTimeMinutes = null, int? MaximumPaidTimeMinutes = null, List<AgentWorkPlanActivity> Activities = null)
    {
        this.Days = Days;
        this.FlexibleStartTime = FlexibleStartTime;
        this.ExactStartTimeMinutesFromMidnight = ExactStartTimeMinutesFromMidnight;
        this.EarliestStartTimeMinutesFromMidnight = EarliestStartTimeMinutesFromMidnight;
        this.LatestStartTimeMinutesFromMidnight = LatestStartTimeMinutesFromMidnight;
        this.EarliestStopTimeMinutesFromMidnight = EarliestStopTimeMinutesFromMidnight;
        this.ConstrainLatestStopTime = ConstrainLatestStopTime;
        this.LatestStopTimeMinutesFromMidnight = LatestStopTimeMinutesFromMidnight;
        this.FlexiblePaidTime = FlexiblePaidTime;
        this.ExactPaidTimeMinutes = ExactPaidTimeMinutes;
        this.MinimumPaidTimeMinutes = MinimumPaidTimeMinutes;
        this.MaximumPaidTimeMinutes = MaximumPaidTimeMinutes;
        this.Activities = Activities;

    }



    /// <summary>
    /// Days of the week applicable for this shift
    /// </summary>
    /// <value>Days of the week applicable for this shift</value>
    [JsonPropertyName("days")]
    public SetWrapperDayOfWeek Days { get; set; }



    /// <summary>
    /// Whether the start time of the shift is flexible
    /// </summary>
    /// <value>Whether the start time of the shift is flexible</value>
    [JsonPropertyName("flexibleStartTime")]
    public bool? FlexibleStartTime { get; set; }



    /// <summary>
    /// Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; false</value>
    [JsonPropertyName("exactStartTimeMinutesFromMidnight")]
    public int? ExactStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Earliest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("earliestStartTimeMinutesFromMidnight")]
    public int? EarliestStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Latest start time of the shift defined as offset minutes from midnight. Used if flexibleStartTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("latestStartTimeMinutesFromMidnight")]
    public int? LatestStartTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// This is the earliest time a shift can end
    /// </summary>
    /// <value>This is the earliest time a shift can end</value>
    [JsonPropertyName("earliestStopTimeMinutesFromMidnight")]
    public int? EarliestStopTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Whether the latest stop time constraint for the shift is enabled
    /// </summary>
    /// <value>Whether the latest stop time constraint for the shift is enabled</value>
    [JsonPropertyName("constrainLatestStopTime")]
    public bool? ConstrainLatestStopTime { get; set; }



    /// <summary>
    /// Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Latest stop time of the shift defined as offset minutes from midnight. Used if constrainStopTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("latestStopTimeMinutesFromMidnight")]
    public int? LatestStopTimeMinutesFromMidnight { get; set; }



    /// <summary>
    /// Whether the paid time setting for the shift is flexible
    /// </summary>
    /// <value>Whether the paid time setting for the shift is flexible</value>
    [JsonPropertyName("flexiblePaidTime")]
    public bool? FlexiblePaidTime { get; set; }



    /// <summary>
    /// Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; false</value>
    [JsonPropertyName("exactPaidTimeMinutes")]
    public int? ExactPaidTimeMinutes { get; set; }



    /// <summary>
    /// Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("minimumPaidTimeMinutes")]
    public int? MinimumPaidTimeMinutes { get; set; }



    /// <summary>
    /// Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Maximum paid time in minutes configured for the shift. Used if flexiblePaidTime &#x3D;&#x3D; true</value>
    [JsonPropertyName("maximumPaidTimeMinutes")]
    public int? MaximumPaidTimeMinutes { get; set; }



    /// <summary>
    /// Activities configured for this shift
    /// </summary>
    /// <value>Activities configured for this shift</value>
    [JsonPropertyName("activities")]
    public List<AgentWorkPlanActivity> Activities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlanShift {\n");

        sb.Append("  Days: ").Append(Days).Append("\n");
        sb.Append("  FlexibleStartTime: ").Append(FlexibleStartTime).Append("\n");
        sb.Append("  ExactStartTimeMinutesFromMidnight: ").Append(ExactStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  EarliestStartTimeMinutesFromMidnight: ").Append(EarliestStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  LatestStartTimeMinutesFromMidnight: ").Append(LatestStartTimeMinutesFromMidnight).Append("\n");
        sb.Append("  EarliestStopTimeMinutesFromMidnight: ").Append(EarliestStopTimeMinutesFromMidnight).Append("\n");
        sb.Append("  ConstrainLatestStopTime: ").Append(ConstrainLatestStopTime).Append("\n");
        sb.Append("  LatestStopTimeMinutesFromMidnight: ").Append(LatestStopTimeMinutesFromMidnight).Append("\n");
        sb.Append("  FlexiblePaidTime: ").Append(FlexiblePaidTime).Append("\n");
        sb.Append("  ExactPaidTimeMinutes: ").Append(ExactPaidTimeMinutes).Append("\n");
        sb.Append("  MinimumPaidTimeMinutes: ").Append(MinimumPaidTimeMinutes).Append("\n");
        sb.Append("  MaximumPaidTimeMinutes: ").Append(MaximumPaidTimeMinutes).Append("\n");
        sb.Append("  Activities: ").Append(Activities).Append("\n");
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
        return Equals(obj as AgentWorkPlanShift);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanShift instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanShift to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanShift other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Days == other.Days ||
                Days != null &&
                Days.Equals(other.Days)
            ) &&
            (
                FlexibleStartTime == other.FlexibleStartTime ||
                FlexibleStartTime != null &&
                FlexibleStartTime.Equals(other.FlexibleStartTime)
            ) &&
            (
                ExactStartTimeMinutesFromMidnight == other.ExactStartTimeMinutesFromMidnight ||
                ExactStartTimeMinutesFromMidnight != null &&
                ExactStartTimeMinutesFromMidnight.Equals(other.ExactStartTimeMinutesFromMidnight)
            ) &&
            (
                EarliestStartTimeMinutesFromMidnight == other.EarliestStartTimeMinutesFromMidnight ||
                EarliestStartTimeMinutesFromMidnight != null &&
                EarliestStartTimeMinutesFromMidnight.Equals(other.EarliestStartTimeMinutesFromMidnight)
            ) &&
            (
                LatestStartTimeMinutesFromMidnight == other.LatestStartTimeMinutesFromMidnight ||
                LatestStartTimeMinutesFromMidnight != null &&
                LatestStartTimeMinutesFromMidnight.Equals(other.LatestStartTimeMinutesFromMidnight)
            ) &&
            (
                EarliestStopTimeMinutesFromMidnight == other.EarliestStopTimeMinutesFromMidnight ||
                EarliestStopTimeMinutesFromMidnight != null &&
                EarliestStopTimeMinutesFromMidnight.Equals(other.EarliestStopTimeMinutesFromMidnight)
            ) &&
            (
                ConstrainLatestStopTime == other.ConstrainLatestStopTime ||
                ConstrainLatestStopTime != null &&
                ConstrainLatestStopTime.Equals(other.ConstrainLatestStopTime)
            ) &&
            (
                LatestStopTimeMinutesFromMidnight == other.LatestStopTimeMinutesFromMidnight ||
                LatestStopTimeMinutesFromMidnight != null &&
                LatestStopTimeMinutesFromMidnight.Equals(other.LatestStopTimeMinutesFromMidnight)
            ) &&
            (
                FlexiblePaidTime == other.FlexiblePaidTime ||
                FlexiblePaidTime != null &&
                FlexiblePaidTime.Equals(other.FlexiblePaidTime)
            ) &&
            (
                ExactPaidTimeMinutes == other.ExactPaidTimeMinutes ||
                ExactPaidTimeMinutes != null &&
                ExactPaidTimeMinutes.Equals(other.ExactPaidTimeMinutes)
            ) &&
            (
                MinimumPaidTimeMinutes == other.MinimumPaidTimeMinutes ||
                MinimumPaidTimeMinutes != null &&
                MinimumPaidTimeMinutes.Equals(other.MinimumPaidTimeMinutes)
            ) &&
            (
                MaximumPaidTimeMinutes == other.MaximumPaidTimeMinutes ||
                MaximumPaidTimeMinutes != null &&
                MaximumPaidTimeMinutes.Equals(other.MaximumPaidTimeMinutes)
            ) &&
            (
                Activities == other.Activities ||
                Activities != null &&
                Activities.SequenceEqual(other.Activities)
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
            if (Days != null)
            {
                hash = hash * 59 + Days.GetHashCode();
            }

            if (FlexibleStartTime != null)
            {
                hash = hash * 59 + FlexibleStartTime.GetHashCode();
            }

            if (ExactStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + ExactStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (EarliestStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + EarliestStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (LatestStartTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + LatestStartTimeMinutesFromMidnight.GetHashCode();
            }

            if (EarliestStopTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + EarliestStopTimeMinutesFromMidnight.GetHashCode();
            }

            if (ConstrainLatestStopTime != null)
            {
                hash = hash * 59 + ConstrainLatestStopTime.GetHashCode();
            }

            if (LatestStopTimeMinutesFromMidnight != null)
            {
                hash = hash * 59 + LatestStopTimeMinutesFromMidnight.GetHashCode();
            }

            if (FlexiblePaidTime != null)
            {
                hash = hash * 59 + FlexiblePaidTime.GetHashCode();
            }

            if (ExactPaidTimeMinutes != null)
            {
                hash = hash * 59 + ExactPaidTimeMinutes.GetHashCode();
            }

            if (MinimumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MinimumPaidTimeMinutes.GetHashCode();
            }

            if (MaximumPaidTimeMinutes != null)
            {
                hash = hash * 59 + MaximumPaidTimeMinutes.GetHashCode();
            }

            if (Activities != null)
            {
                hash = hash * 59 + Activities.GetHashCode();
            }

            return hash;
        }
    }
}
