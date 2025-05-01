using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainEdgeSoftwareUpdateDto
/// </summary>
[DataContract]
public partial class DomainEdgeSoftwareUpdateDto : IEquatable<DomainEdgeSoftwareUpdateDto>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
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
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Init for "INIT"
        /// </summary>
        [EnumMember(Value = "INIT")]
        Init,

        /// <summary>
        /// Enum InProgress for "IN_PROGRESS"
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        /// Enum Expired for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// Enum Exception for "EXCEPTION"
        /// </summary>
        [EnumMember(Value = "EXCEPTION")]
        Exception,

        /// <summary>
        /// Enum Aborted for "ABORTED"
        /// </summary>
        [EnumMember(Value = "ABORTED")]
        Aborted,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Enum Succeeded for "SUCCEEDED"
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        Succeeded,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DomainEdgeSoftwareUpdateDto" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DomainEdgeSoftwareUpdateDto() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainEdgeSoftwareUpdateDto" /> class.
    /// </summary>
    /// <param name="Version">Version (required).</param>
    /// <param name="MaxDownloadRate">MaxDownloadRate.</param>
    /// <param name="DownloadStartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExecuteStartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExecuteStopTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExecuteOnIdle">ExecuteOnIdle.</param>
    /// <param name="Status">Status.</param>
    /// <param name="EdgeUri">EdgeUri.</param>
    /// <param name="CallDrainingWaitTimeSeconds">CallDrainingWaitTimeSeconds.</param>
    /// <param name="Current">Current.</param>
    public DomainEdgeSoftwareUpdateDto(DomainEdgeSoftwareVersionDto Version = null, int? MaxDownloadRate = null, DateTime? DownloadStartTime = null, DateTime? ExecuteStartTime = null, DateTime? ExecuteStopTime = null, bool? ExecuteOnIdle = null, StatusEnum? Status = null, string EdgeUri = null, long? CallDrainingWaitTimeSeconds = null, bool? Current = null)
    {
        this.Version = Version;
        this.MaxDownloadRate = MaxDownloadRate;
        this.DownloadStartTime = DownloadStartTime;
        this.ExecuteStartTime = ExecuteStartTime;
        this.ExecuteStopTime = ExecuteStopTime;
        this.ExecuteOnIdle = ExecuteOnIdle;
        this.Status = Status;
        this.EdgeUri = EdgeUri;
        this.CallDrainingWaitTimeSeconds = CallDrainingWaitTimeSeconds;
        this.Current = Current;

    }



    /// <summary>
    /// Version
    /// </summary>
    /// <value>Version</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public DomainEdgeSoftwareVersionDto Version { get; set; }



    /// <summary>
    /// Gets or Sets MaxDownloadRate
    /// </summary>
    [DataMember(Name = "maxDownloadRate", EmitDefaultValue = false)]
    public int? MaxDownloadRate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "downloadStartTime", EmitDefaultValue = false)]
    public DateTime? DownloadStartTime { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "executeStartTime", EmitDefaultValue = false)]
    public DateTime? ExecuteStartTime { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "executeStopTime", EmitDefaultValue = false)]
    public DateTime? ExecuteStopTime { get; set; }



    /// <summary>
    /// Gets or Sets ExecuteOnIdle
    /// </summary>
    [DataMember(Name = "executeOnIdle", EmitDefaultValue = false)]
    public bool? ExecuteOnIdle { get; set; }





    /// <summary>
    /// Gets or Sets EdgeUri
    /// </summary>
    [DataMember(Name = "edgeUri", EmitDefaultValue = false)]
    public string EdgeUri { get; set; }



    /// <summary>
    /// Gets or Sets CallDrainingWaitTimeSeconds
    /// </summary>
    [DataMember(Name = "callDrainingWaitTimeSeconds", EmitDefaultValue = false)]
    public long? CallDrainingWaitTimeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets Current
    /// </summary>
    [DataMember(Name = "current", EmitDefaultValue = false)]
    public bool? Current { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainEdgeSoftwareUpdateDto {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  MaxDownloadRate: ").Append(MaxDownloadRate).Append("\n");
        sb.Append("  DownloadStartTime: ").Append(DownloadStartTime).Append("\n");
        sb.Append("  ExecuteStartTime: ").Append(ExecuteStartTime).Append("\n");
        sb.Append("  ExecuteStopTime: ").Append(ExecuteStopTime).Append("\n");
        sb.Append("  ExecuteOnIdle: ").Append(ExecuteOnIdle).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
        sb.Append("  CallDrainingWaitTimeSeconds: ").Append(CallDrainingWaitTimeSeconds).Append("\n");
        sb.Append("  Current: ").Append(Current).Append("\n");
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
        return Equals(obj as DomainEdgeSoftwareUpdateDto);
    }

    /// <summary>
    /// Returns true if DomainEdgeSoftwareUpdateDto instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainEdgeSoftwareUpdateDto to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainEdgeSoftwareUpdateDto other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                MaxDownloadRate == other.MaxDownloadRate ||
                MaxDownloadRate != null &&
                MaxDownloadRate.Equals(other.MaxDownloadRate)
            ) &&
            (
                DownloadStartTime == other.DownloadStartTime ||
                DownloadStartTime != null &&
                DownloadStartTime.Equals(other.DownloadStartTime)
            ) &&
            (
                ExecuteStartTime == other.ExecuteStartTime ||
                ExecuteStartTime != null &&
                ExecuteStartTime.Equals(other.ExecuteStartTime)
            ) &&
            (
                ExecuteStopTime == other.ExecuteStopTime ||
                ExecuteStopTime != null &&
                ExecuteStopTime.Equals(other.ExecuteStopTime)
            ) &&
            (
                ExecuteOnIdle == other.ExecuteOnIdle ||
                ExecuteOnIdle != null &&
                ExecuteOnIdle.Equals(other.ExecuteOnIdle)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                EdgeUri == other.EdgeUri ||
                EdgeUri != null &&
                EdgeUri.Equals(other.EdgeUri)
            ) &&
            (
                CallDrainingWaitTimeSeconds == other.CallDrainingWaitTimeSeconds ||
                CallDrainingWaitTimeSeconds != null &&
                CallDrainingWaitTimeSeconds.Equals(other.CallDrainingWaitTimeSeconds)
            ) &&
            (
                Current == other.Current ||
                Current != null &&
                Current.Equals(other.Current)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (MaxDownloadRate != null)
            {
                hash = hash * 59 + MaxDownloadRate.GetHashCode();
            }

            if (DownloadStartTime != null)
            {
                hash = hash * 59 + DownloadStartTime.GetHashCode();
            }

            if (ExecuteStartTime != null)
            {
                hash = hash * 59 + ExecuteStartTime.GetHashCode();
            }

            if (ExecuteStopTime != null)
            {
                hash = hash * 59 + ExecuteStopTime.GetHashCode();
            }

            if (ExecuteOnIdle != null)
            {
                hash = hash * 59 + ExecuteOnIdle.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (EdgeUri != null)
            {
                hash = hash * 59 + EdgeUri.GetHashCode();
            }

            if (CallDrainingWaitTimeSeconds != null)
            {
                hash = hash * 59 + CallDrainingWaitTimeSeconds.GetHashCode();
            }

            if (Current != null)
            {
                hash = hash * 59 + Current.GetHashCode();
            }

            return hash;
        }
    }
}
