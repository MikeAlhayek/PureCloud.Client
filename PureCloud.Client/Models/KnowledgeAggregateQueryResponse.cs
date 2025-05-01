using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAggregateQueryResponse
/// </summary>
[DataContract]
public partial class KnowledgeAggregateQueryResponse : IEquatable<KnowledgeAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    public KnowledgeAggregateQueryResponse(List<KnowledgeAggregateDataContainer> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<KnowledgeAggregateDataContainer> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeAggregateQueryResponse {\n");

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
        return this.Equals(obj as KnowledgeAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAggregateQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Results == other.Results ||
                this.Results != null &&
                this.Results.SequenceEqual(other.Results)
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
            if (this.Results != null)
            {
                hash = hash * 59 + this.Results.GetHashCode();
            }

            return hash;
        }
    }
}
