using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkContactsResponse
/// </summary>
[DataContract]
public partial class BulkContactsResponse : IEquatable<BulkContactsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkContactsResponse" /> class.
    /// </summary>
    /// <param name="Results">A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request..</param>
    /// <param name="ErrorCount">The number of failed operations in the results..</param>
    /// <param name="ErrorIndexes">The indexes of all failed operations in the results field..</param>
    public BulkContactsResponse(List<BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact> Results = null, int? ErrorCount = null, List<int?> ErrorIndexes = null)
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
    public List<BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact> Results { get; set; }



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
        sb.Append("class BulkContactsResponse {\n");

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
        return this.Equals(obj as BulkContactsResponse);
    }

    /// <summary>
    /// Returns true if BulkContactsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkContactsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkContactsResponse other)
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
            ) &&
            (
                this.ErrorCount == other.ErrorCount ||
                this.ErrorCount != null &&
                this.ErrorCount.Equals(other.ErrorCount)
            ) &&
            (
                this.ErrorIndexes == other.ErrorIndexes ||
                this.ErrorIndexes != null &&
                this.ErrorIndexes.SequenceEqual(other.ErrorIndexes)
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

            if (this.ErrorCount != null)
            {
                hash = hash * 59 + this.ErrorCount.GetHashCode();
            }

            if (this.ErrorIndexes != null)
            {
                hash = hash * 59 + this.ErrorIndexes.GetHashCode();
            }

            return hash;
        }
    }
}
