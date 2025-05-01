using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkDeleteResponse
/// </summary>
[DataContract]
public partial class BulkDeleteResponse : IEquatable<BulkDeleteResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkDeleteResponse" /> class.
    /// </summary>
    /// <param name="Results">A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request..</param>
    /// <param name="ErrorCount">The number of failed operations in the results..</param>
    /// <param name="ErrorIndexes">The indexes of all failed operations in the results field..</param>
    public BulkDeleteResponse(List<BulkResponseResultVoidEntityBulkEntityErrorEntity> Results = null, int? ErrorCount = null, List<int?> ErrorIndexes = null)
    {
        this.Results = Results;
        this.ErrorCount = ErrorCount;
        this.ErrorIndexes = ErrorIndexes;

    }



    /// <summary>
    /// A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request.
    /// </summary>
    /// <value>A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request.</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<BulkResponseResultVoidEntityBulkEntityErrorEntity> Results { get; set; }



    /// <summary>
    /// The number of failed operations in the results.
    /// </summary>
    /// <value>The number of failed operations in the results.</value>
    [DataMember(Name = "errorCount", EmitDefaultValue = false)]
    public int? ErrorCount { get; set; }



    /// <summary>
    /// The indexes of all failed operations in the results field.
    /// </summary>
    /// <value>The indexes of all failed operations in the results field.</value>
    [DataMember(Name = "errorIndexes", EmitDefaultValue = false)]
    public List<int?> ErrorIndexes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkDeleteResponse {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
        sb.Append("  ErrorIndexes: ").Append(ErrorIndexes).Append("\n");
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
        return Equals(obj as BulkDeleteResponse);
    }

    /// <summary>
    /// Returns true if BulkDeleteResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkDeleteResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkDeleteResponse other)
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
            ) &&
            (
                ErrorCount == other.ErrorCount ||
                ErrorCount != null &&
                ErrorCount.Equals(other.ErrorCount)
            ) &&
            (
                ErrorIndexes == other.ErrorIndexes ||
                ErrorIndexes != null &&
                ErrorIndexes.SequenceEqual(other.ErrorIndexes)
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

            if (ErrorCount != null)
            {
                hash = hash * 59 + ErrorCount.GetHashCode();
            }

            if (ErrorIndexes != null)
            {
                hash = hash * 59 + ErrorIndexes.GetHashCode();
            }

            return hash;
        }
    }
}
