using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecurrenceSettings
/// </summary>
[DataContract]
public partial class RecurrenceSettings : IEquatable<RecurrenceSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RecurrenceSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecurrenceSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecurrenceSettings" /> class.
    /// </summary>
    /// <param name="RecurrencePeriod">The recurrence period of the activity plan (required).</param>
    /// <param name="MinimumTimeBetweenOccurrences">Constraint indicating the minimum time in hours between recurrences of the activity plan (required).</param>
    /// <param name="EndAfter">Settings controlling when to end the recurrence for the activity plan (required).</param>
    public RecurrenceSettings(RecurrencePeriod RecurrencePeriod = null, RecurrencePeriod MinimumTimeBetweenOccurrences = null, RecurrenceEndSettings EndAfter = null)
    {
        this.RecurrencePeriod = RecurrencePeriod;
        this.MinimumTimeBetweenOccurrences = MinimumTimeBetweenOccurrences;
        this.EndAfter = EndAfter;

    }



    /// <summary>
    /// The recurrence period of the activity plan
    /// </summary>
    /// <value>The recurrence period of the activity plan</value>
    [DataMember(Name = "recurrencePeriod", EmitDefaultValue = false)]
    public RecurrencePeriod RecurrencePeriod { get; set; }



    /// <summary>
    /// Constraint indicating the minimum time in hours between recurrences of the activity plan
    /// </summary>
    /// <value>Constraint indicating the minimum time in hours between recurrences of the activity plan</value>
    [DataMember(Name = "minimumTimeBetweenOccurrences", EmitDefaultValue = false)]
    public RecurrencePeriod MinimumTimeBetweenOccurrences { get; set; }



    /// <summary>
    /// Settings controlling when to end the recurrence for the activity plan
    /// </summary>
    /// <value>Settings controlling when to end the recurrence for the activity plan</value>
    [DataMember(Name = "endAfter", EmitDefaultValue = false)]
    public RecurrenceEndSettings EndAfter { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecurrenceSettings {\n");

        sb.Append("  RecurrencePeriod: ").Append(RecurrencePeriod).Append("\n");
        sb.Append("  MinimumTimeBetweenOccurrences: ").Append(MinimumTimeBetweenOccurrences).Append("\n");
        sb.Append("  EndAfter: ").Append(EndAfter).Append("\n");
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
        return Equals(obj as RecurrenceSettings);
    }

    /// <summary>
    /// Returns true if RecurrenceSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of RecurrenceSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecurrenceSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RecurrencePeriod == other.RecurrencePeriod ||
                RecurrencePeriod != null &&
                RecurrencePeriod.Equals(other.RecurrencePeriod)
            ) &&
            (
                MinimumTimeBetweenOccurrences == other.MinimumTimeBetweenOccurrences ||
                MinimumTimeBetweenOccurrences != null &&
                MinimumTimeBetweenOccurrences.Equals(other.MinimumTimeBetweenOccurrences)
            ) &&
            (
                EndAfter == other.EndAfter ||
                EndAfter != null &&
                EndAfter.Equals(other.EndAfter)
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
            if (RecurrencePeriod != null)
            {
                hash = hash * 59 + RecurrencePeriod.GetHashCode();
            }

            if (MinimumTimeBetweenOccurrences != null)
            {
                hash = hash * 59 + MinimumTimeBetweenOccurrences.GetHashCode();
            }

            if (EndAfter != null)
            {
                hash = hash * 59 + EndAfter.GetHashCode();
            }

            return hash;
        }
    }
}
