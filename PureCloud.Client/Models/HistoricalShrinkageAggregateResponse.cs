using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalShrinkageAggregateResponse
/// </summary>
[DataContract]
public partial class HistoricalShrinkageAggregateResponse : IEquatable<HistoricalShrinkageAggregateResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalShrinkageAggregateResponse" /> class.
    /// </summary>
    /// <param name="ScheduledShrinkageSeconds">Aggregated shrinkage value in seconds for scheduled activities.</param>
    /// <param name="ScheduledShrinkagePercent">Aggregated shrinkage value in percent from 0.0 to 100.0 for scheduled activities.</param>
    /// <param name="ActualShrinkageSeconds">Aggregated actual value in seconds for scheduled activities.</param>
    /// <param name="ActualShrinkagePercent">Aggregated actual value in percent from 0.0 to 100.0 for scheduled activities.</param>
    /// <param name="PaidShrinkageSeconds">Aggregated shrinkage value in seconds for paid activities.</param>
    /// <param name="UnpaidShrinkageSeconds">Aggregated shrinkage value in seconds for unpaid activities.</param>
    /// <param name="PlannedShrinkageSeconds">Aggregated shrinkage value in seconds for planned activities.</param>
    /// <param name="UnplannedShrinkageSeconds">Aggregated shrinkage value in seconds for unplanned activities.</param>
    public HistoricalShrinkageAggregateResponse(int? ScheduledShrinkageSeconds = null, double? ScheduledShrinkagePercent = null, int? ActualShrinkageSeconds = null, double? ActualShrinkagePercent = null, int? PaidShrinkageSeconds = null, int? UnpaidShrinkageSeconds = null, int? PlannedShrinkageSeconds = null, int? UnplannedShrinkageSeconds = null)
    {
        this.ScheduledShrinkageSeconds = ScheduledShrinkageSeconds;
        this.ScheduledShrinkagePercent = ScheduledShrinkagePercent;
        this.ActualShrinkageSeconds = ActualShrinkageSeconds;
        this.ActualShrinkagePercent = ActualShrinkagePercent;
        this.PaidShrinkageSeconds = PaidShrinkageSeconds;
        this.UnpaidShrinkageSeconds = UnpaidShrinkageSeconds;
        this.PlannedShrinkageSeconds = PlannedShrinkageSeconds;
        this.UnplannedShrinkageSeconds = UnplannedShrinkageSeconds;

    }



    /// <summary>
    /// Aggregated shrinkage value in seconds for scheduled activities
    /// </summary>
    /// <value>Aggregated shrinkage value in seconds for scheduled activities</value>
    [DataMember(Name = "scheduledShrinkageSeconds", EmitDefaultValue = false)]
    public int? ScheduledShrinkageSeconds { get; set; }



    /// <summary>
    /// Aggregated shrinkage value in percent from 0.0 to 100.0 for scheduled activities
    /// </summary>
    /// <value>Aggregated shrinkage value in percent from 0.0 to 100.0 for scheduled activities</value>
    [DataMember(Name = "scheduledShrinkagePercent", EmitDefaultValue = false)]
    public double? ScheduledShrinkagePercent { get; set; }



    /// <summary>
    /// Aggregated actual value in seconds for scheduled activities
    /// </summary>
    /// <value>Aggregated actual value in seconds for scheduled activities</value>
    [DataMember(Name = "actualShrinkageSeconds", EmitDefaultValue = false)]
    public int? ActualShrinkageSeconds { get; set; }



    /// <summary>
    /// Aggregated actual value in percent from 0.0 to 100.0 for scheduled activities
    /// </summary>
    /// <value>Aggregated actual value in percent from 0.0 to 100.0 for scheduled activities</value>
    [DataMember(Name = "actualShrinkagePercent", EmitDefaultValue = false)]
    public double? ActualShrinkagePercent { get; set; }



    /// <summary>
    /// Aggregated shrinkage value in seconds for paid activities
    /// </summary>
    /// <value>Aggregated shrinkage value in seconds for paid activities</value>
    [DataMember(Name = "paidShrinkageSeconds", EmitDefaultValue = false)]
    public int? PaidShrinkageSeconds { get; set; }



    /// <summary>
    /// Aggregated shrinkage value in seconds for unpaid activities
    /// </summary>
    /// <value>Aggregated shrinkage value in seconds for unpaid activities</value>
    [DataMember(Name = "unpaidShrinkageSeconds", EmitDefaultValue = false)]
    public int? UnpaidShrinkageSeconds { get; set; }



    /// <summary>
    /// Aggregated shrinkage value in seconds for planned activities
    /// </summary>
    /// <value>Aggregated shrinkage value in seconds for planned activities</value>
    [DataMember(Name = "plannedShrinkageSeconds", EmitDefaultValue = false)]
    public int? PlannedShrinkageSeconds { get; set; }



    /// <summary>
    /// Aggregated shrinkage value in seconds for unplanned activities
    /// </summary>
    /// <value>Aggregated shrinkage value in seconds for unplanned activities</value>
    [DataMember(Name = "unplannedShrinkageSeconds", EmitDefaultValue = false)]
    public int? UnplannedShrinkageSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalShrinkageAggregateResponse {\n");

        sb.Append("  ScheduledShrinkageSeconds: ").Append(ScheduledShrinkageSeconds).Append("\n");
        sb.Append("  ScheduledShrinkagePercent: ").Append(ScheduledShrinkagePercent).Append("\n");
        sb.Append("  ActualShrinkageSeconds: ").Append(ActualShrinkageSeconds).Append("\n");
        sb.Append("  ActualShrinkagePercent: ").Append(ActualShrinkagePercent).Append("\n");
        sb.Append("  PaidShrinkageSeconds: ").Append(PaidShrinkageSeconds).Append("\n");
        sb.Append("  UnpaidShrinkageSeconds: ").Append(UnpaidShrinkageSeconds).Append("\n");
        sb.Append("  PlannedShrinkageSeconds: ").Append(PlannedShrinkageSeconds).Append("\n");
        sb.Append("  UnplannedShrinkageSeconds: ").Append(UnplannedShrinkageSeconds).Append("\n");
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
        return Equals(obj as HistoricalShrinkageAggregateResponse);
    }

    /// <summary>
    /// Returns true if HistoricalShrinkageAggregateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalShrinkageAggregateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalShrinkageAggregateResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScheduledShrinkageSeconds == other.ScheduledShrinkageSeconds ||
                ScheduledShrinkageSeconds != null &&
                ScheduledShrinkageSeconds.Equals(other.ScheduledShrinkageSeconds)
            ) &&
            (
                ScheduledShrinkagePercent == other.ScheduledShrinkagePercent ||
                ScheduledShrinkagePercent != null &&
                ScheduledShrinkagePercent.Equals(other.ScheduledShrinkagePercent)
            ) &&
            (
                ActualShrinkageSeconds == other.ActualShrinkageSeconds ||
                ActualShrinkageSeconds != null &&
                ActualShrinkageSeconds.Equals(other.ActualShrinkageSeconds)
            ) &&
            (
                ActualShrinkagePercent == other.ActualShrinkagePercent ||
                ActualShrinkagePercent != null &&
                ActualShrinkagePercent.Equals(other.ActualShrinkagePercent)
            ) &&
            (
                PaidShrinkageSeconds == other.PaidShrinkageSeconds ||
                PaidShrinkageSeconds != null &&
                PaidShrinkageSeconds.Equals(other.PaidShrinkageSeconds)
            ) &&
            (
                UnpaidShrinkageSeconds == other.UnpaidShrinkageSeconds ||
                UnpaidShrinkageSeconds != null &&
                UnpaidShrinkageSeconds.Equals(other.UnpaidShrinkageSeconds)
            ) &&
            (
                PlannedShrinkageSeconds == other.PlannedShrinkageSeconds ||
                PlannedShrinkageSeconds != null &&
                PlannedShrinkageSeconds.Equals(other.PlannedShrinkageSeconds)
            ) &&
            (
                UnplannedShrinkageSeconds == other.UnplannedShrinkageSeconds ||
                UnplannedShrinkageSeconds != null &&
                UnplannedShrinkageSeconds.Equals(other.UnplannedShrinkageSeconds)
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
            if (ScheduledShrinkageSeconds != null)
            {
                hash = hash * 59 + ScheduledShrinkageSeconds.GetHashCode();
            }

            if (ScheduledShrinkagePercent != null)
            {
                hash = hash * 59 + ScheduledShrinkagePercent.GetHashCode();
            }

            if (ActualShrinkageSeconds != null)
            {
                hash = hash * 59 + ActualShrinkageSeconds.GetHashCode();
            }

            if (ActualShrinkagePercent != null)
            {
                hash = hash * 59 + ActualShrinkagePercent.GetHashCode();
            }

            if (PaidShrinkageSeconds != null)
            {
                hash = hash * 59 + PaidShrinkageSeconds.GetHashCode();
            }

            if (UnpaidShrinkageSeconds != null)
            {
                hash = hash * 59 + UnpaidShrinkageSeconds.GetHashCode();
            }

            if (PlannedShrinkageSeconds != null)
            {
                hash = hash * 59 + PlannedShrinkageSeconds.GetHashCode();
            }

            if (UnplannedShrinkageSeconds != null)
            {
                hash = hash * 59 + UnplannedShrinkageSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
