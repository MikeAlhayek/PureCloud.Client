using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// SurveyAggregateQueryResponse
/// </summary>
[DataContract]
public partial class SurveyAggregateQueryResponse : IEquatable<SurveyAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    public SurveyAggregateQueryResponse(List<SurveyAggregateDataContainer> Results = null)
    {
        this.Results = Results;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<SurveyAggregateDataContainer> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyAggregateQueryResponse {\n");

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
        return this.Equals(obj as SurveyAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if SurveyAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyAggregateQueryResponse other)
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
