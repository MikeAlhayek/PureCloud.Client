using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RequestContextPattern
/// </summary>

public partial class RequestContextPattern : IEquatable<RequestContextPattern>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestContextPattern" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RequestContextPattern() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestContextPattern" /> class.
    /// </summary>
    /// <param name="Criteria">A list of one or more criteria to satisfy. (required).</param>
    public RequestContextPattern(List<RequestEntityTypeCriteria> Criteria = null)
    {
        this.Criteria = Criteria;

    }



    /// <summary>
    /// A list of one or more criteria to satisfy.
    /// </summary>
    /// <value>A list of one or more criteria to satisfy.</value>
    [JsonPropertyName("criteria")]
    public List<RequestEntityTypeCriteria> Criteria { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestContextPattern {\n");

        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
        return Equals(obj as RequestContextPattern);
    }

    /// <summary>
    /// Returns true if RequestContextPattern instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestContextPattern to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestContextPattern other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.SequenceEqual(other.Criteria)
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
            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            return hash;
        }
    }
}
