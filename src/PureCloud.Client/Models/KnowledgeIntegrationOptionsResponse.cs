using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeIntegrationOptionsResponse
/// </summary>

public partial class KnowledgeIntegrationOptionsResponse : IEquatable<KnowledgeIntegrationOptionsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeIntegrationOptionsResponse" /> class.
    /// </summary>
    /// <param name="Filters">Filter setting options available for a knowledge source..</param>
    public KnowledgeIntegrationOptionsResponse(List<KnowledgeIntegrationFilter> Filters = null)
    {
        this.Filters = Filters;

    }



    /// <summary>
    /// Filter setting options available for a knowledge source.
    /// </summary>
    /// <value>Filter setting options available for a knowledge source.</value>
    [JsonPropertyName("filters")]
    public List<KnowledgeIntegrationFilter> Filters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeIntegrationOptionsResponse {\n");

        sb.Append("  Filters: ").Append(Filters).Append("\n");
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
        return Equals(obj as KnowledgeIntegrationOptionsResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeIntegrationOptionsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeIntegrationOptionsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeIntegrationOptionsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
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
            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            return hash;
        }
    }
}
