using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MuteSnoozeFields
/// </summary>
[DataContract]
public partial class MuteSnoozeFields : IEquatable<MuteSnoozeFields>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MuteSnoozeFields" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MuteSnoozeFields() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MuteSnoozeFields" /> class.
    /// </summary>
    /// <param name="DateStart">The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateEnd">The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public MuteSnoozeFields(DateTime? DateStart = null, DateTime? DateEnd = null)
    {
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;

    }



    /// <summary>
    /// The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public DateTime? DateEnd { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MuteSnoozeFields {\n");

        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
        return Equals(obj as MuteSnoozeFields);
    }

    /// <summary>
    /// Returns true if MuteSnoozeFields instances are equal
    /// </summary>
    /// <param name="other">Instance of MuteSnoozeFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MuteSnoozeFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
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
            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            return hash;
        }
    }
}
