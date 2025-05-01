using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlan
/// </summary>
[DataContract]
public partial class AgentWorkPlan : IEquatable<AgentWorkPlan>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlan" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlan() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlan" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ConstrainWeeklyPaidTime">Whether the weekly paid time constraint is enabled for this work plan (required).</param>
    /// <param name="FlexibleWeeklyPaidTime">Whether the weekly paid time constraint is flexible for this work plan (required).</param>
    /// <param name="WeeklyExactPaidMinutes">Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false (required).</param>
    /// <param name="WeeklyMinimumPaidMinutes">Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true (required).</param>
    /// <param name="WeeklyMaximumPaidMinutes">Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true (required).</param>
    /// <param name="OptionalDays">Optional days to schedule for this work plan.</param>
    /// <param name="Shifts">Shifts in this work plan (required).</param>
    public AgentWorkPlan(string Name = null, bool? ConstrainWeeklyPaidTime = null, bool? FlexibleWeeklyPaidTime = null, int? WeeklyExactPaidMinutes = null, int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, SetWrapperDayOfWeek OptionalDays = null, List<AgentWorkPlanShift> Shifts = null)
    {
        this.Name = Name;
        this.ConstrainWeeklyPaidTime = ConstrainWeeklyPaidTime;
        this.FlexibleWeeklyPaidTime = FlexibleWeeklyPaidTime;
        this.WeeklyExactPaidMinutes = WeeklyExactPaidMinutes;
        this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
        this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
        this.OptionalDays = OptionalDays;
        this.Shifts = Shifts;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Whether the weekly paid time constraint is enabled for this work plan
    /// </summary>
    /// <value>Whether the weekly paid time constraint is enabled for this work plan</value>
    [DataMember(Name = "constrainWeeklyPaidTime", EmitDefaultValue = false)]
    public bool? ConstrainWeeklyPaidTime { get; set; }



    /// <summary>
    /// Whether the weekly paid time constraint is flexible for this work plan
    /// </summary>
    /// <value>Whether the weekly paid time constraint is flexible for this work plan</value>
    [DataMember(Name = "flexibleWeeklyPaidTime", EmitDefaultValue = false)]
    public bool? FlexibleWeeklyPaidTime { get; set; }



    /// <summary>
    /// Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false
    /// </summary>
    /// <value>Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; false</value>
    [DataMember(Name = "weeklyExactPaidMinutes", EmitDefaultValue = false)]
    public int? WeeklyExactPaidMinutes { get; set; }



    /// <summary>
    /// Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
    [DataMember(Name = "weeklyMinimumPaidMinutes", EmitDefaultValue = false)]
    public int? WeeklyMinimumPaidMinutes { get; set; }



    /// <summary>
    /// Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true
    /// </summary>
    /// <value>Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime &#x3D;&#x3D; true</value>
    [DataMember(Name = "weeklyMaximumPaidMinutes", EmitDefaultValue = false)]
    public int? WeeklyMaximumPaidMinutes { get; set; }



    /// <summary>
    /// Optional days to schedule for this work plan
    /// </summary>
    /// <value>Optional days to schedule for this work plan</value>
    [DataMember(Name = "optionalDays", EmitDefaultValue = false)]
    public SetWrapperDayOfWeek OptionalDays { get; set; }



    /// <summary>
    /// Shifts in this work plan
    /// </summary>
    /// <value>Shifts in this work plan</value>
    [DataMember(Name = "shifts", EmitDefaultValue = false)]
    public List<AgentWorkPlanShift> Shifts { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentWorkPlan {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ConstrainWeeklyPaidTime: ").Append(ConstrainWeeklyPaidTime).Append("\n");
        sb.Append("  FlexibleWeeklyPaidTime: ").Append(FlexibleWeeklyPaidTime).Append("\n");
        sb.Append("  WeeklyExactPaidMinutes: ").Append(WeeklyExactPaidMinutes).Append("\n");
        sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
        sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
        sb.Append("  OptionalDays: ").Append(OptionalDays).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as AgentWorkPlan);
    }

    /// <summary>
    /// Returns true if AgentWorkPlan instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlan to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlan other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ConstrainWeeklyPaidTime == other.ConstrainWeeklyPaidTime ||
                ConstrainWeeklyPaidTime != null &&
                ConstrainWeeklyPaidTime.Equals(other.ConstrainWeeklyPaidTime)
            ) &&
            (
                FlexibleWeeklyPaidTime == other.FlexibleWeeklyPaidTime ||
                FlexibleWeeklyPaidTime != null &&
                FlexibleWeeklyPaidTime.Equals(other.FlexibleWeeklyPaidTime)
            ) &&
            (
                WeeklyExactPaidMinutes == other.WeeklyExactPaidMinutes ||
                WeeklyExactPaidMinutes != null &&
                WeeklyExactPaidMinutes.Equals(other.WeeklyExactPaidMinutes)
            ) &&
            (
                WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                WeeklyMinimumPaidMinutes != null &&
                WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
            ) &&
            (
                WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                WeeklyMaximumPaidMinutes != null &&
                WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
            ) &&
            (
                OptionalDays == other.OptionalDays ||
                OptionalDays != null &&
                OptionalDays.Equals(other.OptionalDays)
            ) &&
            (
                Shifts == other.Shifts ||
                Shifts != null &&
                Shifts.SequenceEqual(other.Shifts)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ConstrainWeeklyPaidTime != null)
            {
                hash = hash * 59 + ConstrainWeeklyPaidTime.GetHashCode();
            }

            if (FlexibleWeeklyPaidTime != null)
            {
                hash = hash * 59 + FlexibleWeeklyPaidTime.GetHashCode();
            }

            if (WeeklyExactPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyExactPaidMinutes.GetHashCode();
            }

            if (WeeklyMinimumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMinimumPaidMinutes.GetHashCode();
            }

            if (WeeklyMaximumPaidMinutes != null)
            {
                hash = hash * 59 + WeeklyMaximumPaidMinutes.GetHashCode();
            }

            if (OptionalDays != null)
            {
                hash = hash * 59 + OptionalDays.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
