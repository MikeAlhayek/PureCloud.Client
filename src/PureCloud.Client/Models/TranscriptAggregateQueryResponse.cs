using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptAggregateQueryResponse
/// </summary>

public partial class TranscriptAggregateQueryResponse : IEquatable<TranscriptAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    public TranscriptAggregateQueryResponse(List<TranscriptAggregateDataContainer> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [JsonPropertyName("results")]
    public List<TranscriptAggregateDataContainer> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptAggregateQueryResponse {\n");

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
        return Equals(obj as TranscriptAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if TranscriptAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptAggregateQueryResponse other)
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
