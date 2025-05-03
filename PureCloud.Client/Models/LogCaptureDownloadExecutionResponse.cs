using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureDownloadExecutionResponse
/// </summary>

public partial class LogCaptureDownloadExecutionResponse : IEquatable<LogCaptureDownloadExecutionResponse>
{
    /// <summary>
    /// Execution state of the download.
    /// </summary>
    /// <value>Execution state of the download.</value>
    
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
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    /// <summary>
    /// Execution state of the download.
    /// </summary>
    /// <value>Execution state of the download.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureDownloadExecutionResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LogCaptureDownloadExecutionResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureDownloadExecutionResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of file download job. (required).</param>
    public LogCaptureDownloadExecutionResponse(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Id of file download job.
    /// </summary>
    /// <value>Id of file download job.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of file download execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; private set; }



    /// <summary>
    /// Url of a file with query result.
    /// </summary>
    /// <value>Url of a file with query result.</value>
    [JsonPropertyName("fileUrl")]
    public string FileUrl { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Details of the user that created the job
    /// </summary>
    /// <value>Details of the user that created the job</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LogCaptureDownloadExecutionResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as LogCaptureDownloadExecutionResponse);
    }

    /// <summary>
    /// Returns true if LogCaptureDownloadExecutionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LogCaptureDownloadExecutionResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LogCaptureDownloadExecutionResponse other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                FileUrl == other.FileUrl ||
                FileUrl != null &&
                FileUrl.Equals(other.FileUrl)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (FileUrl != null)
            {
                hash = hash * 59 + FileUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
