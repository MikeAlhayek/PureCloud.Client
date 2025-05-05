using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update request
/// </summary>

public partial class LearningModulePreviewUpdateRequest : IEquatable<LearningModulePreviewUpdateRequest>
{
    /// <summary>
    /// The assignment State
    /// </summary>
    /// <value>The assignment State</value>
    
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
    /// The assignment State
    /// </summary>
    /// <value>The assignment State</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateRequest" /> class.
    /// </summary>
    /// <param name="State">The assignment State.</param>
    /// <param name="CurrentStep">The assignment current step.</param>
    /// <param name="Steps">The assignment Steps.</param>
    /// <param name="Assessment">The assessment for learning module.</param>
    /// <param name="AssessmentForm">The assessment form for learning module.</param>
    public LearningModulePreviewUpdateRequest(StateEnum? State = null, LearningModulePreviewUpdateRequestCurrentStep CurrentStep = null, List<LearningModulePreviewUpdateStep> Steps = null, LearningAssessment Assessment = null, AssessmentForm AssessmentForm = null)
    {
        this.State = State;
        this.CurrentStep = CurrentStep;
        this.Steps = Steps;
        this.Assessment = Assessment;
        this.AssessmentForm = AssessmentForm;

    }





    /// <summary>
    /// The assignment current step
    /// </summary>
    /// <value>The assignment current step</value>
    [JsonPropertyName("currentStep")]
    public LearningModulePreviewUpdateRequestCurrentStep CurrentStep { get; set; }



    /// <summary>
    /// The assignment Steps
    /// </summary>
    /// <value>The assignment Steps</value>
    [JsonPropertyName("steps")]
    public List<LearningModulePreviewUpdateStep> Steps { get; set; }



    /// <summary>
    /// The assessment for learning module
    /// </summary>
    /// <value>The assessment for learning module</value>
    [JsonPropertyName("assessment")]
    public LearningAssessment Assessment { get; set; }



    /// <summary>
    /// The assessment form for learning module
    /// </summary>
    /// <value>The assessment form for learning module</value>
    [JsonPropertyName("assessmentForm")]
    public AssessmentForm AssessmentForm { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewUpdateRequest {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  CurrentStep: ").Append(CurrentStep).Append("\n");
        sb.Append("  Steps: ").Append(Steps).Append("\n");
        sb.Append("  Assessment: ").Append(Assessment).Append("\n");
        sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
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
        return Equals(obj as LearningModulePreviewUpdateRequest);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateRequest other)
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
                CurrentStep == other.CurrentStep ||
                CurrentStep != null &&
                CurrentStep.Equals(other.CurrentStep)
            ) &&
            (
                Steps == other.Steps ||
                Steps != null &&
                Steps.SequenceEqual(other.Steps)
            ) &&
            (
                Assessment == other.Assessment ||
                Assessment != null &&
                Assessment.Equals(other.Assessment)
            ) &&
            (
                AssessmentForm == other.AssessmentForm ||
                AssessmentForm != null &&
                AssessmentForm.Equals(other.AssessmentForm)
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

            if (CurrentStep != null)
            {
                hash = hash * 59 + CurrentStep.GetHashCode();
            }

            if (Steps != null)
            {
                hash = hash * 59 + Steps.GetHashCode();
            }

            if (Assessment != null)
            {
                hash = hash * 59 + Assessment.GetHashCode();
            }

            if (AssessmentForm != null)
            {
                hash = hash * 59 + AssessmentForm.GetHashCode();
            }

            return hash;
        }
    }
}
