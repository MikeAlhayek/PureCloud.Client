using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAssetStatus
/// </summary>

public partial class ResponseAssetStatus : IEquatable<ResponseAssetStatus>
{
    /// <summary>
    /// Upload status of the asset
    /// </summary>
    /// <value>Upload status of the asset</value>
    
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
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Uploaded for "Uploaded"
        /// </summary>
        [EnumMember(Value = "Uploaded")]
        Uploaded,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Upload status of the asset
    /// </summary>
    /// <value>Upload status of the asset</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseAssetStatus" /> class.
    /// </summary>
    public ResponseAssetStatus()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Error code. Used for localization
    /// </summary>
    /// <value>Error code. Used for localization</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Error message that explains upload failure status 
    /// </summary>
    /// <value>Error message that explains upload failure status </value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseAssetStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
        return Equals(obj as ResponseAssetStatus);
    }

    /// <summary>
    /// Returns true if ResponseAssetStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseAssetStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseAssetStatus other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            return hash;
        }
    }
}
