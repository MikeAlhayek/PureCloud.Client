using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AtzmTimeSlot
/// </summary>

public partial class AtzmTimeSlot : IEquatable<AtzmTimeSlot>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AtzmTimeSlot" /> class.
    /// </summary>
    /// <param name="EarliestCallableTime">The earliest time to dial a contact. Valid format is HH:mm.</param>
    /// <param name="LatestCallableTime">The latest time to dial a contact. Valid format is HH:mm.</param>
    public AtzmTimeSlot(string EarliestCallableTime = null, string LatestCallableTime = null)
    {
        this.EarliestCallableTime = EarliestCallableTime;
        this.LatestCallableTime = LatestCallableTime;

    }



    /// <summary>
    /// The earliest time to dial a contact. Valid format is HH:mm
    /// </summary>
    /// <value>The earliest time to dial a contact. Valid format is HH:mm</value>
    [JsonPropertyName("earliestCallableTime")]
    public string EarliestCallableTime { get; set; }



    /// <summary>
    /// The latest time to dial a contact. Valid format is HH:mm
    /// </summary>
    /// <value>The latest time to dial a contact. Valid format is HH:mm</value>
    [JsonPropertyName("latestCallableTime")]
    public string LatestCallableTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AtzmTimeSlot {\n");

        sb.Append("  EarliestCallableTime: ").Append(EarliestCallableTime).Append("\n");
        sb.Append("  LatestCallableTime: ").Append(LatestCallableTime).Append("\n");
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
        return Equals(obj as AtzmTimeSlot);
    }

    /// <summary>
    /// Returns true if AtzmTimeSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of AtzmTimeSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AtzmTimeSlot other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EarliestCallableTime == other.EarliestCallableTime ||
                EarliestCallableTime != null &&
                EarliestCallableTime.Equals(other.EarliestCallableTime)
            ) &&
            (
                LatestCallableTime == other.LatestCallableTime ||
                LatestCallableTime != null &&
                LatestCallableTime.Equals(other.LatestCallableTime)
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
            if (EarliestCallableTime != null)
            {
                hash = hash * 59 + EarliestCallableTime.GetHashCode();
            }

            if (LatestCallableTime != null)
            {
                hash = hash * 59 + LatestCallableTime.GetHashCode();
            }

            return hash;
        }
    }
}
