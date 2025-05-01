using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BatchDownloadJobSubmission
/// </summary>
[DataContract]
public partial class BatchDownloadJobSubmission : IEquatable<BatchDownloadJobSubmission>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BatchDownloadJobSubmission" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BatchDownloadJobSubmission() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchDownloadJobSubmission" /> class.
    /// </summary>
    /// <param name="BatchDownloadRequestList">List of up to 100 items requested (required).</param>
    public BatchDownloadJobSubmission(List<BatchDownloadRequest> BatchDownloadRequestList = null)
    {
        this.BatchDownloadRequestList = BatchDownloadRequestList;

    }



    /// <summary>
    /// List of up to 100 items requested
    /// </summary>
    /// <value>List of up to 100 items requested</value>
    [DataMember(Name = "batchDownloadRequestList", EmitDefaultValue = false)]
    public List<BatchDownloadRequest> BatchDownloadRequestList { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchDownloadJobSubmission {\n");

        sb.Append("  BatchDownloadRequestList: ").Append(BatchDownloadRequestList).Append("\n");
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
        return Equals(obj as BatchDownloadJobSubmission);
    }

    /// <summary>
    /// Returns true if BatchDownloadJobSubmission instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchDownloadJobSubmission to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchDownloadJobSubmission other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BatchDownloadRequestList == other.BatchDownloadRequestList ||
                BatchDownloadRequestList != null &&
                BatchDownloadRequestList.SequenceEqual(other.BatchDownloadRequestList)
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
            if (BatchDownloadRequestList != null)
            {
                hash = hash * 59 + BatchDownloadRequestList.GetHashCode();
            }

            return hash;
        }
    }
}
