using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GetUploadSourceUrlJobStatusResponse
/// </summary>

public partial class GetUploadSourceUrlJobStatusResponse : IEquatable<GetUploadSourceUrlJobStatusResponse>
{
    /// <summary>
    /// Status of the upload job
    /// </summary>
    /// <value>Status of the upload job</value>
    
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
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Status of the upload job
    /// </summary>
    /// <value>Status of the upload job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="GetUploadSourceUrlJobStatusResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the upload from URL job..</param>
    /// <param name="Status">Status of the upload job.</param>
    /// <param name="UploadKey">Key that identifies the file in the storage including the file name.</param>
    /// <param name="ErrorInformation">Any error information, or null of the processing is not in failed state..</param>
    public GetUploadSourceUrlJobStatusResponse(string Id = null, StatusEnum? Status = null, string UploadKey = null, ErrorBody ErrorInformation = null)
    {
        this.Id = Id;
        this.Status = Status;
        this.UploadKey = UploadKey;
        this.ErrorInformation = ErrorInformation;

    }



    /// <summary>
    /// Id of the upload from URL job.
    /// </summary>
    /// <value>Id of the upload from URL job.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    /// <value>Key that identifies the file in the storage including the file name</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }



    /// <summary>
    /// Any error information, or null of the processing is not in failed state.
    /// </summary>
    /// <value>Any error information, or null of the processing is not in failed state.</value>
    [JsonPropertyName("errorInformation")]
    public ErrorBody ErrorInformation { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetUploadSourceUrlJobStatusResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as GetUploadSourceUrlJobStatusResponse);
    }

    /// <summary>
    /// Returns true if GetUploadSourceUrlJobStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of GetUploadSourceUrlJobStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GetUploadSourceUrlJobStatusResponse other)
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
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                ErrorInformation == other.ErrorInformation ||
                ErrorInformation != null &&
                ErrorInformation.Equals(other.ErrorInformation)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (ErrorInformation != null)
            {
                hash = hash * 59 + ErrorInformation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
