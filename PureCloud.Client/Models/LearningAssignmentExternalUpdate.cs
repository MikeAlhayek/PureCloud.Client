using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentExternalUpdate
/// </summary>
[DataContract]
public partial class LearningAssignmentExternalUpdate : IEquatable<LearningAssignmentExternalUpdate>
{
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
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
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentExternalUpdate" /> class.
    /// </summary>
    /// <param name="State">The Learning Assignment state.</param>
    /// <param name="PercentageScore">The score.</param>
    /// <param name="IsPassed">Was the assignment marked as passed.</param>
    public LearningAssignmentExternalUpdate(StateEnum? State = null, float? PercentageScore = null, bool? IsPassed = null)
    {
        this.State = State;
        this.PercentageScore = PercentageScore;
        this.IsPassed = IsPassed;

    }





    /// <summary>
    /// The score
    /// </summary>
    /// <value>The score</value>
    [DataMember(Name = "percentageScore", EmitDefaultValue = false)]
    public float? PercentageScore { get; set; }



    /// <summary>
    /// Was the assignment marked as passed
    /// </summary>
    /// <value>Was the assignment marked as passed</value>
    [DataMember(Name = "isPassed", EmitDefaultValue = false)]
    public bool? IsPassed { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentExternalUpdate {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
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
        return Equals(obj as LearningAssignmentExternalUpdate);
    }

    /// <summary>
    /// Returns true if LearningAssignmentExternalUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentExternalUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentExternalUpdate other)
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
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
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

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            return hash;
        }
    }
}
