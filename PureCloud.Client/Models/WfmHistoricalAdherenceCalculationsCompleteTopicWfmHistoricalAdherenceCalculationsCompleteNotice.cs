using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice
/// </summary>
[DataContract]
public partial class WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice : IEquatable<WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice>
{
    /// <summary>
    /// Gets or Sets QueryState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QueryStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets QueryState
    /// </summary>
    [DataMember(Name = "queryState", EmitDefaultValue = false)]
    public QueryStateEnum? QueryState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    /// <param name="DownloadUrls">DownloadUrls.</param>
    /// <param name="QueryState">QueryState.</param>
    public WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice(string Id = null, string DownloadUrl = null, List<string> DownloadUrls = null, QueryStateEnum? QueryState = null)
    {
        this.Id = Id;
        this.DownloadUrl = DownloadUrl;
        this.DownloadUrls = DownloadUrls;
        this.QueryState = QueryState;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUrls
    /// </summary>
    [DataMember(Name = "downloadUrls", EmitDefaultValue = false)]
    public List<string> DownloadUrls { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
        sb.Append("  QueryState: ").Append(QueryState).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                DownloadUrls == other.DownloadUrls ||
                DownloadUrls != null &&
                DownloadUrls.SequenceEqual(other.DownloadUrls)
            ) &&
            (
                QueryState == other.QueryState ||
                QueryState != null &&
                QueryState.Equals(other.QueryState)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (DownloadUrls != null)
            {
                hash = hash * 59 + DownloadUrls.GetHashCode();
            }

            if (QueryState != null)
            {
                hash = hash * 59 + QueryState.GetHashCode();
            }

            return hash;
        }
    }
}
