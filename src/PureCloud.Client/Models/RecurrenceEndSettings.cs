using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecurrenceEndSettings
/// </summary>

public partial class RecurrenceEndSettings : IEquatable<RecurrenceEndSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecurrenceEndSettings" /> class.
    /// </summary>
    /// <param name="LastDate">The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set.</param>
    /// <param name="NoEndDate">Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set.</param>
    public RecurrenceEndSettings(DateTime? LastDate = null, bool? NoEndDate = null)
    {
        this.LastDate = LastDate;
        this.NoEndDate = NoEndDate;

    }



    /// <summary>
    /// The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set
    /// </summary>
    /// <value>The end date of the recurrence for the activity plan, in ISO-8601 format. Only one of lastDate or noEndDate may be set</value>
    [JsonPropertyName("lastDate")]
    public DateTime? LastDate { get; set; }



    /// <summary>
    /// Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set
    /// </summary>
    /// <value>Whether this activity plan should continue indefinitely. If set to true, lastDate must not be set</value>
    [JsonPropertyName("noEndDate")]
    public bool? NoEndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecurrenceEndSettings {\n");

        sb.Append("  LastDate: ").Append(LastDate).Append("\n");
        sb.Append("  NoEndDate: ").Append(NoEndDate).Append("\n");
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
        return Equals(obj as RecurrenceEndSettings);
    }

    /// <summary>
    /// Returns true if RecurrenceEndSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of RecurrenceEndSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecurrenceEndSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LastDate == other.LastDate ||
                LastDate != null &&
                LastDate.Equals(other.LastDate)
            ) &&
            (
                NoEndDate == other.NoEndDate ||
                NoEndDate != null &&
                NoEndDate.Equals(other.NoEndDate)
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
            if (LastDate != null)
            {
                hash = hash * 59 + LastDate.GetHashCode();
            }

            if (NoEndDate != null)
            {
                hash = hash * 59 + NoEndDate.GetHashCode();
            }

            return hash;
        }
    }
}
