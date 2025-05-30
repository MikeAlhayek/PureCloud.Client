using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemQueryJobResponse
/// </summary>

public partial class WorkitemQueryJobResponse : IEquatable<WorkitemQueryJobResponse>
{
    /// <summary>
    /// The state of the query job
    /// </summary>
    /// <value>The state of the query job</value>
    
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
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// The state of the query job
    /// </summary>
    /// <value>The state of the query job</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQueryJobResponse" /> class.
    /// </summary>
    /// <param name="State">The state of the query job.</param>
    /// <param name="DateStarted">The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateFinished">The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Error">The error associated with the query job, if the state is Failed.</param>
    public WorkitemQueryJobResponse(StateEnum? State = null, DateTime? DateStarted = null, DateTime? DateFinished = null, WorkitemQueryJobError Error = null)
    {
        this.State = State;
        this.DateStarted = DateStarted;
        this.DateFinished = DateFinished;
        this.Error = Error;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the job was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the job finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateFinished")]
    public DateTime? DateFinished { get; set; }



    /// <summary>
    /// The error associated with the query job, if the state is Failed
    /// </summary>
    /// <value>The error associated with the query job, if the state is Failed</value>
    [JsonPropertyName("error")]
    public WorkitemQueryJobError Error { get; set; }



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
        sb.Append("class WorkitemQueryJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateFinished: ").Append(DateFinished).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as WorkitemQueryJobResponse);
    }

    /// <summary>
    /// Returns true if WorkitemQueryJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemQueryJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemQueryJobResponse other)
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
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateFinished == other.DateFinished ||
                DateFinished != null &&
                DateFinished.Equals(other.DateFinished)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateFinished != null)
            {
                hash = hash * 59 + DateFinished.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
