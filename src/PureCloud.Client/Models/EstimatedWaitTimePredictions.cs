using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EstimatedWaitTimePredictions
/// </summary>

public partial class EstimatedWaitTimePredictions : IEquatable<EstimatedWaitTimePredictions>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimatedWaitTimePredictions" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EstimatedWaitTimePredictions() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EstimatedWaitTimePredictions" /> class.
    /// </summary>
    /// <param name="Results">Returned upon a successful estimated wait time request. (required).</param>
    public EstimatedWaitTimePredictions(List<PredictionResults> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Returned upon a successful estimated wait time request.
    /// </summary>
    /// <value>Returned upon a successful estimated wait time request.</value>
    [JsonPropertyName("results")]
    public List<PredictionResults> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimatedWaitTimePredictions {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as EstimatedWaitTimePredictions);
    }

    /// <summary>
    /// Returns true if EstimatedWaitTimePredictions instances are equal
    /// </summary>
    /// <param name="other">Instance of EstimatedWaitTimePredictions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EstimatedWaitTimePredictions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
