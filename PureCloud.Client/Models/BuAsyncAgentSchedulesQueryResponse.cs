using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAsyncAgentSchedulesQueryResponse
/// </summary>
[DataContract]
public partial class BuAsyncAgentSchedulesQueryResponse : IEquatable<BuAsyncAgentSchedulesQueryResponse>
{
    /// <summary>
    /// The status of the operation
    /// </summary>
    /// <value>The status of the operation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
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
    /// The status of the operation
    /// </summary>
    /// <value>The status of the operation</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAsyncAgentSchedulesQueryResponse" /> class.
    /// </summary>
    /// <param name="Status">The status of the operation.</param>
    /// <param name="OperationId">The ID for the operation.</param>
    /// <param name="Result">The result of the operation.  Null unless status &#x3D;&#x3D; Complete.</param>
    /// <param name="Progress">Percent progress for the operation.</param>
    /// <param name="DownloadUrl">The URL from which to download the result if it is too large to pass directly.</param>
    public BuAsyncAgentSchedulesQueryResponse(StatusEnum? Status = null, string OperationId = null, BuAgentSchedulesQueryResponse Result = null, int? Progress = null, string DownloadUrl = null)
    {
        this.Status = Status;
        this.OperationId = OperationId;
        this.Result = Result;
        this.Progress = Progress;
        this.DownloadUrl = DownloadUrl;

    }





    /// <summary>
    /// The ID for the operation
    /// </summary>
    /// <value>The ID for the operation</value>
    [DataMember(Name = "operationId", EmitDefaultValue = false)]
    public string OperationId { get; set; }



    /// <summary>
    /// The result of the operation.  Null unless status &#x3D;&#x3D; Complete
    /// </summary>
    /// <value>The result of the operation.  Null unless status &#x3D;&#x3D; Complete</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public BuAgentSchedulesQueryResponse Result { get; set; }



    /// <summary>
    /// Percent progress for the operation
    /// </summary>
    /// <value>Percent progress for the operation</value>
    [DataMember(Name = "progress", EmitDefaultValue = false)]
    public int? Progress { get; set; }



    /// <summary>
    /// The URL from which to download the result if it is too large to pass directly
    /// </summary>
    /// <value>The URL from which to download the result if it is too large to pass directly</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAsyncAgentSchedulesQueryResponse {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
        sb.Append("  Progress: ").Append(Progress).Append("\n");
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
        return Equals(obj as BuAsyncAgentSchedulesQueryResponse);
    }

    /// <summary>
    /// Returns true if BuAsyncAgentSchedulesQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAsyncAgentSchedulesQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAsyncAgentSchedulesQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
            ) &&
            (
                Progress == other.Progress ||
                Progress != null &&
                Progress.Equals(other.Progress)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            if (Progress != null)
            {
                hash = hash * 59 + Progress.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
