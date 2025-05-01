using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayDataUpdate
/// </summary>
[DataContract]
public partial class WfmIntradayDataUpdateTopicIntradayDataUpdate : IEquatable<WfmIntradayDataUpdateTopicIntradayDataUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayDataUpdate" /> class.
    /// </summary>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="EndDate">EndDate.</param>
    /// <param name="IntervalLengthMinutes">IntervalLengthMinutes.</param>
    /// <param name="NumberOfIntervals">NumberOfIntervals.</param>
    /// <param name="Metrics">Metrics.</param>
    /// <param name="QueueIds">QueueIds.</param>
    /// <param name="IntradayDataGroupings">IntradayDataGroupings.</param>
    public WfmIntradayDataUpdateTopicIntradayDataUpdate(DateTime? StartDate = null, DateTime? EndDate = null, long? IntervalLengthMinutes = null, long? NumberOfIntervals = null, List<WfmIntradayDataUpdateTopicIntradayMetric> Metrics = null, List<string> QueueIds = null, List<WfmIntradayDataUpdateTopicIntradayDataGroup> IntradayDataGroupings = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.IntervalLengthMinutes = IntervalLengthMinutes;
        this.NumberOfIntervals = NumberOfIntervals;
        this.Metrics = Metrics;
        this.QueueIds = QueueIds;
        this.IntradayDataGroupings = IntradayDataGroupings;

    }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Gets or Sets IntervalLengthMinutes
    /// </summary>
    [DataMember(Name = "intervalLengthMinutes", EmitDefaultValue = false)]
    public long? IntervalLengthMinutes { get; set; }



    /// <summary>
    /// Gets or Sets NumberOfIntervals
    /// </summary>
    [DataMember(Name = "numberOfIntervals", EmitDefaultValue = false)]
    public long? NumberOfIntervals { get; set; }



    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public List<WfmIntradayDataUpdateTopicIntradayMetric> Metrics { get; set; }



    /// <summary>
    /// Gets or Sets QueueIds
    /// </summary>
    [DataMember(Name = "queueIds", EmitDefaultValue = false)]
    public List<string> QueueIds { get; set; }



    /// <summary>
    /// Gets or Sets IntradayDataGroupings
    /// </summary>
    [DataMember(Name = "intradayDataGroupings", EmitDefaultValue = false)]
    public List<WfmIntradayDataUpdateTopicIntradayDataGroup> IntradayDataGroupings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayDataUpdate {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
        sb.Append("  NumberOfIntervals: ").Append(NumberOfIntervals).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
        sb.Append("  IntradayDataGroupings: ").Append(IntradayDataGroupings).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayDataUpdate);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayDataUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayDataUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayDataUpdate other)
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
                IntervalLengthMinutes == other.IntervalLengthMinutes ||
                IntervalLengthMinutes != null &&
                IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
            ) &&
            (
                NumberOfIntervals == other.NumberOfIntervals ||
                NumberOfIntervals != null &&
                NumberOfIntervals.Equals(other.NumberOfIntervals)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
            ) &&
            (
                IntradayDataGroupings == other.IntradayDataGroupings ||
                IntradayDataGroupings != null &&
                IntradayDataGroupings.SequenceEqual(other.IntradayDataGroupings)
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

            if (IntervalLengthMinutes != null)
            {
                hash = hash * 59 + IntervalLengthMinutes.GetHashCode();
            }

            if (NumberOfIntervals != null)
            {
                hash = hash * 59 + NumberOfIntervals.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            if (IntradayDataGroupings != null)
            {
                hash = hash * 59 + IntradayDataGroupings.GetHashCode();
            }

            return hash;
        }
    }
}
