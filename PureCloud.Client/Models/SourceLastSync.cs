using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SourceLastSync
/// </summary>
[DataContract]
public partial class SourceLastSync : IEquatable<SourceLastSync>
{
    /// <summary>
    /// State of the last synchronization.
    /// </summary>
    /// <value>State of the last synchronization.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// State of the last synchronization.
    /// </summary>
    /// <value>State of the last synchronization.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceLastSync" /> class.
    /// </summary>
    /// <param name="State">State of the last synchronization..</param>
    /// <param name="DateStarted">Last synchronization start-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateEnded">Last synchronization end-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Error">Optional error message of the last synchronization..</param>
    public SourceLastSync(StateEnum? State = null, DateTime? DateStarted = null, DateTime? DateEnded = null, ErrorBody Error = null)
    {
        this.State = State;
        this.DateStarted = DateStarted;
        this.DateEnded = DateEnded;
        this.Error = Error;

    }





    /// <summary>
    /// Last synchronization start-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last synchronization start-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStarted", EmitDefaultValue = false)]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// Last synchronization end-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last synchronization end-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateEnded", EmitDefaultValue = false)]
    public DateTime? DateEnded { get; set; }



    /// <summary>
    /// Optional error message of the last synchronization.
    /// </summary>
    /// <value>Optional error message of the last synchronization.</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorBody Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SourceLastSync {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateEnded: ").Append(DateEnded).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as SourceLastSync);
    }

    /// <summary>
    /// Returns true if SourceLastSync instances are equal
    /// </summary>
    /// <param name="other">Instance of SourceLastSync to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SourceLastSync other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateEnded == other.DateEnded ||
                DateEnded != null &&
                DateEnded.Equals(other.DateEnded)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateEnded != null)
            {
                hash = hash * 59 + DateEnded.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
