using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryResponseStats
/// </summary>

public partial class QueryResponseStats : IEquatable<QueryResponseStats>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryResponseStats" /> class.
    /// </summary>
    /// <param name="Count">The count for this metric.</param>
    public QueryResponseStats(int? Count = null)
    {
        this.Count = Count;

    }



    /// <summary>
    /// The count for this metric
    /// </summary>
    /// <value>The count for this metric</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryResponseStats {\n");

        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as QueryResponseStats);
    }

    /// <summary>
    /// Returns true if QueryResponseStats instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryResponseStats to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryResponseStats other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
