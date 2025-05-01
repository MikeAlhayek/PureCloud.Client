using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsDetailsMetricItem
/// </summary>
[DataContract]
public partial class InsightsDetailsMetricItem : IEquatable<InsightsDetailsMetricItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsDetailsMetricItem" /> class.
    /// </summary>
    /// <param name="Metric">The gamification metric for the data.</param>
    /// <param name="ComparativePeriod">Insights data in the comparative period.</param>
    /// <param name="PrimaryPeriod">Insights data in the primary period.</param>
    /// <param name="PercentOfGoalChange">Percent of goal change.</param>
    /// <param name="ValueChange">Value change.</param>
    public InsightsDetailsMetricItem(AddressableEntityRef Metric = null, InsightsDetailsMetricPeriodPoints ComparativePeriod = null, InsightsDetailsMetricPeriodPoints PrimaryPeriod = null, double? PercentOfGoalChange = null, double? ValueChange = null)
    {
        this.Metric = Metric;
        this.ComparativePeriod = ComparativePeriod;
        this.PrimaryPeriod = PrimaryPeriod;
        this.PercentOfGoalChange = PercentOfGoalChange;
        this.ValueChange = ValueChange;

    }



    /// <summary>
    /// The gamification metric for the data
    /// </summary>
    /// <value>The gamification metric for the data</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public AddressableEntityRef Metric { get; set; }



    /// <summary>
    /// Insights data in the comparative period
    /// </summary>
    /// <value>Insights data in the comparative period</value>
    [DataMember(Name = "comparativePeriod", EmitDefaultValue = false)]
    public InsightsDetailsMetricPeriodPoints ComparativePeriod { get; set; }



    /// <summary>
    /// Insights data in the primary period
    /// </summary>
    /// <value>Insights data in the primary period</value>
    [DataMember(Name = "primaryPeriod", EmitDefaultValue = false)]
    public InsightsDetailsMetricPeriodPoints PrimaryPeriod { get; set; }



    /// <summary>
    /// Percent of goal change
    /// </summary>
    /// <value>Percent of goal change</value>
    [DataMember(Name = "percentOfGoalChange", EmitDefaultValue = false)]
    public double? PercentOfGoalChange { get; set; }



    /// <summary>
    /// Value change
    /// </summary>
    /// <value>Value change</value>
    [DataMember(Name = "valueChange", EmitDefaultValue = false)]
    public double? ValueChange { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsDetailsMetricItem {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
        sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
        sb.Append("  PercentOfGoalChange: ").Append(PercentOfGoalChange).Append("\n");
        sb.Append("  ValueChange: ").Append(ValueChange).Append("\n");
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
        return Equals(obj as InsightsDetailsMetricItem);
    }

    /// <summary>
    /// Returns true if InsightsDetailsMetricItem instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsDetailsMetricItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsDetailsMetricItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                ComparativePeriod == other.ComparativePeriod ||
                ComparativePeriod != null &&
                ComparativePeriod.Equals(other.ComparativePeriod)
            ) &&
            (
                PrimaryPeriod == other.PrimaryPeriod ||
                PrimaryPeriod != null &&
                PrimaryPeriod.Equals(other.PrimaryPeriod)
            ) &&
            (
                PercentOfGoalChange == other.PercentOfGoalChange ||
                PercentOfGoalChange != null &&
                PercentOfGoalChange.Equals(other.PercentOfGoalChange)
            ) &&
            (
                ValueChange == other.ValueChange ||
                ValueChange != null &&
                ValueChange.Equals(other.ValueChange)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (ComparativePeriod != null)
            {
                hash = hash * 59 + ComparativePeriod.GetHashCode();
            }

            if (PrimaryPeriod != null)
            {
                hash = hash * 59 + PrimaryPeriod.GetHashCode();
            }

            if (PercentOfGoalChange != null)
            {
                hash = hash * 59 + PercentOfGoalChange.GetHashCode();
            }

            if (ValueChange != null)
            {
                hash = hash * 59 + ValueChange.GetHashCode();
            }

            return hash;
        }
    }
}
