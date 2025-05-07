using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Action function zip file upload settings and state.
/// </summary>

public partial class FunctionZipConfig : IEquatable<FunctionZipConfig>
{
    /// <summary>
    /// Status of zip upload.
    /// </summary>
    /// <value>Status of zip upload.</value>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Transferring for "Transferring"
        /// </summary>
        [EnumMember(Value = "Transferring")]
        Transferring,

        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Invalid for "Invalid"
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid,

        /// <summary>
        /// Enum Invalidformat for "InvalidFormat"
        /// </summary>
        [EnumMember(Value = "InvalidFormat")]
        Invalidformat,

        /// <summary>
        /// Enum Invalidfile for "InvalidFile"
        /// </summary>
        [EnumMember(Value = "InvalidFile")]
        Invalidfile
    }
    /// <summary>
    /// Status of zip upload.
    /// </summary>
    /// <value>Status of zip upload.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FunctionZipConfig" /> class.
    /// </summary>
    public FunctionZipConfig()
    {

    }





    /// <summary>
    /// Zip file Identifier
    /// </summary>
    /// <value>Zip file Identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Zip file name
    /// </summary>
    /// <value>Zip file name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Error message if upload failed.
    /// </summary>
    /// <value>Error message if upload failed.</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }



    /// <summary>
    /// Upload request id used for zip upload
    /// </summary>
    /// <value>Upload request id used for zip upload</value>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FunctionZipConfig {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
        return Equals(obj as FunctionZipConfig);
    }

    /// <summary>
    /// Returns true if FunctionZipConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of FunctionZipConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FunctionZipConfig other)
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
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                RequestId == other.RequestId ||
                RequestId != null &&
                RequestId.Equals(other.RequestId)
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

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (RequestId != null)
            {
                hash = hash * 59 + RequestId.GetHashCode();
            }

            return hash;
        }
    }
}
