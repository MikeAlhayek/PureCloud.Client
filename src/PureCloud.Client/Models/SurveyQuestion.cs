using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyQuestion
/// </summary>

public partial class SurveyQuestion : IEquatable<SurveyQuestion>
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
    /// Initializes a new instance of the <see cref="SurveyQuestion" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Text">Text.</param>
    /// <param name="HelpText">HelpText.</param>
    /// <param name="Type">Type.</param>
    /// <param name="NaEnabled">NaEnabled.</param>
    /// <param name="VisibilityCondition">VisibilityCondition.</param>
    /// <param name="AnswerOptions">Options from which to choose an answer for this question. Only used by Multiple Choice type questions..</param>
    /// <param name="MaxResponseCharacters">How many characters are allowed in the text response to this question. Used by NPS and Free Text question types..</param>
    /// <param name="ExplanationPrompt">Prompt for details explaining the chosen NPS score. Used by NPS questions..</param>
    public SurveyQuestion(string Id = null, string Text = null, string HelpText = null, TypeEnum? Type = null, bool? NaEnabled = null, VisibilityCondition VisibilityCondition = null, List<AnswerOption> AnswerOptions = null, int? MaxResponseCharacters = null, string ExplanationPrompt = null)
    {
        this.Id = Id;
        this.Text = Text;
        this.HelpText = HelpText;
        this.Type = Type;
        this.NaEnabled = NaEnabled;
        this.VisibilityCondition = VisibilityCondition;
        this.AnswerOptions = AnswerOptions;
        this.MaxResponseCharacters = MaxResponseCharacters;
        this.ExplanationPrompt = ExplanationPrompt;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
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
    /// How many characters are allowed in the text response to this question. Used by NPS and Free Text question types.
    /// </summary>
    /// <value>How many characters are allowed in the text response to this question. Used by NPS and Free Text question types.</value>
    [JsonPropertyName("maxResponseCharacters")]
    public int? MaxResponseCharacters { get; set; }



    /// <summary>
    /// Prompt for details explaining the chosen NPS score. Used by NPS questions.
    /// </summary>
    /// <value>Prompt for details explaining the chosen NPS score. Used by NPS questions.</value>
    [JsonPropertyName("explanationPrompt")]
    public string ExplanationPrompt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyQuestion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  HelpText: ").Append(HelpText).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
        sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
        sb.Append("  AnswerOptions: ").Append(AnswerOptions).Append("\n");
        sb.Append("  MaxResponseCharacters: ").Append(MaxResponseCharacters).Append("\n");
        sb.Append("  ExplanationPrompt: ").Append(ExplanationPrompt).Append("\n");
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
        return Equals(obj as SurveyQuestion);
    }

    /// <summary>
    /// Returns true if SurveyQuestion instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyQuestion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyQuestion other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                NaEnabled == other.NaEnabled ||
                NaEnabled != null &&
                NaEnabled.Equals(other.NaEnabled)
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
                ExplanationPrompt == other.ExplanationPrompt ||
                ExplanationPrompt != null &&
                ExplanationPrompt.Equals(other.ExplanationPrompt)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (HelpText != null)
            {
                hash = hash * 59 + HelpText.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (NaEnabled != null)
            {
                hash = hash * 59 + NaEnabled.GetHashCode();
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

            if (ExplanationPrompt != null)
            {
                hash = hash * 59 + ExplanationPrompt.GetHashCode();
            }

            return hash;
        }
    }
}
