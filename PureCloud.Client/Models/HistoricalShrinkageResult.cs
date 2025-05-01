using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalShrinkageResult
/// </summary>
[DataContract]
public partial class HistoricalShrinkageResult : IEquatable<HistoricalShrinkageResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalShrinkageResult" /> class.
    /// </summary>
    /// <param name="StartDate">Beginning of the date range that was queried, in ISO-8601 format.</param>
    /// <param name="EndDate">End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time.</param>
    /// <param name="TotalScheduledDurationSeconds">Total duration in seconds for which agents in the management unit are scheduled.</param>
    /// <param name="TotalLoggedInDurationSeconds">Total duration in seconds for which agents in the management unit are actually logged-in.</param>
    /// <param name="AggregatedShrinkage">Aggregated shrinkage data for all the activity categories.</param>
    /// <param name="ShrinkageForActivityCategories">Shrinkage for activity categories.</param>
    /// <param name="BusinessUnitIds">List of all business units of all the agents in response.</param>
    public HistoricalShrinkageResult(DateTime? StartDate = null, DateTime? EndDate = null, int? TotalScheduledDurationSeconds = null, int? TotalLoggedInDurationSeconds = null, HistoricalShrinkageAggregateResponse AggregatedShrinkage = null, List<HistoricalShrinkageActivityCategoryResponse> ShrinkageForActivityCategories = null, List<string> BusinessUnitIds = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.TotalScheduledDurationSeconds = TotalScheduledDurationSeconds;
        this.TotalLoggedInDurationSeconds = TotalLoggedInDurationSeconds;
        this.AggregatedShrinkage = AggregatedShrinkage;
        this.ShrinkageForActivityCategories = ShrinkageForActivityCategories;
        this.BusinessUnitIds = BusinessUnitIds;

    }



    /// <summary>
    /// Beginning of the date range that was queried, in ISO-8601 format
    /// </summary>
    /// <value>Beginning of the date range that was queried, in ISO-8601 format</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time
    /// </summary>
    /// <value>End of the date range that was queried, in ISO-8601 format. If it was not set, end date will be set to the queried time</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Total duration in seconds for which agents in the management unit are scheduled
    /// </summary>
    /// <value>Total duration in seconds for which agents in the management unit are scheduled</value>
    [DataMember(Name = "totalScheduledDurationSeconds", EmitDefaultValue = false)]
    public int? TotalScheduledDurationSeconds { get; set; }



    /// <summary>
    /// Total duration in seconds for which agents in the management unit are actually logged-in
    /// </summary>
    /// <value>Total duration in seconds for which agents in the management unit are actually logged-in</value>
    [DataMember(Name = "totalLoggedInDurationSeconds", EmitDefaultValue = false)]
    public int? TotalLoggedInDurationSeconds { get; set; }



    /// <summary>
    /// Aggregated shrinkage data for all the activity categories
    /// </summary>
    /// <value>Aggregated shrinkage data for all the activity categories</value>
    [DataMember(Name = "aggregatedShrinkage", EmitDefaultValue = false)]
    public HistoricalShrinkageAggregateResponse AggregatedShrinkage { get; set; }



    /// <summary>
    /// Shrinkage for activity categories
    /// </summary>
    /// <value>Shrinkage for activity categories</value>
    [DataMember(Name = "shrinkageForActivityCategories", EmitDefaultValue = false)]
    public List<HistoricalShrinkageActivityCategoryResponse> ShrinkageForActivityCategories { get; set; }



    /// <summary>
    /// List of all business units of all the agents in response
    /// </summary>
    /// <value>List of all business units of all the agents in response</value>
    [DataMember(Name = "businessUnitIds", EmitDefaultValue = false)]
    public List<string> BusinessUnitIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalShrinkageResult {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  TotalScheduledDurationSeconds: ").Append(TotalScheduledDurationSeconds).Append("\n");
        sb.Append("  TotalLoggedInDurationSeconds: ").Append(TotalLoggedInDurationSeconds).Append("\n");
        sb.Append("  AggregatedShrinkage: ").Append(AggregatedShrinkage).Append("\n");
        sb.Append("  ShrinkageForActivityCategories: ").Append(ShrinkageForActivityCategories).Append("\n");
        sb.Append("  BusinessUnitIds: ").Append(BusinessUnitIds).Append("\n");
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
        return Equals(obj as HistoricalShrinkageResult);
    }

    /// <summary>
    /// Returns true if HistoricalShrinkageResult instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalShrinkageResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalShrinkageResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                TotalScheduledDurationSeconds == other.TotalScheduledDurationSeconds ||
                TotalScheduledDurationSeconds != null &&
                TotalScheduledDurationSeconds.Equals(other.TotalScheduledDurationSeconds)
            ) &&
            (
                TotalLoggedInDurationSeconds == other.TotalLoggedInDurationSeconds ||
                TotalLoggedInDurationSeconds != null &&
                TotalLoggedInDurationSeconds.Equals(other.TotalLoggedInDurationSeconds)
            ) &&
            (
                AggregatedShrinkage == other.AggregatedShrinkage ||
                AggregatedShrinkage != null &&
                AggregatedShrinkage.Equals(other.AggregatedShrinkage)
            ) &&
            (
                ShrinkageForActivityCategories == other.ShrinkageForActivityCategories ||
                ShrinkageForActivityCategories != null &&
                ShrinkageForActivityCategories.SequenceEqual(other.ShrinkageForActivityCategories)
            ) &&
            (
                BusinessUnitIds == other.BusinessUnitIds ||
                BusinessUnitIds != null &&
                BusinessUnitIds.SequenceEqual(other.BusinessUnitIds)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (TotalScheduledDurationSeconds != null)
            {
                hash = hash * 59 + TotalScheduledDurationSeconds.GetHashCode();
            }

            if (TotalLoggedInDurationSeconds != null)
            {
                hash = hash * 59 + TotalLoggedInDurationSeconds.GetHashCode();
            }

            if (AggregatedShrinkage != null)
            {
                hash = hash * 59 + AggregatedShrinkage.GetHashCode();
            }

            if (ShrinkageForActivityCategories != null)
            {
                hash = hash * 59 + ShrinkageForActivityCategories.GetHashCode();
            }

            if (BusinessUnitIds != null)
            {
                hash = hash * 59 + BusinessUnitIds.GetHashCode();
            }

            return hash;
        }
    }
}
