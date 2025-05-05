using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalShrinkageResponse
/// </summary>

public partial class WfmHistoricalShrinkageResponse : IEquatable<WfmHistoricalShrinkageResponse>
{
    /// <summary>
    /// The state of the shrinkage query
    /// </summary>
    /// <value>The state of the shrinkage query</value>
    
    public enum StateEnum
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
    /// The state of the shrinkage query
    /// </summary>
    /// <value>The state of the shrinkage query</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalShrinkageResponse" /> class.
    /// </summary>
    /// <param name="OperationId">The operationId for which to listen.</param>
    /// <param name="DownloadUrls">The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete.</param>
    /// <param name="DownloadResult">Result will always come via downloadUrls; however the schema is included for documentation.</param>
    /// <param name="State">The state of the shrinkage query.</param>
    public WfmHistoricalShrinkageResponse(string OperationId = null, List<string> DownloadUrls = null, HistoricalShrinkageResultListing DownloadResult = null, StateEnum? State = null)
    {
        this.OperationId = OperationId;
        this.DownloadUrls = DownloadUrls;
        this.DownloadResult = DownloadResult;
        this.State = State;

    }



    /// <summary>
    /// The operationId for which to listen
    /// </summary>
    /// <value>The operationId for which to listen</value>
    [JsonPropertyName("operationId")]
    public string OperationId { get; set; }



    /// <summary>
    /// The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete
    /// </summary>
    /// <value>The url list to GET the results of the Historical Shrinkage query. This field is populated only if query state is Complete</value>
    [JsonPropertyName("downloadUrls")]
    public List<string> DownloadUrls { get; set; }



    /// <summary>
    /// Result will always come via downloadUrls; however the schema is included for documentation
    /// </summary>
    /// <value>Result will always come via downloadUrls; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public HistoricalShrinkageResultListing DownloadResult { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalShrinkageResponse {\n");

        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  DownloadUrls: ").Append(DownloadUrls).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as WfmHistoricalShrinkageResponse);
    }

    /// <summary>
    /// Returns true if WfmHistoricalShrinkageResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalShrinkageResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalShrinkageResponse other)
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
                DownloadUrls == other.DownloadUrls ||
                DownloadUrls != null &&
                DownloadUrls.SequenceEqual(other.DownloadUrls)
            ) &&
            (
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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

            if (DownloadUrls != null)
            {
                hash = hash * 59 + DownloadUrls.GetHashCode();
            }

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
