using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftAsyncResponse
/// </summary>

public partial class AlternativeShiftAsyncResponse : IEquatable<AlternativeShiftAsyncResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftAsyncResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftAsyncResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftAsyncResponse" /> class.
    /// </summary>
    /// <param name="Job">The job related to the async request (required).</param>
    public AlternativeShiftAsyncResponse(AlternativeShiftJobReference Job = null)
    {
        this.Job = Job;

    }



    /// <summary>
    /// The job related to the async request
    /// </summary>
    /// <value>The job related to the async request</value>
    [JsonPropertyName("job")]
    public AlternativeShiftJobReference Job { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeShiftAsyncResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
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
        return Equals(obj as AlternativeShiftAsyncResponse);
    }

    /// <summary>
    /// Returns true if AlternativeShiftAsyncResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftAsyncResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftAsyncResponse other)
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

            return hash;
        }
    }
}
