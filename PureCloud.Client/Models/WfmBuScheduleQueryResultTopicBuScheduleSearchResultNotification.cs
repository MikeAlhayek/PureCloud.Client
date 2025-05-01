using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification
/// </summary>
[DataContract]
public partial class WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification : IEquatable<WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification" /> class.
    /// </summary>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="BusinessUnitId">BusinessUnitId.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    public WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification(string OperationId = null, string BusinessUnitId = null, string DownloadUrl = null)
    {
        this.OperationId = OperationId;
        this.BusinessUnitId = BusinessUnitId;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name = "operationId", EmitDefaultValue = false)]
    public string OperationId { get; set; }



    /// <summary>
    /// Gets or Sets BusinessUnitId
    /// </summary>
    [DataMember(Name = "businessUnitId", EmitDefaultValue = false)]
    public string BusinessUnitId { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification {\n");

        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
        return Equals(obj as WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification);
    }

    /// <summary>
    /// Returns true if WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                BusinessUnitId == other.BusinessUnitId ||
                BusinessUnitId != null &&
                BusinessUnitId.Equals(other.BusinessUnitId)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
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
            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (BusinessUnitId != null)
            {
                hash = hash * 59 + BusinessUnitId.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
