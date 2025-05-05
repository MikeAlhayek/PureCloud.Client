using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallRecord
/// </summary>

public partial class CallRecord : IEquatable<CallRecord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallRecord" /> class.
    /// </summary>
    public CallRecord()
    {

    }



    /// <summary>
    /// Timestamp of the last attempt to reach this number. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of the last attempt to reach this number. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("lastAttempt")]
    public DateTime? LastAttempt { get; private set; }



    /// <summary>
    /// Result of the last attempt to reach this number
    /// </summary>
    /// <value>Result of the last attempt to reach this number</value>
    [JsonPropertyName("lastResult")]
    public string LastResult { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallRecord {\n");

        sb.Append("  LastAttempt: ").Append(LastAttempt).Append("\n");
        sb.Append("  LastResult: ").Append(LastResult).Append("\n");
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
        return Equals(obj as CallRecord);
    }

    /// <summary>
    /// Returns true if CallRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of CallRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallRecord other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LastAttempt == other.LastAttempt ||
                LastAttempt != null &&
                LastAttempt.Equals(other.LastAttempt)
            ) &&
            (
                LastResult == other.LastResult ||
                LastResult != null &&
                LastResult.Equals(other.LastResult)
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
            if (LastAttempt != null)
            {
                hash = hash * 59 + LastAttempt.GetHashCode();
            }

            if (LastResult != null)
            {
                hash = hash * 59 + LastResult.GetHashCode();
            }

            return hash;
        }
    }
}
