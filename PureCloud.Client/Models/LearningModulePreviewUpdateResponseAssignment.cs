using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update response assignment
/// </summary>
[DataContract]
public partial class LearningModulePreviewUpdateResponseAssignment : IEquatable<LearningModulePreviewUpdateResponseAssignment>
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
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateResponseAssignment" /> class.
    /// </summary>
    /// <param name="State">The Learning Assignment state.</param>
    public LearningModulePreviewUpdateResponseAssignment(StateEnum? State = null)
    {
        this.State = State;

    }





    /// <summary>
    /// The user&#39;s percentage score for this assignment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment</value>
    [DataMember(Name = "percentageScore", EmitDefaultValue = false)]
    public float? PercentageScore { get; private set; }



    /// <summary>
    /// The overall completion percentage of assignment
    /// </summary>
    /// <value>The overall completion percentage of assignment</value>
    [DataMember(Name = "completionPercentage", EmitDefaultValue = false)]
    public float? CompletionPercentage { get; private set; }



    /// <summary>
    /// The user&#39;s percentage score for this assignment&#39;s assessment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment&#39;s assessment</value>
    [DataMember(Name = "assessmentPercentageScore", EmitDefaultValue = false)]
    public float? AssessmentPercentageScore { get; private set; }



    /// <summary>
    /// The assessment completion percentage of assignment
    /// </summary>
    /// <value>The assessment completion percentage of assignment</value>
    [DataMember(Name = "assessmentCompletionPercentage", EmitDefaultValue = false)]
    public float? AssessmentCompletionPercentage { get; private set; }



    /// <summary>
    /// True if the assessment was passed
    /// </summary>
    /// <value>True if the assessment was passed</value>
    [DataMember(Name = "isPassed", EmitDefaultValue = false)]
    public bool? IsPassed { get; private set; }



    /// <summary>
    /// The next assignment step
    /// </summary>
    /// <value>The next assignment step</value>
    [DataMember(Name = "currentStep", EmitDefaultValue = false)]
    public LearningModulePreviewUpdateResponseCurrentStep CurrentStep { get; private set; }



    /// <summary>
    /// List of assignment steps
    /// </summary>
    /// <value>List of assignment steps</value>
    [DataMember(Name = "steps", EmitDefaultValue = false)]
    public List<LearningModulePreviewUpdateStep> Steps { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewUpdateResponseAssignment {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
        sb.Append("  AssessmentPercentageScore: ").Append(AssessmentPercentageScore).Append("\n");
        sb.Append("  AssessmentCompletionPercentage: ").Append(AssessmentCompletionPercentage).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
        sb.Append("  CurrentStep: ").Append(CurrentStep).Append("\n");
        sb.Append("  Steps: ").Append(Steps).Append("\n");
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
        return Equals(obj as LearningModulePreviewUpdateResponseAssignment);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateResponseAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateResponseAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateResponseAssignment other)
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
                CompletionPercentage == other.CompletionPercentage ||
                CompletionPercentage != null &&
                CompletionPercentage.Equals(other.CompletionPercentage)
            ) &&
            (
                AssessmentPercentageScore == other.AssessmentPercentageScore ||
                AssessmentPercentageScore != null &&
                AssessmentPercentageScore.Equals(other.AssessmentPercentageScore)
            ) &&
            (
                AssessmentCompletionPercentage == other.AssessmentCompletionPercentage ||
                AssessmentCompletionPercentage != null &&
                AssessmentCompletionPercentage.Equals(other.AssessmentCompletionPercentage)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
            ) &&
            (
                CurrentStep == other.CurrentStep ||
                CurrentStep != null &&
                CurrentStep.Equals(other.CurrentStep)
            ) &&
            (
                Steps == other.Steps ||
                Steps != null &&
                Steps.SequenceEqual(other.Steps)
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

            if (CompletionPercentage != null)
            {
                hash = hash * 59 + CompletionPercentage.GetHashCode();
            }

            if (AssessmentPercentageScore != null)
            {
                hash = hash * 59 + AssessmentPercentageScore.GetHashCode();
            }

            if (AssessmentCompletionPercentage != null)
            {
                hash = hash * 59 + AssessmentCompletionPercentage.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            if (CurrentStep != null)
            {
                hash = hash * 59 + CurrentStep.GetHashCode();
            }

            if (Steps != null)
            {
                hash = hash * 59 + Steps.GetHashCode();
            }

            return hash;
        }
    }
}
