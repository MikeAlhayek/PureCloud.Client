using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkJobTerminateResultsResponse
/// </summary>
[DataContract]
public partial class BulkJobTerminateResultsResponse : IEquatable<BulkJobTerminateResultsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJobTerminateResultsResponse" /> class.
    /// </summary>
    /// <param name="Results">A list of the results from the bulk operation..</param>
    /// <param name="ErrorCount">The number of errors from the bulk operation..</param>
    /// <param name="ErrorIndexes">An index of where the errors are in the listing..</param>
    public BulkJobTerminateResultsResponse(List<BulkJobTerminateResult> Results = null, int? ErrorCount = null, List<int?> ErrorIndexes = null)
    {
        this.Results = Results;
        this.ErrorCount = ErrorCount;
        this.ErrorIndexes = ErrorIndexes;

    }



    /// <summary>
    /// A list of the results from the bulk operation.
    /// </summary>
    /// <value>A list of the results from the bulk operation.</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<BulkJobTerminateResult> Results { get; set; }



    /// <summary>
    /// The number of errors from the bulk operation.
    /// </summary>
    /// <value>The number of errors from the bulk operation.</value>
    [DataMember(Name = "errorCount", EmitDefaultValue = false)]
    public int? ErrorCount { get; set; }



    /// <summary>
    /// An index of where the errors are in the listing.
    /// </summary>
    /// <value>An index of where the errors are in the listing.</value>
    [DataMember(Name = "errorIndexes", EmitDefaultValue = false)]
    public List<int?> ErrorIndexes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkJobTerminateResultsResponse {\n");

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
        return Equals(obj as BulkJobTerminateResultsResponse);
    }

    /// <summary>
    /// Returns true if BulkJobTerminateResultsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkJobTerminateResultsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkJobTerminateResultsResponse other)
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
