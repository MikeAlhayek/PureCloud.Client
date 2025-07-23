using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssessment
/// </summary>
public sealed class LearningAssessment
{
    /// <summary>
    /// Status of the assessment
    /// </summary>
    /// <value>Status of the assessment</value>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished
    }
    /// <summary>
    /// Status of the assessment
    /// </summary>
    /// <value>Status of the assessment</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssessment" /> class.
    /// </summary>
    /// <param name="Answers">Answers for the assessment.</param>
    public LearningAssessment(AssessmentScoringSet Answers = null)
    {
        this.Answers = Answers;

    }



    /// <summary>
    /// The Id of the assessment
    /// </summary>
    /// <value>The Id of the assessment</value>
    [JsonPropertyName("assessmentId")]
    public string AssessmentId { get; set; }



    /// <summary>
    /// The context Id of the related assessment form
    /// </summary>
    /// <value>The context Id of the related assessment form</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }



    /// <summary>
    /// The Id of the related assessment form
    /// </summary>
    /// <value>The Id of the related assessment form</value>
    [JsonPropertyName("assessmentFormId")]
    public string AssessmentFormId { get; set; }





    /// <summary>
    /// Answers for the assessment
    /// </summary>
    /// <value>Answers for the assessment</value>
    [JsonPropertyName("answers")]
    public AssessmentScoringSet Answers { get; set; }



    /// <summary>
    /// Date the assessment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date the assessment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date the assessment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date the assessment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Date the assessment was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date the assessment was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateSubmitted")]
    public DateTime? DateSubmitted { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssessment {\n");

        sb.Append("  AssessmentId: ").Append(AssessmentId).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  AssessmentFormId: ").Append(AssessmentFormId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateSubmitted: ").Append(DateSubmitted).Append("\n");
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
        return Equals(obj as LearningAssessment);
    }

    /// <summary>
    /// Returns true if LearningAssessment instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssessment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssessment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AssessmentId == other.AssessmentId ||
                AssessmentId != null &&
                AssessmentId.Equals(other.AssessmentId)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                AssessmentFormId == other.AssessmentFormId ||
                AssessmentFormId != null &&
                AssessmentFormId.Equals(other.AssessmentFormId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateSubmitted == other.DateSubmitted ||
                DateSubmitted != null &&
                DateSubmitted.Equals(other.DateSubmitted)
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
            if (AssessmentId != null)
            {
                hash = hash * 59 + AssessmentId.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (AssessmentFormId != null)
            {
                hash = hash * 59 + AssessmentFormId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateSubmitted != null)
            {
                hash = hash * 59 + DateSubmitted.GetHashCode();
            }

            return hash;
        }
    }
}
