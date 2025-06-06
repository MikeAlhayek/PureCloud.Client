using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentFormQuestionGroup
/// </summary>

public partial class AssessmentFormQuestionGroup : IEquatable<AssessmentFormQuestionGroup>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentFormQuestionGroup" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentFormQuestionGroup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentFormQuestionGroup" /> class.
    /// </summary>
    /// <param name="Id">The ID of the question group,.</param>
    /// <param name="Name">The question group name (required).</param>
    /// <param name="Type">The question group type (required).</param>
    /// <param name="DefaultAnswersToHighest">DefaultAnswersToHighest.</param>
    /// <param name="DefaultAnswersToNA">DefaultAnswersToNA.</param>
    /// <param name="NaEnabled">NaEnabled.</param>
    /// <param name="Weight">Weight.</param>
    /// <param name="ManualWeight">ManualWeight.</param>
    /// <param name="Questions">The list of questions for this question group (required).</param>
    /// <param name="VisibilityCondition">VisibilityCondition.</param>
    public AssessmentFormQuestionGroup(string Id = null, string Name = null, string Type = null, bool? DefaultAnswersToHighest = null, bool? DefaultAnswersToNA = null, bool? NaEnabled = null, float? Weight = null, bool? ManualWeight = null, List<AssessmentFormQuestion> Questions = null, VisibilityCondition VisibilityCondition = null)
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
    /// The ID of the question group,
    /// </summary>
    /// <value>The ID of the question group,</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The question group name
    /// </summary>
    /// <value>The question group name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The question group type
    /// </summary>
    /// <value>The question group type</value>
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
    /// The list of questions for this question group
    /// </summary>
    /// <value>The list of questions for this question group</value>
    [JsonPropertyName("questions")]
    public List<AssessmentFormQuestion> Questions { get; set; }



    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    [JsonPropertyName("visibilityCondition")]
    public VisibilityCondition VisibilityCondition { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentFormQuestionGroup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DefaultAnswersToHighest: ").Append(DefaultAnswersToHighest).Append("\n");
        sb.Append("  DefaultAnswersToNA: ").Append(DefaultAnswersToNA).Append("\n");
        sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  ManualWeight: ").Append(ManualWeight).Append("\n");
        sb.Append("  Questions: ").Append(Questions).Append("\n");
        sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
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
        return Equals(obj as AssessmentFormQuestionGroup);
    }

    /// <summary>
    /// Returns true if AssessmentFormQuestionGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentFormQuestionGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentFormQuestionGroup other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
