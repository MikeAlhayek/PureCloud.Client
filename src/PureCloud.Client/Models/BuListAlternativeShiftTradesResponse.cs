using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuListAlternativeShiftTradesResponse
/// </summary>

public partial class BuListAlternativeShiftTradesResponse : IEquatable<BuListAlternativeShiftTradesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuListAlternativeShiftTradesResponse" /> class.
    /// </summary>
    /// <param name="Job">The asynchronous job handling the request. Null if result returns synchronously.</param>
    /// <param name="Result">The result of the request. May come via notification. Null if job is populated.</param>
    public BuListAlternativeShiftTradesResponse(BuAlternativeShiftJobResponse Job = null, AlternativeShiftTradeListing Result = null)
    {
        this.Job = Job;
        this.Result = Result;

    }



    /// <summary>
    /// The asynchronous job handling the request. Null if result returns synchronously
    /// </summary>
    /// <value>The asynchronous job handling the request. Null if result returns synchronously</value>
    [JsonPropertyName("job")]
    public BuAlternativeShiftJobResponse Job { get; set; }



    /// <summary>
    /// The result of the request. May come via notification. Null if job is populated
    /// </summary>
    /// <value>The result of the request. May come via notification. Null if job is populated</value>
    [JsonPropertyName("result")]
    public AlternativeShiftTradeListing Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuListAlternativeShiftTradesResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as BuListAlternativeShiftTradesResponse);
    }

    /// <summary>
    /// Returns true if BuListAlternativeShiftTradesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuListAlternativeShiftTradesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuListAlternativeShiftTradesResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Job == other.Job ||
                Job != null &&
                Job.Equals(other.Job)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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
            if (Job != null)
            {
                hash = hash * 59 + Job.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}
