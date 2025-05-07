using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeAttributionJobStateResponse
/// </summary>

public partial class OutcomeAttributionJobStateResponse : IEquatable<OutcomeAttributionJobStateResponse>
{
    /// <summary>
    /// State of job.
    /// </summary>
    /// <value>State of job.</value>
    
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
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Completedwitherrors for "CompletedWithErrors"
        /// </summary>
        [EnumMember(Value = "CompletedWithErrors")]
        Completedwitherrors,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// State of job.
    /// </summary>
    /// <value>State of job.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionJobStateResponse" /> class.
    /// </summary>
    /// <param name="State">State of job..</param>
    /// <param name="ResultsUri">URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running..</param>
    /// <param name="PercentFailedThreshold">Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100..</param>
    /// <param name="CreatedDate">Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public OutcomeAttributionJobStateResponse(StateEnum? State = null, string ResultsUri = null, int? PercentFailedThreshold = null, DateTime? CreatedDate = null)
    {
        this.State = State;
        this.ResultsUri = ResultsUri;
        this.PercentFailedThreshold = PercentFailedThreshold;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running.
    /// </summary>
    /// <value>URI where the query results can be retrieved.  Populated when job has reached a terminal state, i.e. no longer Running.</value>
    [JsonPropertyName("resultsUri")]
    public string ResultsUri { get; set; }



    /// <summary>
    /// Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.
    /// </summary>
    /// <value>Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.</value>
    [JsonPropertyName("percentFailedThreshold")]
    public int? PercentFailedThreshold { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeAttributionJobStateResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ResultsUri: ").Append(ResultsUri).Append("\n");
        sb.Append("  PercentFailedThreshold: ").Append(PercentFailedThreshold).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as OutcomeAttributionJobStateResponse);
    }

    /// <summary>
    /// Returns true if OutcomeAttributionJobStateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeAttributionJobStateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeAttributionJobStateResponse other)
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
                ResultsUri == other.ResultsUri ||
                ResultsUri != null &&
                ResultsUri.Equals(other.ResultsUri)
            ) &&
            (
                PercentFailedThreshold == other.PercentFailedThreshold ||
                PercentFailedThreshold != null &&
                PercentFailedThreshold.Equals(other.PercentFailedThreshold)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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

            if (ResultsUri != null)
            {
                hash = hash * 59 + ResultsUri.GetHashCode();
            }

            if (PercentFailedThreshold != null)
            {
                hash = hash * 59 + PercentFailedThreshold.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
