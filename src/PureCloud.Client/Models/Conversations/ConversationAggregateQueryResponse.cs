using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationAggregateQueryResponse
/// </summary>

public partial class ConversationAggregateQueryResponse : IEquatable<ConversationAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    public ConversationAggregateQueryResponse(List<ConversationAggregateDataContainer> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [JsonPropertyName("results")]
    public List<ConversationAggregateDataContainer> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationAggregateQueryResponse {\n");

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
        return Equals(obj as ConversationAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if ConversationAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationAggregateQueryResponse other)
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
