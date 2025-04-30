using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuAsyncAgentSchedulesSearchResponse
    /// </summary>
    [DataContract]
    public partial class BuAsyncAgentSchedulesSearchResponse : IEquatable<BuAsyncAgentSchedulesSearchResponse>
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
        /// Initializes a new instance of the <see cref="BuAsyncAgentSchedulesSearchResponse" /> class.
        /// </summary>
        /// <param name="Status">The status of the operation.</param>
        /// <param name="OperationId">The ID for the operation.</param>
        /// <param name="Result">The result of the operation.  Null unless status &#x3D;&#x3D; Complete.</param>
        /// <param name="Progress">Percent progress for the operation.</param>
        /// <param name="DownloadUrl">The URL from which to download the result if it is too large to pass directly.</param>
        public BuAsyncAgentSchedulesSearchResponse(StatusEnum? Status = null, string OperationId = null, BuAgentSchedulesSearchResponse Result = null, int? Progress = null, string DownloadUrl = null)
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
        public BuAgentSchedulesSearchResponse Result { get; set; }



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
            sb.Append("class BuAsyncAgentSchedulesSearchResponse {\n");

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
            return this.Equals(obj as BuAsyncAgentSchedulesSearchResponse);
        }

        /// <summary>
        /// Returns true if BuAsyncAgentSchedulesSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAsyncAgentSchedulesSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAsyncAgentSchedulesSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();

                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();

                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                return hash;
            }
        }
    }

}
