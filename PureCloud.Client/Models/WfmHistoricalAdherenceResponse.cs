using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceResponse
/// </summary>

public partial class WfmHistoricalAdherenceResponse : IEquatable<WfmHistoricalAdherenceResponse>
{
    /// <summary>
    /// The state of the adherence query
    /// </summary>
    /// <value>The state of the adherence query</value>
    
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
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The state of the adherence query
    /// </summary>
    /// <value>The state of the adherence query</value>
    [JsonPropertyName("queryState")]
    public QueryStateEnum? QueryState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceResponse" /> class.
    /// </summary>
    /// <param name="Id">The query ID to listen for.</param>
    /// <param name="DownloadUrl">Deprecated. Use downloadUrls instead..</param>
    /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
    /// <param name="DownloadUrls">The uri list to GET the results of the Historical Adherence query. For notification purposes only.</param>
    /// <param name="QueryState">The state of the adherence query.</param>
    public WfmHistoricalAdherenceResponse(string Id = null, string DownloadUrl = null, WfmHistoricalAdherenceResultWrapper DownloadResult = null, List<string> DownloadUrls = null, QueryStateEnum? QueryState = null)
    {
        this.Id = Id;
        this.DownloadUrl = DownloadUrl;
        this.DownloadResult = DownloadResult;
        this.DownloadUrls = DownloadUrls;
        this.QueryState = QueryState;

    }



    /// <summary>
    /// The query ID to listen for
    /// </summary>
    /// <value>The query ID to listen for</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Deprecated. Use downloadUrls instead.
    /// </summary>
    /// <value>Deprecated. Use downloadUrls instead.</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Result will always come via downloadUrls; however the schema is included for documentation
    /// </summary>
    /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public WfmHistoricalAdherenceResultWrapper DownloadResult { get; set; }



    /// <summary>
    /// The uri list to GET the results of the Historical Adherence query. For notification purposes only
    /// </summary>
    /// <value>The uri list to GET the results of the Historical Adherence query. For notification purposes only</value>
    [JsonPropertyName("downloadUrls")]
    public List<string> DownloadUrls { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceResponse);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceResponse other)
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
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
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

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
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
