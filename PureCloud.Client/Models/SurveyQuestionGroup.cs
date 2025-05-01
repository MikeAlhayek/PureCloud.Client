using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyQuestionGroup
/// </summary>
[DataContract]
public partial class SurveyQuestionGroup : IEquatable<SurveyQuestionGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyQuestionGroup" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="NaEnabled">NaEnabled.</param>
    /// <param name="Questions">Questions.</param>
    /// <param name="VisibilityCondition">VisibilityCondition.</param>
    public SurveyQuestionGroup(string Id = null, string Name = null, string Type = null, bool? NaEnabled = null, List<SurveyQuestion> Questions = null, VisibilityCondition VisibilityCondition = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Type = Type;
        this.NaEnabled = NaEnabled;
        this.Questions = Questions;
        this.VisibilityCondition = VisibilityCondition;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    [DataMember(Name = "naEnabled", EmitDefaultValue = false)]
    public bool? NaEnabled { get; set; }



    /// <summary>
    /// Gets or Sets Questions
    /// </summary>
    [DataMember(Name = "questions", EmitDefaultValue = false)]
    public List<SurveyQuestion> Questions { get; set; }



    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    [DataMember(Name = "visibilityCondition", EmitDefaultValue = false)]
    public VisibilityCondition VisibilityCondition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyQuestionGroup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
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
        return Equals(obj as SurveyQuestionGroup);
    }

    /// <summary>
    /// Returns true if SurveyQuestionGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyQuestionGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyQuestionGroup other)
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
                NaEnabled == other.NaEnabled ||
                NaEnabled != null &&
                NaEnabled.Equals(other.NaEnabled)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (NaEnabled != null)
            {
                hash = hash * 59 + NaEnabled.GetHashCode();
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
