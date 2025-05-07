using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQuestionGroup
/// </summary>

public partial class EvaluationQuestionGroup : IEquatable<EvaluationQuestionGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationQuestionGroup" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="DefaultAnswersToHighest">DefaultAnswersToHighest.</param>
    /// <param name="DefaultAnswersToNA">DefaultAnswersToNA.</param>
    /// <param name="NaEnabled">NaEnabled.</param>
    /// <param name="Weight">Weight.</param>
    /// <param name="ManualWeight">ManualWeight.</param>
    /// <param name="Questions">Questions.</param>
    /// <param name="VisibilityCondition">VisibilityCondition.</param>
    public EvaluationQuestionGroup(string Id = null, string Name = null, string Type = null, bool? DefaultAnswersToHighest = null, bool? DefaultAnswersToNA = null, bool? NaEnabled = null, float? Weight = null, bool? ManualWeight = null, List<EvaluationQuestion> Questions = null, VisibilityCondition VisibilityCondition = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Type = Type;
        this.DefaultAnswersToHighest = DefaultAnswersToHighest;
        this.DefaultAnswersToNA = DefaultAnswersToNA;
        this.NaEnabled = NaEnabled;
        this.Weight = Weight;
        this.ManualWeight = ManualWeight;
        this.Questions = Questions;
        this.VisibilityCondition = VisibilityCondition;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// An identifier for this question group that stays the same across versions of the form.
    /// </summary>
    /// <value>An identifier for this question group that stays the same across versions of the form.</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets DefaultAnswersToHighest
    /// </summary>
    [JsonPropertyName("defaultAnswersToHighest")]
    public bool? DefaultAnswersToHighest { get; set; }



    /// <summary>
    /// Gets or Sets DefaultAnswersToNA
    /// </summary>
    [JsonPropertyName("defaultAnswersToNA")]
    public bool? DefaultAnswersToNA { get; set; }



    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    [JsonPropertyName("naEnabled")]
    public bool? NaEnabled { get; set; }



    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [JsonPropertyName("weight")]
    public float? Weight { get; set; }



    /// <summary>
    /// Gets or Sets ManualWeight
    /// </summary>
    [JsonPropertyName("manualWeight")]
    public bool? ManualWeight { get; set; }



    /// <summary>
    /// Gets or Sets Questions
    /// </summary>
    [JsonPropertyName("questions")]
    public List<EvaluationQuestion> Questions { get; set; }



    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    [JsonPropertyName("visibilityCondition")]
    public VisibilityCondition VisibilityCondition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationQuestionGroup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DefaultAnswersToHighest: ").Append(DefaultAnswersToHighest).Append("\n");
        sb.Append("  DefaultAnswersToNA: ").Append(DefaultAnswersToNA).Append("\n");
        sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  ManualWeight: ").Append(ManualWeight).Append("\n");
        sb.Append("  Questions: ").Append(Questions).Append("\n");
        sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
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
        return Equals(obj as EvaluationQuestionGroup);
    }

    /// <summary>
    /// Returns true if EvaluationQuestionGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationQuestionGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationQuestionGroup other)
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
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                DefaultAnswersToHighest == other.DefaultAnswersToHighest ||
                DefaultAnswersToHighest != null &&
                DefaultAnswersToHighest.Equals(other.DefaultAnswersToHighest)
            ) &&
            (
                DefaultAnswersToNA == other.DefaultAnswersToNA ||
                DefaultAnswersToNA != null &&
                DefaultAnswersToNA.Equals(other.DefaultAnswersToNA)
            ) &&
            (
                NaEnabled == other.NaEnabled ||
                NaEnabled != null &&
                NaEnabled.Equals(other.NaEnabled)
            ) &&
            (
                Weight == other.Weight ||
                Weight != null &&
                Weight.Equals(other.Weight)
            ) &&
            (
                ManualWeight == other.ManualWeight ||
                ManualWeight != null &&
                ManualWeight.Equals(other.ManualWeight)
            ) &&
            (
                Questions == other.Questions ||
                Questions != null &&
                Questions.SequenceEqual(other.Questions)
            ) &&
            (
                VisibilityCondition == other.VisibilityCondition ||
                VisibilityCondition != null &&
                VisibilityCondition.Equals(other.VisibilityCondition)
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

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (DefaultAnswersToHighest != null)
            {
                hash = hash * 59 + DefaultAnswersToHighest.GetHashCode();
            }

            if (DefaultAnswersToNA != null)
            {
                hash = hash * 59 + DefaultAnswersToNA.GetHashCode();
            }

            if (NaEnabled != null)
            {
                hash = hash * 59 + NaEnabled.GetHashCode();
            }

            if (Weight != null)
            {
                hash = hash * 59 + Weight.GetHashCode();
            }

            if (ManualWeight != null)
            {
                hash = hash * 59 + ManualWeight.GetHashCode();
            }

            if (Questions != null)
            {
                hash = hash * 59 + Questions.GetHashCode();
            }

            if (VisibilityCondition != null)
            {
                hash = hash * 59 + VisibilityCondition.GetHashCode();
            }

            return hash;
        }
    }
}
