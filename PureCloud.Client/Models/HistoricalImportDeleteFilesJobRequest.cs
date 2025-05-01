using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalImportDeleteFilesJobRequest
/// </summary>
[DataContract]
public partial class HistoricalImportDeleteFilesJobRequest : IEquatable<HistoricalImportDeleteFilesJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportDeleteFilesJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected HistoricalImportDeleteFilesJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportDeleteFilesJobRequest" /> class.
    /// </summary>
    /// <param name="RequestIds">List of requestIds to be deleted. Max number of RequestIds should be 100 (required).</param>
    public HistoricalImportDeleteFilesJobRequest(List<string> RequestIds = null)
    {
        this.RequestIds = RequestIds;

    }



    /// <summary>
    /// List of requestIds to be deleted. Max number of RequestIds should be 100
    /// </summary>
    /// <value>List of requestIds to be deleted. Max number of RequestIds should be 100</value>
    [DataMember(Name = "requestIds", EmitDefaultValue = false)]
    public List<string> RequestIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalImportDeleteFilesJobRequest {\n");

        sb.Append("  RequestIds: ").Append(RequestIds).Append("\n");
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
        return Equals(obj as HistoricalImportDeleteFilesJobRequest);
    }

    /// <summary>
    /// Returns true if HistoricalImportDeleteFilesJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalImportDeleteFilesJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalImportDeleteFilesJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RequestIds == other.RequestIds ||
                RequestIds != null &&
                RequestIds.SequenceEqual(other.RequestIds)
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
            if (RequestIds != null)
            {
                hash = hash * 59 + RequestIds.GetHashCode();
            }

            return hash;
        }
    }
}
