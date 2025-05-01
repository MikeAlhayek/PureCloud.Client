using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerSequenceScheduleConfigChangeScheduleRecurrence
/// </summary>
[DataContract]
public partial class DialerSequenceScheduleConfigChangeScheduleRecurrence : IEquatable<DialerSequenceScheduleConfigChangeScheduleRecurrence>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerSequenceScheduleConfigChangeScheduleRecurrence" /> class.
    /// </summary>
    /// <param name="Id">the recurrence id.</param>
    /// <param name="Start">scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
    /// <param name="End">scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
    /// <param name="TimeZone">the timezone the recurrence will use.</param>
    /// <param name="Range">Range.</param>
    /// <param name="Pattern">Pattern.</param>
    /// <param name="Alterations">modifications to the original recurrence schedule.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerSequenceScheduleConfigChangeScheduleRecurrence(string Id = null, string Start = null, string End = null, string TimeZone = null, DialerSequenceScheduleConfigChangeRecurrenceRange Range = null, DialerSequenceScheduleConfigChangeRecurrencePattern Pattern = null, List<DialerSequenceScheduleConfigChangeAlteration> Alterations = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Id = Id;
        this.Start = Start;
        this.End = End;
        this.TimeZone = TimeZone;
        this.Range = Range;
        this.Pattern = Pattern;
        this.Alterations = Alterations;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// the recurrence id
    /// </summary>
    /// <value>the recurrence id</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    [DataMember(Name = "start", EmitDefaultValue = false)]
    public string Start { get; set; }



    /// <summary>
    /// scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    [DataMember(Name = "end", EmitDefaultValue = false)]
    public string End { get; set; }



    /// <summary>
    /// the timezone the recurrence will use
    /// </summary>
    /// <value>the timezone the recurrence will use</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// Gets or Sets Range
    /// </summary>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public DialerSequenceScheduleConfigChangeRecurrenceRange Range { get; set; }



    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    [DataMember(Name = "pattern", EmitDefaultValue = false)]
    public DialerSequenceScheduleConfigChangeRecurrencePattern Pattern { get; set; }



    /// <summary>
    /// modifications to the original recurrence schedule
    /// </summary>
    /// <value>modifications to the original recurrence schedule</value>
    [DataMember(Name = "alterations", EmitDefaultValue = false)]
    public List<DialerSequenceScheduleConfigChangeAlteration> Alterations { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerSequenceScheduleConfigChangeScheduleRecurrence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
        sb.Append("  Alterations: ").Append(Alterations).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerSequenceScheduleConfigChangeScheduleRecurrence);
    }

    /// <summary>
    /// Returns true if DialerSequenceScheduleConfigChangeScheduleRecurrence instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerSequenceScheduleConfigChangeScheduleRecurrence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerSequenceScheduleConfigChangeScheduleRecurrence other)
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
                Start == other.Start ||
                Start != null &&
                Start.Equals(other.Start)
            ) &&
            (
                End == other.End ||
                End != null &&
                End.Equals(other.End)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                Range == other.Range ||
                Range != null &&
                Range.Equals(other.Range)
            ) &&
            (
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
            ) &&
            (
                Alterations == other.Alterations ||
                Alterations != null &&
                Alterations.SequenceEqual(other.Alterations)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

            if (Start != null)
            {
                hash = hash * 59 + Start.GetHashCode();
            }

            if (End != null)
            {
                hash = hash * 59 + End.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (Range != null)
            {
                hash = hash * 59 + Range.GetHashCode();
            }

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            if (Alterations != null)
            {
                hash = hash * 59 + Alterations.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
