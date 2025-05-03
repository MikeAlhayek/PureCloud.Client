using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentFormQuestion
/// </summary>

public partial class AssessmentFormQuestion : IEquatable<AssessmentFormQuestion>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Multiplechoicequestion for "multipleChoiceQuestion"
        /// </summary>
        [EnumMember(Value = "multipleChoiceQuestion")]
        Multiplechoicequestion,

        /// <summary>
        /// Enum Freetextquestion for "freeTextQuestion"
        /// </summary>
        [EnumMember(Value = "freeTextQuestion")]
        Freetextquestion,

        /// <summary>
        /// Enum Npsquestion for "npsQuestion"
        /// </summary>
        [EnumMember(Value = "npsQuestion")]
        Npsquestion,

        /// <summary>
        /// Enum Readonlytextblockquestion for "readOnlyTextBlockQuestion"
        /// </summary>
        [EnumMember(Value = "readOnlyTextBlockQuestion")]
        Readonlytextblockquestion
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentFormQuestion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentFormQuestion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentFormQuestion" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Text">The question text (required).</param>
    /// <param name="HelpText">HelpText.</param>
    /// <param name="NaEnabled">NaEnabled.</param>
    /// <param name="CommentsRequired">CommentsRequired.</param>
    /// <param name="VisibilityCondition">VisibilityCondition.</param>
    /// <param name="AnswerOptions">Options from which to choose an answer for this question. Only used by Multiple Choice type questions..</param>
    /// <param name="MaxResponseCharacters">How many characters are allowed in the text response to this question. Used by Free Text question types..</param>
    /// <param name="IsKill">Does an incorrect answer to this question mark the form as having a failed kill question. Only used by Multiple Choice type questions..</param>
    /// <param name="IsCritical">Does this question contribute to the critical score. Only used by Multiple Choice type questions..</param>
    public AssessmentFormQuestion(string Id = null, TypeEnum? Type = null, string Text = null, string HelpText = null, bool? NaEnabled = null, bool? CommentsRequired = null, VisibilityCondition VisibilityCondition = null, List<AnswerOption> AnswerOptions = null, int? MaxResponseCharacters = null, bool? IsKill = null, bool? IsCritical = null)
    {
        this.Id = Id;
        this.Type = Type;
        this.Text = Text;
        this.HelpText = HelpText;
        this.NaEnabled = NaEnabled;
        this.CommentsRequired = CommentsRequired;
        this.VisibilityCondition = VisibilityCondition;
        this.AnswerOptions = AnswerOptions;
        this.MaxResponseCharacters = MaxResponseCharacters;
        this.IsKill = IsKill;
        this.IsCritical = IsCritical;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The question text
    /// </summary>
    /// <value>The question text</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets HelpText
    /// </summary>
    [JsonPropertyName("helpText")]
    public string HelpText { get; set; }



    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    [JsonPropertyName("naEnabled")]
    public bool? NaEnabled { get; set; }



    /// <summary>
    /// Gets or Sets CommentsRequired
    /// </summary>
    [JsonPropertyName("commentsRequired")]
    public bool? CommentsRequired { get; set; }



    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    [JsonPropertyName("visibilityCondition")]
    public VisibilityCondition VisibilityCondition { get; set; }



    /// <summary>
    /// Options from which to choose an answer for this question. Only used by Multiple Choice type questions.
    /// </summary>
    /// <value>Options from which to choose an answer for this question. Only used by Multiple Choice type questions.</value>
    [JsonPropertyName("answerOptions")]
    public List<AnswerOption> AnswerOptions { get; set; }



    /// <summary>
    /// How many characters are allowed in the text response to this question. Used by Free Text question types.
    /// </summary>
    /// <value>How many characters are allowed in the text response to this question. Used by Free Text question types.</value>
    [JsonPropertyName("maxResponseCharacters")]
    public int? MaxResponseCharacters { get; set; }



    /// <summary>
    /// Does an incorrect answer to this question mark the form as having a failed kill question. Only used by Multiple Choice type questions.
    /// </summary>
    /// <value>Does an incorrect answer to this question mark the form as having a failed kill question. Only used by Multiple Choice type questions.</value>
    [JsonPropertyName("isKill")]
    public bool? IsKill { get; set; }



    /// <summary>
    /// Does this question contribute to the critical score. Only used by Multiple Choice type questions.
    /// </summary>
    /// <value>Does this question contribute to the critical score. Only used by Multiple Choice type questions.</value>
    [JsonPropertyName("isCritical")]
    public bool? IsCritical { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentFormQuestion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  HelpText: ").Append(HelpText).Append("\n");
        sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
        sb.Append("  CommentsRequired: ").Append(CommentsRequired).Append("\n");
        sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
        sb.Append("  AnswerOptions: ").Append(AnswerOptions).Append("\n");
        sb.Append("  MaxResponseCharacters: ").Append(MaxResponseCharacters).Append("\n");
        sb.Append("  IsKill: ").Append(IsKill).Append("\n");
        sb.Append("  IsCritical: ").Append(IsCritical).Append("\n");
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
        return Equals(obj as AssessmentFormQuestion);
    }

    /// <summary>
    /// Returns true if AssessmentFormQuestion instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentFormQuestion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentFormQuestion other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                HelpText == other.HelpText ||
                HelpText != null &&
                HelpText.Equals(other.HelpText)
            ) &&
            (
                NaEnabled == other.NaEnabled ||
                NaEnabled != null &&
                NaEnabled.Equals(other.NaEnabled)
            ) &&
            (
                CommentsRequired == other.CommentsRequired ||
                CommentsRequired != null &&
                CommentsRequired.Equals(other.CommentsRequired)
            ) &&
            (
                VisibilityCondition == other.VisibilityCondition ||
                VisibilityCondition != null &&
                VisibilityCondition.Equals(other.VisibilityCondition)
            ) &&
            (
                AnswerOptions == other.AnswerOptions ||
                AnswerOptions != null &&
                AnswerOptions.SequenceEqual(other.AnswerOptions)
            ) &&
            (
                MaxResponseCharacters == other.MaxResponseCharacters ||
                MaxResponseCharacters != null &&
                MaxResponseCharacters.Equals(other.MaxResponseCharacters)
            ) &&
            (
                IsKill == other.IsKill ||
                IsKill != null &&
                IsKill.Equals(other.IsKill)
            ) &&
            (
                IsCritical == other.IsCritical ||
                IsCritical != null &&
                IsCritical.Equals(other.IsCritical)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (HelpText != null)
            {
                hash = hash * 59 + HelpText.GetHashCode();
            }

            if (NaEnabled != null)
            {
                hash = hash * 59 + NaEnabled.GetHashCode();
            }

            if (CommentsRequired != null)
            {
                hash = hash * 59 + CommentsRequired.GetHashCode();
            }

            if (VisibilityCondition != null)
            {
                hash = hash * 59 + VisibilityCondition.GetHashCode();
            }

            if (AnswerOptions != null)
            {
                hash = hash * 59 + AnswerOptions.GetHashCode();
            }

            if (MaxResponseCharacters != null)
            {
                hash = hash * 59 + MaxResponseCharacters.GetHashCode();
            }

            if (IsKill != null)
            {
                hash = hash * 59 + IsKill.GetHashCode();
            }

            if (IsCritical != null)
            {
                hash = hash * 59 + IsCritical.GetHashCode();
            }

            return hash;
        }
    }
}
