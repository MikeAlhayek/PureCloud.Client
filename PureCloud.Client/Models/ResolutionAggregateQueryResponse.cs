using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ResolutionAggregateQueryResponse
/// </summary>
[DataContract]
public partial class ResolutionAggregateQueryResponse : IEquatable<ResolutionAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResolutionAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    public ResolutionAggregateQueryResponse(List<ResolutionAggregateDataContainer> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<ResolutionAggregateDataContainer> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResolutionAggregateQueryResponse {\n");

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
        return Equals(obj as ResolutionAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if ResolutionAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ResolutionAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResolutionAggregateQueryResponse other)
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
