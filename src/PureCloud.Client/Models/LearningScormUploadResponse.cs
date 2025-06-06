using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning SCORM upload response
/// </summary>

public partial class LearningScormUploadResponse : IEquatable<LearningScormUploadResponse>
{
    /// <summary>
    /// The status of the SCORM package
    /// </summary>
    /// <value>The status of the SCORM package</value>
    
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
        /// Enum Uploadpending for "UploadPending"
        /// </summary>
        [EnumMember(Value = "UploadPending")]
        Uploadpending,

        /// <summary>
        /// Enum Unpacking for "Unpacking"
        /// </summary>
        [EnumMember(Value = "Unpacking")]
        Unpacking,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Ready for "Ready"
        /// </summary>
        [EnumMember(Value = "Ready")]
        Ready
    }
    /// <summary>
    /// The status of the SCORM package
    /// </summary>
    /// <value>The status of the SCORM package</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningScormUploadResponse" /> class.
    /// </summary>
    /// <param name="Status">The status of the SCORM package.</param>
    /// <param name="UploadUrl">The pre-signed URL. Use it with headers below to upload file to S3.</param>
    /// <param name="Headers">The additional headers that need to be included in the upload request.</param>
    public LearningScormUploadResponse(StatusEnum? Status = null, string UploadUrl = null, Dictionary<string, string> Headers = null)
    {
        this.Status = Status;
        this.UploadUrl = UploadUrl;
        this.Headers = Headers;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The pre-signed URL. Use it with headers below to upload file to S3
    /// </summary>
    /// <value>The pre-signed URL. Use it with headers below to upload file to S3</value>
    [JsonPropertyName("uploadUrl")]
    public string UploadUrl { get; set; }



    /// <summary>
    /// The additional headers that need to be included in the upload request
    /// </summary>
    /// <value>The additional headers that need to be included in the upload request</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningScormUploadResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
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
        return Equals(obj as LearningScormUploadResponse);
    }

    /// <summary>
    /// Returns true if LearningScormUploadResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningScormUploadResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningScormUploadResponse other)
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
                UploadUrl == other.UploadUrl ||
                UploadUrl != null &&
                UploadUrl.Equals(other.UploadUrl)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
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

            if (UploadUrl != null)
            {
                hash = hash * 59 + UploadUrl.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
