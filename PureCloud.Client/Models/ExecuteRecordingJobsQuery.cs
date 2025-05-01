using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExecuteRecordingJobsQuery
/// </summary>
[DataContract]
public partial class ExecuteRecordingJobsQuery : IEquatable<ExecuteRecordingJobsQuery>
{
    /// <summary>
    /// The desired state for the job to be set to.
    /// </summary>
    /// <value>The desired state for the job to be set to.</value>
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
        /// Enum Processing for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        Processing
    }
    /// <summary>
    /// The desired state for the job to be set to.
    /// </summary>
    /// <value>The desired state for the job to be set to.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExecuteRecordingJobsQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExecuteRecordingJobsQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExecuteRecordingJobsQuery" /> class.
    /// </summary>
    /// <param name="State">The desired state for the job to be set to. (required).</param>
    public ExecuteRecordingJobsQuery(StateEnum? State = null)
    {
        this.State = State;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExecuteRecordingJobsQuery {\n");

        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as ExecuteRecordingJobsQuery);
    }

    /// <summary>
    /// Returns true if ExecuteRecordingJobsQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of ExecuteRecordingJobsQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExecuteRecordingJobsQuery other)
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

            return hash;
        }
    }
}
