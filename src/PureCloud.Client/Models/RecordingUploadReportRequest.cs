using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingUploadReportRequest
/// </summary>

public partial class RecordingUploadReportRequest : IEquatable<RecordingUploadReportRequest>
{
    /// <summary>
    /// Report will include uploads with this status
    /// </summary>
    /// <value>Report will include uploads with this status</value>
    
    public enum UploadStatusEnum
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
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failure for "Failure"
        /// </summary>
        [EnumMember(Value = "Failure")]
        Failure,

        /// <summary>
        /// Enum Waitforconversation for "WaitForConversation"
        /// </summary>
        [EnumMember(Value = "WaitForConversation")]
        Waitforconversation
    }
    /// <summary>
    /// Report will include uploads with this status
    /// </summary>
    /// <value>Report will include uploads with this status</value>
    [JsonPropertyName("uploadStatus")]
    public UploadStatusEnum? UploadStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingUploadReportRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecordingUploadReportRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingUploadReportRequest" /> class.
    /// </summary>
    /// <param name="DateSince">Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="UploadStatus">Report will include uploads with this status.</param>
    public RecordingUploadReportRequest(DateTime? DateSince = null, UploadStatusEnum? UploadStatus = null)
    {
        this.DateSince = DateSince;
        this.UploadStatus = UploadStatus;

    }



    /// <summary>
    /// Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateSince")]
    public DateTime? DateSince { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingUploadReportRequest {\n");

        sb.Append("  DateSince: ").Append(DateSince).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
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
        return Equals(obj as RecordingUploadReportRequest);
    }

    /// <summary>
    /// Returns true if RecordingUploadReportRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingUploadReportRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingUploadReportRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateSince == other.DateSince ||
                DateSince != null &&
                DateSince.Equals(other.DateSince)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
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
            if (DateSince != null)
            {
                hash = hash * 59 + DateSince.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            return hash;
        }
    }
}
