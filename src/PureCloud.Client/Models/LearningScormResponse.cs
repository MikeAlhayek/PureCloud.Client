using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning SCORM package
/// </summary>

public partial class LearningScormResponse : IEquatable<LearningScormResponse>
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
    /// Initializes a new instance of the <see cref="LearningScormResponse" /> class.
    /// </summary>
    /// <param name="Status">The status of the SCORM package.</param>
    /// <param name="ErrorCode">The error code of the SCORM package (on failure).</param>
    /// <param name="ErrorMessage">The error message associated with the error code.</param>
    /// <param name="PercentageUnpacked">The percentage of the SCORM package that has been unpacked.</param>
    public LearningScormResponse(StatusEnum? Status = null, string ErrorCode = null, string ErrorMessage = null, float? PercentageUnpacked = null)
    {
        this.Status = Status;
        this.ErrorCode = ErrorCode;
        this.ErrorMessage = ErrorMessage;
        this.PercentageUnpacked = PercentageUnpacked;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }





    /// <summary>
    /// The error code of the SCORM package (on failure)
    /// </summary>
    /// <value>The error code of the SCORM package (on failure)</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// The error message associated with the error code
    /// </summary>
    /// <value>The error message associated with the error code</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }



    /// <summary>
    /// The percentage of the SCORM package that has been unpacked
    /// </summary>
    /// <value>The percentage of the SCORM package that has been unpacked</value>
    [JsonPropertyName("percentageUnpacked")]
    public float? PercentageUnpacked { get; set; }



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
        sb.Append("class LearningScormResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  PercentageUnpacked: ").Append(PercentageUnpacked).Append("\n");
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
        return Equals(obj as LearningScormResponse);
    }

    /// <summary>
    /// Returns true if LearningScormResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningScormResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningScormResponse other)
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
            ) &&
            (
                PercentageUnpacked == other.PercentageUnpacked ||
                PercentageUnpacked != null &&
                PercentageUnpacked.Equals(other.PercentageUnpacked)
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

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (PercentageUnpacked != null)
            {
                hash = hash * 59 + PercentageUnpacked.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
