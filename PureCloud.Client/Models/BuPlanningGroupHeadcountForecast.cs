using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuPlanningGroupHeadcountForecast
/// </summary>
[DataContract]
public partial class BuPlanningGroupHeadcountForecast : IEquatable<BuPlanningGroupHeadcountForecast>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuPlanningGroupHeadcountForecast" /> class.
    /// </summary>
    /// <param name="PlanningGroup">The planning group to which this portion of the headcount forecast applies.</param>
    /// <param name="RequiredPerInterval">Required headcount per interval, referenced against the reference start date.</param>
    /// <param name="RequiredWithoutShrinkagePerInterval">Required headcount per interval without accounting for shrinkage, referenced against the reference start date.</param>
    public BuPlanningGroupHeadcountForecast(PlanningGroupReference PlanningGroup = null, List<double?> RequiredPerInterval = null, List<double?> RequiredWithoutShrinkagePerInterval = null)
    {
        this.PlanningGroup = PlanningGroup;
        this.RequiredPerInterval = RequiredPerInterval;
        this.RequiredWithoutShrinkagePerInterval = RequiredWithoutShrinkagePerInterval;

    }



    /// <summary>
    /// The planning group to which this portion of the headcount forecast applies
    /// </summary>
    /// <value>The planning group to which this portion of the headcount forecast applies</value>
    [DataMember(Name = "planningGroup", EmitDefaultValue = false)]
    public PlanningGroupReference PlanningGroup { get; set; }



    /// <summary>
    /// Required headcount per interval, referenced against the reference start date
    /// </summary>
    /// <value>Required headcount per interval, referenced against the reference start date</value>
    [DataMember(Name = "requiredPerInterval", EmitDefaultValue = false)]
    public List<double?> RequiredPerInterval { get; set; }



    /// <summary>
    /// Required headcount per interval without accounting for shrinkage, referenced against the reference start date
    /// </summary>
    /// <value>Required headcount per interval without accounting for shrinkage, referenced against the reference start date</value>
    [DataMember(Name = "requiredWithoutShrinkagePerInterval", EmitDefaultValue = false)]
    public List<double?> RequiredWithoutShrinkagePerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuPlanningGroupHeadcountForecast {\n");

        sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
        sb.Append("  RequiredPerInterval: ").Append(RequiredPerInterval).Append("\n");
        sb.Append("  RequiredWithoutShrinkagePerInterval: ").Append(RequiredWithoutShrinkagePerInterval).Append("\n");
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
        return Equals(obj as BuPlanningGroupHeadcountForecast);
    }

    /// <summary>
    /// Returns true if BuPlanningGroupHeadcountForecast instances are equal
    /// </summary>
    /// <param name="other">Instance of BuPlanningGroupHeadcountForecast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuPlanningGroupHeadcountForecast other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PlanningGroup == other.PlanningGroup ||
                PlanningGroup != null &&
                PlanningGroup.Equals(other.PlanningGroup)
            ) &&
            (
                RequiredPerInterval == other.RequiredPerInterval ||
                RequiredPerInterval != null &&
                RequiredPerInterval.SequenceEqual(other.RequiredPerInterval)
            ) &&
            (
                RequiredWithoutShrinkagePerInterval == other.RequiredWithoutShrinkagePerInterval ||
                RequiredWithoutShrinkagePerInterval != null &&
                RequiredWithoutShrinkagePerInterval.SequenceEqual(other.RequiredWithoutShrinkagePerInterval)
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
            if (PlanningGroup != null)
            {
                hash = hash * 59 + PlanningGroup.GetHashCode();
            }

            if (RequiredPerInterval != null)
            {
                hash = hash * 59 + RequiredPerInterval.GetHashCode();
            }

            if (RequiredWithoutShrinkagePerInterval != null)
            {
                hash = hash * 59 + RequiredWithoutShrinkagePerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
