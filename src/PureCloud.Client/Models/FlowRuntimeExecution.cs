using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about the current state of a Flow execution
/// </summary>

public partial class FlowRuntimeExecution : IEquatable<FlowRuntimeExecution>
{
    /// <summary>
    /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
    /// </summary>
    /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
    
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
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Running for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        Running,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error,

        /// <summary>
        /// Enum Terminated for "TERMINATED"
        /// </summary>
        [EnumMember(Value = "TERMINATED")]
        Terminated,

        /// <summary>
        /// Enum Completed for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
    /// </summary>
    /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowRuntimeExecution" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowRuntimeExecution() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowRuntimeExecution" /> class.
    /// </summary>
    /// <param name="Id">The flow execution ID.</param>
    /// <param name="Name">The flow execution name..</param>
    /// <param name="FlowVersion">The Version of the flow definition of the flow execution. (required).</param>
    /// <param name="DateLaunched">The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Status">The flow&#39;s running status, which indicates whether the flow is running normally or completed, etc. (required).</param>
    /// <param name="DateCompleted">The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CompletionReason">The completion reason set at the flow completion time, if applicable..</param>
    /// <param name="FlowErrorInfo">Additional information if the flow is in error.</param>
    /// <param name="OutputData">List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows..</param>
    /// <param name="Conversation">The conversation to which this Flow execution is related.</param>
    public FlowRuntimeExecution(string Id = null, string Name = null, FlowVersion FlowVersion = null, DateTime? DateLaunched = null, StatusEnum? Status = null, DateTime? DateCompleted = null, string CompletionReason = null, ErrorBody FlowErrorInfo = null, Dictionary<string, object> OutputData = null, DomainEntityRef Conversation = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.FlowVersion = FlowVersion;
        this.DateLaunched = DateLaunched;
        this.Status = Status;
        this.DateCompleted = DateCompleted;
        this.CompletionReason = CompletionReason;
        this.FlowErrorInfo = FlowErrorInfo;
        this.OutputData = OutputData;
        this.Conversation = Conversation;

    }



    /// <summary>
    /// The flow execution ID
    /// </summary>
    /// <value>The flow execution ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow execution name.
    /// </summary>
    /// <value>The flow execution name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The Version of the flow definition of the flow execution.
    /// </summary>
    /// <value>The Version of the flow definition of the flow execution.</value>
    [JsonPropertyName("flowVersion")]
    public FlowVersion FlowVersion { get; set; }



    /// <summary>
    /// The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateLaunched")]
    public DateTime? DateLaunched { get; set; }





    /// <summary>
    /// The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; set; }



    /// <summary>
    /// The completion reason set at the flow completion time, if applicable.
    /// </summary>
    /// <value>The completion reason set at the flow completion time, if applicable.</value>
    [JsonPropertyName("completionReason")]
    public string CompletionReason { get; set; }



    /// <summary>
    /// Additional information if the flow is in error
    /// </summary>
    /// <value>Additional information if the flow is in error</value>
    [JsonPropertyName("flowErrorInfo")]
    public ErrorBody FlowErrorInfo { get; set; }



    /// <summary>
    /// List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.
    /// </summary>
    /// <value>List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.</value>
    [JsonPropertyName("outputData")]
    public Dictionary<string, object> OutputData { get; set; }



    /// <summary>
    /// The conversation to which this Flow execution is related
    /// </summary>
    /// <value>The conversation to which this Flow execution is related</value>
    [JsonPropertyName("conversation")]
    public DomainEntityRef Conversation { get; set; }



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
        sb.Append("class FlowRuntimeExecution {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  DateLaunched: ").Append(DateLaunched).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  CompletionReason: ").Append(CompletionReason).Append("\n");
        sb.Append("  FlowErrorInfo: ").Append(FlowErrorInfo).Append("\n");
        sb.Append("  OutputData: ").Append(OutputData).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
        return Equals(obj as FlowRuntimeExecution);
    }

    /// <summary>
    /// Returns true if FlowRuntimeExecution instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowRuntimeExecution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowRuntimeExecution other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                DateLaunched == other.DateLaunched ||
                DateLaunched != null &&
                DateLaunched.Equals(other.DateLaunched)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                CompletionReason == other.CompletionReason ||
                CompletionReason != null &&
                CompletionReason.Equals(other.CompletionReason)
            ) &&
            (
                FlowErrorInfo == other.FlowErrorInfo ||
                FlowErrorInfo != null &&
                FlowErrorInfo.Equals(other.FlowErrorInfo)
            ) &&
            (
                OutputData == other.OutputData ||
                OutputData != null &&
                OutputData.SequenceEqual(other.OutputData)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (DateLaunched != null)
            {
                hash = hash * 59 + DateLaunched.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (CompletionReason != null)
            {
                hash = hash * 59 + CompletionReason.GetHashCode();
            }

            if (FlowErrorInfo != null)
            {
                hash = hash * 59 + FlowErrorInfo.GetHashCode();
            }

            if (OutputData != null)
            {
                hash = hash * 59 + OutputData.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
