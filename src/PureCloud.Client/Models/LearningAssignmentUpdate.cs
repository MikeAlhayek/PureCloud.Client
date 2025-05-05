using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentUpdate
/// </summary>

public partial class LearningAssignmentUpdate : IEquatable<LearningAssignmentUpdate>
{
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
    
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
        /// Enum Assigned for "Assigned"
        /// </summary>
        [EnumMember(Value = "Assigned")]
        Assigned,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted,

        /// <summary>
        /// Enum Notcompleted for "NotCompleted"
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        Notcompleted,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule
    }
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentUpdate" /> class.
    /// </summary>
    /// <param name="State">The Learning Assignment state.</param>
    /// <param name="Assessment">An updated Assessment.</param>
    public LearningAssignmentUpdate(StateEnum? State = null, LearningAssessment Assessment = null)
    {
        this.State = State;
        this.Assessment = Assessment;

    }





    /// <summary>
    /// An updated Assessment
    /// </summary>
    /// <value>An updated Assessment</value>
    [JsonPropertyName("assessment")]
    public LearningAssessment Assessment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentUpdate {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Assessment: ").Append(Assessment).Append("\n");
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
        return Equals(obj as LearningAssignmentUpdate);
    }

    /// <summary>
    /// Returns true if LearningAssignmentUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentUpdate other)
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
                Assessment == other.Assessment ||
                Assessment != null &&
                Assessment.Equals(other.Assessment)
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

            if (Assessment != null)
            {
                hash = hash * 59 + Assessment.GetHashCode();
            }

            return hash;
        }
    }
}
