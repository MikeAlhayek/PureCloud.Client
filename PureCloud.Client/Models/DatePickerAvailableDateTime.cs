using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DatePickerAvailableDateTime
/// </summary>
[DataContract]
public partial class DatePickerAvailableDateTime : IEquatable<DatePickerAvailableDateTime>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DatePickerAvailableDateTime" /> class.
    /// </summary>
    /// <param name="Duration">The duration of the scheduling event in seconds..</param>
    /// <param name="DateTime">The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public DatePickerAvailableDateTime(long? Duration = null, DateTime? DateTime = null)
    {
        this.Duration = Duration;
        this.DateTime = DateTime;

    }



    /// <summary>
    /// The duration of the scheduling event in seconds.
    /// </summary>
    /// <value>The duration of the scheduling event in seconds.</value>
    [DataMember(Name = "duration", EmitDefaultValue = false)]
    public long? Duration { get; set; }



    /// <summary>
    /// The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and times of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateTime", EmitDefaultValue = false)]
    public DateTime? DateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DatePickerAvailableDateTime {\n");

        sb.Append("  Duration: ").Append(Duration).Append("\n");
        sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
        return Equals(obj as DatePickerAvailableDateTime);
    }

    /// <summary>
    /// Returns true if DatePickerAvailableDateTime instances are equal
    /// </summary>
    /// <param name="other">Instance of DatePickerAvailableDateTime to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DatePickerAvailableDateTime other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
            ) &&
            (
                DateTime == other.DateTime ||
                DateTime != null &&
                DateTime.Equals(other.DateTime)
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
            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            if (DateTime != null)
            {
                hash = hash * 59 + DateTime.GetHashCode();
            }

            return hash;
        }
    }
}
