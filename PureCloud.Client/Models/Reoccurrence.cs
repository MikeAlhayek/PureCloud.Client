using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Reoccurrence
/// </summary>
[DataContract]
public partial class Reoccurrence : IEquatable<Reoccurrence>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Reoccurrence" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Reoccurrence() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Reoccurrence" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Start">The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="End">The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss (required).</param>
    /// <param name="TimeZone">The time zone for the recurrence. The time zone of the recurrence is determined by prioritizing the recurrence&#39;s time zone if specified, then the schedule&#39;s time zone if set, and finally defaulting to UTC if neither defines a time zone. See here for a list of valid time zones https://www.iana.org/time-zones.</param>
    /// <param name="Pattern">The schedule pattern e.g.: Daily/Weekly (required).</param>
    /// <param name="Range">The schedule range e.g.: EndDate/NoEnd/Numbered (required).</param>
    /// <param name="Alterations">Modifications to the original recurrence schedule (Exclusions/Inclusions).</param>
    public Reoccurrence(string Id = null, string Start = null, string End = null, string TimeZone = null, Pattern Pattern = null, Range Range = null, List<Alteration> Alterations = null)
    {
        this.Id = Id;
        this.Start = Start;
        this.End = End;
        this.TimeZone = TimeZone;
        this.Pattern = Pattern;
        this.Range = Range;
        this.Alterations = Alterations;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The start date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "start", EmitDefaultValue = false)]
    public string Start { get; set; }



    /// <summary>
    /// The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The end date time of the initial occurrence as an ISO-8601 string in the format YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "end", EmitDefaultValue = false)]
    public string End { get; set; }



    /// <summary>
    /// The time zone for the recurrence. The time zone of the recurrence is determined by prioritizing the recurrence&#39;s time zone if specified, then the schedule&#39;s time zone if set, and finally defaulting to UTC if neither defines a time zone. See here for a list of valid time zones https://www.iana.org/time-zones
    /// </summary>
    /// <value>The time zone for the recurrence. The time zone of the recurrence is determined by prioritizing the recurrence&#39;s time zone if specified, then the schedule&#39;s time zone if set, and finally defaulting to UTC if neither defines a time zone. See here for a list of valid time zones https://www.iana.org/time-zones</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// The schedule pattern e.g.: Daily/Weekly
    /// </summary>
    /// <value>The schedule pattern e.g.: Daily/Weekly</value>
    [DataMember(Name = "pattern", EmitDefaultValue = false)]
    public Pattern Pattern { get; set; }



    /// <summary>
    /// The schedule range e.g.: EndDate/NoEnd/Numbered
    /// </summary>
    /// <value>The schedule range e.g.: EndDate/NoEnd/Numbered</value>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public Range Range { get; set; }



    /// <summary>
    /// Modifications to the original recurrence schedule (Exclusions/Inclusions)
    /// </summary>
    /// <value>Modifications to the original recurrence schedule (Exclusions/Inclusions)</value>
    [DataMember(Name = "alterations", EmitDefaultValue = false)]
    public List<Alteration> Alterations { get; set; }



    /// <summary>
    /// The next occurrence details for the next start and end occurrences for the recurrence
    /// </summary>
    /// <value>The next occurrence details for the next start and end occurrences for the recurrence</value>
    [DataMember(Name = "nextOccurrenceDetails", EmitDefaultValue = false)]
    public NextOccurrenceDetails NextOccurrenceDetails { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Reoccurrence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
        sb.Append("  Alterations: ").Append(Alterations).Append("\n");
        sb.Append("  NextOccurrenceDetails: ").Append(NextOccurrenceDetails).Append("\n");
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
        return Equals(obj as Reoccurrence);
    }

    /// <summary>
    /// Returns true if Reoccurrence instances are equal
    /// </summary>
    /// <param name="other">Instance of Reoccurrence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Reoccurrence other)
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
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
            ) &&
            (
                Range == other.Range ||
                Range != null &&
                Range.Equals(other.Range)
            ) &&
            (
                Alterations == other.Alterations ||
                Alterations != null &&
                Alterations.SequenceEqual(other.Alterations)
            ) &&
            (
                NextOccurrenceDetails == other.NextOccurrenceDetails ||
                NextOccurrenceDetails != null &&
                NextOccurrenceDetails.Equals(other.NextOccurrenceDetails)
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

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            if (Range != null)
            {
                hash = hash * 59 + Range.GetHashCode();
            }

            if (Alterations != null)
            {
                hash = hash * 59 + Alterations.GetHashCode();
            }

            if (NextOccurrenceDetails != null)
            {
                hash = hash * 59 + NextOccurrenceDetails.GetHashCode();
            }

            return hash;
        }
    }
}
