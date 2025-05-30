using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResultCounters
/// </summary>

public partial class ResultCounters : IEquatable<ResultCounters>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResultCounters" /> class.
    /// </summary>
    /// <param name="Success">Success.</param>
    /// <param name="Failure">Failure.</param>
    public ResultCounters(int? Success = null, int? Failure = null)
    {
        this.Success = Success;
        this.Failure = Failure;

    }



    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [JsonPropertyName("success")]
    public int? Success { get; set; }



    /// <summary>
    /// Gets or Sets Failure
    /// </summary>
    [JsonPropertyName("failure")]
    public int? Failure { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResultCounters {\n");

        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Failure: ").Append(Failure).Append("\n");
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
        return Equals(obj as ResultCounters);
    }

    /// <summary>
    /// Returns true if ResultCounters instances are equal
    /// </summary>
    /// <param name="other">Instance of ResultCounters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResultCounters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Success == other.Success ||
                Success != null &&
                Success.Equals(other.Success)
            ) &&
            (
                Failure == other.Failure ||
                Failure != null &&
                Failure.Equals(other.Failure)
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
            if (Success != null)
            {
                hash = hash * 59 + Success.GetHashCode();
            }

            if (Failure != null)
            {
                hash = hash * 59 + Failure.GetHashCode();
            }

            return hash;
        }
    }
}
